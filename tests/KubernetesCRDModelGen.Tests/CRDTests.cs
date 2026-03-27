using k8s;
using k8s.Models;
using FluentAssertions;
using Microsoft.Extensions.Logging;
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

    [Fact]
    public void TestGenerateAssemblyMaterializesPropertyDescriptionsInXmlDocumentation()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var yaml = """
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: widgets.example.com
spec:
  group: example.com
  names:
    plural: widgets
    singular: widget
    kind: Widget
    listKind: WidgetList
  scope: Namespaced
  versions:
    - name: v1
      served: true
      storage: true
      schema:
        openAPIV3Schema:
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
            spec:
              type: object
              description: Widget desired state.
              properties:
                size:
                  type: string
                  description: Size of the widget.
                enabled:
                  type: boolean
                  description: Whether the widget is enabled.
""";

        var crd = (V1CustomResourceDefinition)KubernetesYaml.LoadAllFromString(yaml)[0];
        var generator = new Generator(new LoggerFactory());

        var (_, xml) = generator.GenerateAssembly(crd, modelNamespace);

        xml.Should().NotBeNull();
        xml!.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.example.com.V1WidgetSpec.Size']/summary")
            ?.InnerText.Should().Be("Size of the widget.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.example.com.V1WidgetSpec.Enabled']/summary")
            ?.InnerText.Should().Be("Whether the widget is enabled.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.example.com.V1Widget.Spec']/summary")
            ?.InnerText.Should().Be("Widget desired state.");
    }

    [Fact]
    public async Task TestGenerateAssemblyMaterializesXmlDocumentationForManagedClustersCrd()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var generator = new Generator(new LoggerFactory());
        var crd = await KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml");

        var (_, xml) = generator.GenerateAssembly(crd, modelNamespace);

        xml.Should().NotBeNull();
        xml!.SelectSingleNode("/doc/members/member[@name='T:KubernetesCRDModelGen.Tests.Models.containerservice.azure.com.V1api20210501ManagedClusterSpecAadProfile']/summary")
            ?.InnerText.Should().Be("AadProfile: The Azure Active Directory configuration.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.containerservice.azure.com.V1api20210501ManagedClusterSpecAadProfile.AdminGroupObjectIDs']/summary")
            ?.InnerText.Should().Be("AdminGroupObjectIDs: The list of AAD group object IDs that will have admin role of the cluster.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.containerservice.azure.com.V1api20210501ManagedClusterSpec.AadProfile']/summary")
            ?.InnerText.Should().Be("AadProfile: The Azure Active Directory configuration.");
    }
}
