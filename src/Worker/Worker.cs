using k8s.Models;
using k8s;
using KubernetesCRDModelGen;

namespace Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var objects = await Yaml.LoadAllFromFileAsync("CRD.yaml");

            var crd = objects.First() as V1CustomResourceDefinition;

            var gen = new Generator();

            gen.Generate(crd);

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}