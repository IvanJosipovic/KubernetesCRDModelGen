using BenchmarkDotNet.Attributes;
using k8s;
using k8s.Models;
using Microsoft.Extensions.Logging;

namespace KubernetesCRDModelGen.Benchmarks;

[MemoryDiagnoser]
public class Benchmark
{
    IGenerator generator = null!;

    V1CustomResourceDefinition crd = null!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var fac = new LoggerFactory();

        generator = new Generator(fac);

        crd = KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml").GetAwaiter().GetResult();
    }

    [Benchmark]
    public void Test1()
    {
        if (crd == null)
        {
            throw new Exception("CRD NULL");
        }
        var ass = generator!.GenerateAssembly(crd);
        if (ass.Item1 == null || ass.Item2 == null)
        {
            throw new Exception("Failed to generate assembly");
        }
    }
}
