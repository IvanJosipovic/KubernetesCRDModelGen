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
            var objects = await KubernetesYaml.LoadAllFromFileAsync("CRD.yaml");

            var crd = (V1CustomResourceDefinition)objects[0];

            var ass = await CRDGenerator.GenerateAssemblyStream(crd);

            using (Stream outStream = File.OpenWrite("models.dll")) {
                ass.Item1.Seek(0, SeekOrigin.Begin);
                ass.Item1.CopyTo(outStream);
            }

            using (Stream outStream = File.OpenWrite("models.xml")) {
                ass.Item2.Seek(0, SeekOrigin.Begin);
                ass.Item2.CopyTo(outStream);
            }

            //settings.DllOutput.Seek(0, SeekOrigin.Begin);
            //var assembly = System.Runtime.Loader.AssemblyLoadContext.Default.LoadFromStream(settings.DllOutput);

            //settings.XmlDocumentationOutput.Seek(0, SeekOrigin.Begin);
            //var xml = new XmlDocument();
            //xml.Load(settings.XmlDocumentationOutput);

            hostApplicationLifetime.StopApplication();
        }
    }
}