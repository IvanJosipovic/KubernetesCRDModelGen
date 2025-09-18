using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.Zip;
using k8s;
using k8s.Models;
using System.Net.Http.Json;
using System.Reflection;
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

                try
                {
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
                    if (item.OCI != null)
                    {
                        await ProcessOCI(item);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Run Failed: {name}", item.Group);
                    throw;
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

    private async Task ProcessOCI(Config item)
    {
        var streams = await OCIClient.OCIClient.GetStreams(item);

        foreach (var stream in streams)
        {
            try
            {
                ProcessYamlStream(stream.Value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Processing Yaml Stream: {key}", stream.Key);
            }
        }
    }

    private async Task ProcessDirectUrls(Config config)
    {
        foreach (var url in config.DirectUrl!.Urls)
        {
            await ProcessDirectUrl(url, config.DirectUrl.Filter);
        }
    }

    private async Task ProcessDirectUrl(string url, string? filter = null)
    {
        using var client = httpClientFactory.CreateClient();

        using var httpStream = await client.GetStreamAsync(url);
        using var stream = new MemoryStream();
        httpStream.CopyTo(stream);
        stream.Position = 0;

        var ext = Path.GetExtension(url);

        if (ext == ".yaml" || ext == ".yml")
        {
            ProcessYamlStream(stream);
        }
        else if (url.EndsWith(".zip"))
        {
            using var zipStream = new ZipFile(stream);
            foreach (ZipEntry entry in zipStream)
            {
                if (entry.Name.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase) || entry.Name.EndsWith(".yml", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(filter) && !entry.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    using var fileContents = zipStream.GetInputStream(entry);
                    ProcessYamlStream(fileContents);
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
                    ProcessYamlStream(fileContents);
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

            release = gitHubReleases
                .Where(x => !x.prerelease && SemanticVersioning.Version.TryParse(x.name, true, out var ver) && x.assets.Any())
                .OrderByDescending(x => SemanticVersioning.Version.Parse(x.name, true))
                .First(x => range.IsSatisfied(x.name));
        }
        else
        {
            release = gitHubReleases
                .Where(x => !x.prerelease && SemanticVersioning.Version.TryParse(x.name, true, out var ver) && x.assets.Any())
                .OrderByDescending(x => SemanticVersioning.Version.Parse(x.name, true))
                .First();
        }

        foreach (var item in release.assets)
        {
            if (!string.IsNullOrEmpty(config.GitHub.AssetFilter) && item.name.StartsWith(config.GitHub.AssetFilter, StringComparison.InvariantCultureIgnoreCase))
            {
                await ProcessDirectUrl(item.browser_download_url);
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

        ProcessYamlStream(stream);

        await HelmClient.RepoRemove("temp");
    }

    private void ProcessYamlStream(Stream stream)
    {
        try
        {
            var txt = new StreamReader(stream);
            var crds = LoadAllFromString(txt.ReadToEnd());

            foreach (object resource in crds)
            {
                if (resource is V1CustomResourceDefinition crd)
                {
                    var filePath = Path.Combine("crds", crd.Name() + ".yaml");

                    File.WriteAllText(filePath, KubernetesYaml.Serialize(crd));
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing yaml");
        }
    }

    private static IDeserializer GetDeserializer(bool strict)
    {
        var type = typeof(k8s.KubernetesYaml);
        var method = type.GetMethod("GetDeserializer", BindingFlags.NonPublic | BindingFlags.Static);
        if (method == null)
        {
            throw new Exception("GetDeserializer Method Not Found");
        }
        return (IDeserializer)method.Invoke(null, [strict]);
    }

    private static List<object> LoadAllFromString(string content)
    {
        var parser = new MergingParser(new Parser(new StringReader(content)));
        var deserializer = GetDeserializer(false);
        parser.Consume<StreamStart>();

        var results = new List<object>();

        while (parser.Accept<DocumentStart>(out _))
        {
            var obj = deserializer.Deserialize(parser, typeof(V1CustomResourceDefinition)) as V1CustomResourceDefinition;

            if (obj == null || obj.Kind != V1CustomResourceDefinition.KubeKind || obj.ApiVersion != $"{V1CustomResourceDefinition.KubeGroup}/{V1CustomResourceDefinition.KubeApiVersion}")
            {
                continue;
            }

            results.Add(obj);
        }

        return results;
    }

    private static string GetName(Config config)
    {
        return "KubernetesCRDModelGen.Models." + config.Group;
    }

    private static void CreateProject(Config config)
    {
        Directory.CreateDirectory("crds");

        var csprojPath = Path.Combine(GetName(config) + ".csproj");

        File.WriteAllText(csprojPath, $"""
            <Project Sdk="Microsoft.NET.Sdk">
              <PropertyGroup>
                <PackageId>{GetName(config)}</PackageId>
                <RepositoryUrl>https://github.com/IvanJosipovic/{GetName(config)}</RepositoryUrl>
              </PropertyGroup>
            </Project>
            """);

        File.WriteAllText("README.md", $"""
            ## {GetName(config)}
            [![Nuget](https://img.shields.io/nuget/vpre/{GetName(config)}.svg?style=flat-square)](https://www.nuget.org/packages/{GetName(config)})[![Nuget)](https://img.shields.io/nuget/dt/{GetName(config)}.svg?style=flat-square)](https://www.nuget.org/packages/{GetName(config)})

            C# models for Kubernetes CRDs in group {config.Group}.
            """);
    }
}

class MapTagsToObject : INodeTypeResolver
{
    public bool Resolve(NodeEvent? nodeEvent, ref Type currentType)
    {
        if (nodeEvent != null && !nodeEvent.Tag.IsEmpty)
        {
            currentType = typeof(object);
            return true;
        }
        return false;
    }
}