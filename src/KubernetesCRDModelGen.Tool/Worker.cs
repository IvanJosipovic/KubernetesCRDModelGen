using k8s.Models;
using k8s;
using KubernetesCRDModelGen;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Core.Events;
using KubernetesCRDModelGen.Base;

namespace Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> logger;
        private readonly IConfiguration configuration;
        private readonly IHostApplicationLifetime appLifetime;
        private readonly IGenerator generator;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, IHostApplicationLifetime appLifetime, IGenerator generator)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.appLifetime = appLifetime;
            this.generator = generator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            string? folderPath = configuration.GetValue<string>("FolderPath");

            if (string.IsNullOrEmpty(folderPath))
            {
                logger.LogError("--FolderPath parameter is missing");
                Environment.ExitCode = 1;
                appLifetime.StopApplication();
                return;
            }

            string @namespace = configuration.GetValue<string>("Namespace", Generator.ModelNamespace);

            logger.LogInformation("Tool started at: {time}", DateTimeOffset.Now);

            logger.LogInformation("Model Directory: {dir}", folderPath);

            var serializer = new SerializerBuilder().Build();

            var deserializer = new DeserializerBuilder().Build();

            foreach (var file in Directory.GetFiles(folderPath, "*.yaml"))
            {
                try
                {
                    var cont = await File.ReadAllTextAsync(file);

                    using TextReader reader = new StringReader(cont);

                    var parser = new MergingParser(new Parser(reader));

                    parser.Consume<StreamStart>();

                    while (parser.Accept<DocumentStart>(out var start))
                    {
                        var doc = deserializer.Deserialize(parser);
                        var yaml = serializer.Serialize(doc);

                        var meta = KubernetesYaml.Deserialize<KubernetesObject>(yaml);
                        var key = $"{meta.ApiVersion}/{meta.Kind}";

                        if (key == $"{V1CustomResourceDefinition.KubeGroup}/{V1CustomResourceDefinition.KubeApiVersion}/{V1CustomResourceDefinition.KubeKind}")
                        {
                            try
                            {
                                var crd = KubernetesYaml.Deserialize<V1CustomResourceDefinition>(yaml);
                                var code = generator.GenerateCode(crd, @namespace);

                                var filename = CodeGenerator.RemoveIllegalFileNameCharacters($"{crd.Metadata.Name}.g.cs");

                                logger.LogInformation("Generating: {file}", filename);

                                await File.WriteAllTextAsync(Path.Combine(folderPath, filename), code, stoppingToken);
                            }
                            catch (Exception e)
                            {
                                logger.LogError(e, "Error converting {file} {key} {e.Message}", file, key, e.Message);
                                Environment.ExitCode = 1;
                                appLifetime.StopApplication();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    logger.LogError(e,"Error parsing {file}", file);
                    Environment.ExitCode = 1;
                    appLifetime.StopApplication();
                }
            }

            logger.LogInformation("Tool completed at: {time}", DateTimeOffset.Now);
            Environment.ExitCode = 0;
            appLifetime.StopApplication();
        }
    }
}