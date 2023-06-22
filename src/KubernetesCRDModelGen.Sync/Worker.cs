using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.Zip;
using k8s;
using k8s.Models;
using System.Net.Http.Json;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace KubernetesCRDModelGen.Sync;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    private readonly IConfiguration configuration;

    private readonly IHostApplicationLifetime _lifeTime;

    private readonly IHttpClientFactory httpClientFactory;

    public Worker(ILogger<Worker> logger, IConfiguration configuration, IHostApplicationLifetime lifeTime, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        this.configuration = configuration;
        _lifeTime = lifeTime;
        this.httpClientFactory = httpClientFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            _logger.LogInformation("Model Directory: {dir}", configuration.GetValue<string>("ModelDir"));

            var config = configuration.GetSection("Config").Get<List<Config>>();

            foreach (var item in config)
            {
                _logger.LogInformation("Processing: {group}", item.Group);

                CreateProject(item);

                if (item.DirectUrl != null)
                {
                    await ProcessDirectUrls(item);
                }
                if (item.GitHub != null)
                {
                    await ProcessGitHub(item);
                }
                if (item.Helm != null)
                {
                    await ProcessHelmChart(item);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Run Failed");
            Environment.ExitCode = 1;
        }

        _lifeTime.StopApplication();
    }

    private async Task ProcessDirectUrls(Config config)
    {
        foreach (var url in config.DirectUrl!.Urls)
        {
            await ProcessDirectUrl(config, url, config.DirectUrl.Filter);
        }
    }

    private async Task ProcessDirectUrl(Config config, string url, string? filter = null)
    {
        using var client = httpClientFactory.CreateClient();

        using var httpStream = await client.GetStreamAsync(url);
        using var stream = new MemoryStream();
        httpStream.CopyTo(stream);
        stream.Position = 0;

        var ext = Path.GetExtension(url);

        if (ext == ".yaml" || ext == ".yml")
        {
            ProcessYamlStream(config, stream);
        }
        else if (url.EndsWith(".zip"))
        {
            using var zipStream = new ZipFile(stream);
            foreach (ZipEntry entry in zipStream)
            {
                if (entry.Name.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase) || entry.Name.EndsWith(".yml", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(filter) && !entry.Name.StartsWith(filter))
                    {
                        continue;
                    }
                    using var fileContents = zipStream.GetInputStream(entry);
                    ProcessYamlStream(config, fileContents);
                }
            }
        }
        else if (url.EndsWith(".tar.gz"))
        {
            using var gzipStream = new GZipInputStream(stream);
            using var tarInputStream = new TarInputStream(gzipStream, Encoding.UTF8);
            TarEntry entry2;
            while ((entry2 = tarInputStream.GetNextEntry()) != null)
            {
                if (entry2.Name.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase) || entry2.Name.EndsWith(".yml", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(filter) && !entry2.Name.StartsWith(filter))
                    {
                        continue;
                    }
                    using var fileContents = new MemoryStream();
                    await tarInputStream.CopyEntryContentsAsync(fileContents, CancellationToken.None);
                    fileContents.Position = 0;
                    ProcessYamlStream(config, fileContents);
                }
            }
        }
    }

    private async Task ProcessGitHub(Config config)
    {
        using var client = httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.UserAgent.TryParseAdd("KubernetesCRDModelGen");

        var gitHubReleases = await client.GetFromJsonAsync<List<GitHubRelease>>(config.GitHub!.Repo);

        GitHubRelease release;

        if (!string.IsNullOrEmpty(config.GitHub.SemVer))
        {
            var range = new SemanticVersioning.Range(config.GitHub.SemVer);

            release = gitHubReleases.Where(x => !x.prerelease).OrderByDescending(x => SemanticVersioning.Version.Parse(x.name)).First(x => range.IsSatisfied(x.name));
        }
        else
        {
            release = gitHubReleases.Where(x => !x.prerelease).OrderByDescending(x => SemanticVersioning.Version.Parse(x.name)).First();
        }

        foreach (var item in release.assets)
        {
            if (!string.IsNullOrEmpty(config.GitHub.AssetFilter) && item.name.StartsWith(config.GitHub.AssetFilter, StringComparison.InvariantCultureIgnoreCase))
            {
                await ProcessDirectUrl(config, item.browser_download_url);
            }
        }
    }

    private async Task ProcessHelmChart(Config config)
    {
        await HelmClient.RepoRemove("temp");
        await HelmClient.RepoAdd("temp", config.Helm!.Repo);
        await HelmClient.RepoUpdate();

        var yaml = await HelmClient.Template("temp", config.Helm.Chart, config.Helm.PreRelease.GetValueOrDefault(), config.Helm.CMD);

        byte[] byteArray = Encoding.UTF8.GetBytes(yaml);
        var stream = new MemoryStream(byteArray);

        ProcessYamlStream(config, stream);

        await HelmClient.RepoRemove("temp");
    }

    private void ProcessYamlStream(Config config, Stream stream)
    {
        var serializer = new SerializerBuilder().Build();
        var deserializer = new DeserializerBuilder().Build();

        var txt = new StreamReader(stream);
        var parser = new Parser(txt);
        parser.Consume<StreamStart>();

        while (parser.Accept<DocumentStart>(out var start))
        {
            var doc = deserializer.Deserialize(parser);
            var yaml = serializer.Serialize(doc);

            if (yaml.Trim().Equals("---")) continue;

            try
            {
                var meta = KubernetesYaml.Deserialize<GenericObject>(yaml);
                var key = $"{meta.ApiVersion}/{meta.Kind}";

                if (key == $"{V1CustomResourceDefinition.KubeGroup}/{V1CustomResourceDefinition.KubeApiVersion}/{V1CustomResourceDefinition.KubeKind}")
                {
                    var filePath = Path.Combine(GetProjectPath(config), meta.Name() + ".yaml");

                    File.WriteAllText(filePath, yaml);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing yaml");
            }
        }
    }

    private static string GetName(Config config)
    {
        return "KubernetesCRDModelGen.Models." + config.Group;
    }

    private string GetProjectPath(Config config)
    {
        return Path.Combine(configuration.GetValue<string>("ModelDir"), GetName(config));
    }

    private void CreateProject(Config config)
    {
        var projectPath = GetProjectPath(config);

        var csprojPath = Path.Combine(projectPath, GetName(config) + ".csproj");

        Directory.CreateDirectory(projectPath);

        File.WriteAllText(csprojPath, """<Project Sdk="Microsoft.NET.Sdk"></Project>""");
    }
}