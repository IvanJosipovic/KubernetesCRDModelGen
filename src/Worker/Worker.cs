
using k8s.Models;
using k8s;
using KubernetesCRDModelGen;

namespace Worker {
    public class Worker : BackgroundService
    {
        IHostApplicationLifetime hostApplicationLifetime;

        readonly ILogger<Worker> _logger;

        ICRDGenerator CRDGenerator;

        public Worker(ILogger<Worker> logger, IHostApplicationLifetime hostApplicationLifetime, ICRDGenerator cRDGenerator) {
            _logger = logger;
            this.hostApplicationLifetime = hostApplicationLifetime;
            CRDGenerator = cRDGenerator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var objects = await KubernetesYaml.LoadAllFromFileAsync("CRD.yaml");

            var crd = (V1CustomResourceDefinition)objects[0];

            var ass = await CRDGenerator.GenerateAssembly(crd);

            hostApplicationLifetime.StopApplication();
        }
    }
}