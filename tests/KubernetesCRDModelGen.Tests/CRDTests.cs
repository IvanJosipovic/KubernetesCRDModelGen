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
    public async Task TestGenerateAssemblySucceeds()
    {
        var fac = new LoggerFactory();

        var generator = new Generator(fac);
        var crd = await KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml");

        var ass = generator.GenerateAssembly(crd);
        Assert.NotNull(ass.Item1);
        Assert.NotNull(ass.Item2);
    }
}
