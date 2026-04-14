using BenchmarkDotNet.Attributes;
using k8s;
using k8s.Models;

namespace KubernetesCRDModelGen.Benchmarks;

[MemoryDiagnoser]
public class Benchmark
{
    IGenerator generator = null!;

    V1CustomResourceDefinition crd = null!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        generator = new Generator();

        crd = KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml").GetAwaiter().GetResult();
    }

    [Benchmark]
    public void Test1()
    {
        if (crd == null)
        {
            throw new Exception("CRD NULL");
        }
        var result = generator!.GenerateAssembly(crd);
        using var unloadHandle = result.UnloadHandle;

        if (!result.Success || result.Assembly == null || result.XmlDocumentation == null)
        {
            throw new Exception("Failed to generate assembly");
        }
    }
}
