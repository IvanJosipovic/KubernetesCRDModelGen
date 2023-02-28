using k8s.Models;
using k8s;
using KubernetesCRDModelGen;

namespace Worker {
    public class Worker : BackgroundService
    {
        IHostApplicationLifetime hostApplicationLifetime;

        readonly ILogger<Worker> _logger;

        ICRDGenerator CRDGenerator;

        public Worker(ILogger<Worker> logger, IHostApplicationLifetime hostApplicationLifetime, ICRDGenerator cRDGenerator)
        {
            _logger = logger;
            this.hostApplicationLifetime = hostApplicationLifetime;
            CRDGenerator = cRDGenerator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var directories = Directory.GetDirectories("../Models");

            foreach (var item in directories) {
                var crds = GetCRDS(item);

                var name = Path.GetFileName(item);

                try {
                    var stream = await CRDGenerator.GeneratePackageStream(crds, name);

                    using (Stream outStream = File.OpenWrite($"{name}.nupkg")) {
                        stream.Item1.Seek(0, SeekOrigin.Begin);
                        stream.Item1.CopyTo(outStream);
                    }

                    using (Stream outStream = File.OpenWrite($"{name}.snupkg")) {
                        stream.Item2.Seek(0, SeekOrigin.Begin);
                        stream.Item2.CopyTo(outStream);
                    }
                }
                catch (Exception ex) {

                    //throw;
                }

            }

            hostApplicationLifetime.StopApplication();
        }

        protected IEnumerable<V1CustomResourceDefinition> GetCRDS(string path) {
            var crds = new List<V1CustomResourceDefinition>();
            foreach (var item in Directory.GetFiles(path)) {
                crds.Add(KubernetesYaml.Deserialize<V1CustomResourceDefinition>(File.OpenRead(item)));
            }

            return crds;
        }
    }
}