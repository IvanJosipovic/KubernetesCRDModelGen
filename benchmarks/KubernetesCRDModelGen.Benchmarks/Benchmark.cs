using BenchmarkDotNet.Attributes;
using k8s;
using k8s.Models;
using Microsoft.Extensions.Logging;

namespace KubernetesCRDModelGen.Benchmarks;

[MemoryDiagnoser]
public class Benchmark
{
    IGenerator generator;

    V1CustomResourceDefinition crd;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var fac = LoggerFactory.Create((x) => { });

        generator = new Generator(fac.CreateLogger<Generator>());

        crd = KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml").Result;
    }

    [Benchmark]
    public void Test1()
    {
        var ass = generator.GenerateAssembly(crd);
    }
}
