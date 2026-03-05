using k8s;
using k8s.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KubernetesCRDModelGen.Tests;

public class CRDTests
{

    [Fact]
    public async Task TestNamespace()
    {
        var fac = new LoggerFactory();

        var generator = new Generator(fac);
        var crd = KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml").GetAwaiter().GetResult();


        var ass = generator.GenerateAssembly(crd);
        if (ass.Item1 == null || ass.Item2 == null)
        {
            throw new Exception("Failed to generate assembly");
        }
    }
}
