using k8s.Models;
using k8s;
using KubernetesCRDModelGen;
using Microsoft.OpenApi.Readers;
using System.IO;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi;
using System.Net.Http;
using System.ComponentModel;

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
            //var objects = await KubernetesYaml.LoadAllFromFileAsync("CRD.yaml");

            //var crd = objects.First() as V1CustomResourceDefinition;

            var stream = File.OpenRead("openapi.yaml");

            var openApiDocument = new OpenApiStreamReader().Read(stream, out var diagnostic);

            var stream2 = await new HttpClient().GetStreamAsync("https://raw.githubusercontent.com/kubernetes/kubernetes/v1.25.6/api/openapi-spec/swagger.json");

            // Read V3 as YAML
            var openApiDocument2 = new OpenApiStreamReader().Read(stream2, out var diagnostic2);

            openApiDocument2.Paths.Clear();

            // Write V2 as JSON
            var outputString = openApiDocument2.Serialize(OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Yaml);

            //var gen = new CRDGenerator();

            //var code = gen.GenerateCode(crd);

            //var ass = await gen.GenerateAssembly(crd);
        }
    }


    public class IPropertyWrapper<T> : INotifyPropertyChanged
    {
        public IPropertyWrapper()
        {
            
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }

}