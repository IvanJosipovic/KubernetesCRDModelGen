using FluentAssertions;
using k8s;
using k8s.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Xunit;

namespace KubernetesCRDModelGen.Tests;

public class UnitTest
{
    private static string Namespace = "KubernetesCRDModelGen.Tests.Models";

    private static ServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection();
        services.AddSingleton<ILoggerFactory, LoggerFactory>();
        services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
        services.AddSingleton<ICRDGenerator, CRDGenerator>();

        return services.BuildServiceProvider();
    }

    private static ICRDGenerator GetCRDGenerator()
    {
        return GetServiceProvider().GetRequiredService<ICRDGenerator>();
    }

    private static async Task<Type?> GetTypeYaml(string yaml, string kind)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return await GetType((V1CustomResourceDefinition)crd[0], kind);
    }

    private static async Task<Type?> GetType(V1CustomResourceDefinition crd, string kind)
    {
        var assembly = await GetCRDGenerator().GenerateAssembly(crd, Namespace);

        var types = assembly.Item1.DefinedTypes.Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(KubernetesEntityAttribute) && y.NamedArguments.Any(z => z.MemberName == "Kind" && z.TypedValue.Value.Equals(kind))));

        return types.First();
    }

    [Fact]
    public async Task TestNamespace()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
";
        var type = await GetTypeYaml(yaml, "Test");

        type.Namespace.Should().Be(Namespace);
    }

    [Fact]
    public async Task TestKubernetesEntity()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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

";
        var type = await GetTypeYaml(yaml, "Test");

        var attribute = type.CustomAttributes.First(x => x.AttributeType == typeof(KubernetesEntityAttribute));

        var kind = attribute.NamedArguments.First(x => x.MemberName == "Kind");
        kind.TypedValue.Value.Should().Be("Test");

        var group = attribute.NamedArguments.First(x => x.MemberName == "Group");
        group.TypedValue.Value.Should().Be("kubeui.com");

        var version = attribute.NamedArguments.First(x => x.MemberName == "ApiVersion");
        version.TypedValue.Value.Should().Be("v1beta1");

        var plural = attribute.NamedArguments.First(x => x.MemberName == "PluralName");
        plural.TypedValue.Value.Should().Be("tests");
    }

    [Fact]
    public async Task TestConstants()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
";
        var type = await GetTypeYaml(yaml, "Test");

        type.GetField("KubeApiVersion").GetValue(null).Should().Be("v1beta1");
        type.GetField("KubeGroup").GetValue(null).Should().Be("kubeui.com");
        type.GetField("KubeKind").GetValue(null).Should().Be("Test");
        type.GetField("KubePluralName").GetValue(null).Should().Be("tests");
    }

    [Fact]
    public async Task TestString()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                someString:
                  type: string
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("SomeString").PropertyType.Should().Be<string>();
    }

    [Fact]
    public async Task TestBool()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                someBool:
                  type: boolean
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("SomeBool").PropertyType.Should().Be<bool?>();
    }

    [Fact]
    public async Task TestInt()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                intProp:
                  type: integer
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("IntProp").PropertyType.Should().Be<int?>();
    }

    [Fact]
    public async Task TestInt64()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                int64Prop:
                  type: integer
                  format: int64
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Int64Prop").PropertyType.Should().Be<long?>();
    }

    [Fact]
    public async Task TestNumber()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                numberProp:
                  type: number
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("NumberProp").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public async Task TestUnkownFields()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              x-kubernetes-preserve-unknown-fields: true
            status:
              x-kubernetes-preserve-unknown-fields: true
";
        var type = await GetTypeYaml(yaml, "Test");

        type.GetProperty("Spec").PropertyType.Should().Be<JsonNode>();

        type.GetProperty("Status").PropertyType.Should().Be<JsonNode>();
    }

    [Fact]
    public async Task TestUnkownFields2()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                values:
                  x-kubernetes-preserve-unknown-fields: true
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Values").PropertyType.Should().Be<JsonNode?>();
    }

    [Fact]
    public async Task TestAssemblyName()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
";
        var type = await GetTypeYaml(yaml, "Test");

        type.Assembly.ManifestModule.ScopeName.Should().Be("tests-kubeui-com.dll");
    }

    [Fact]
    public async Task TestSpecialChars()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                some~!@#$%^&*()-=_+String:
                  type: string
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("SomeString").PropertyType.Should().Be<string>();
    }

    [Fact]
    public async Task TestArrayOject()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                conditions:
                  items:
                    properties:
                      lastTransitionTime:
                        type: number
                      message:
                        type: string
                    type: object
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var prop = specType.GetProperty("Conditions").PropertyType;

        typeof(IList<>).IsAssignableFrom(prop.GetGenericTypeDefinition()).Should().BeTrue();

        var listType = prop.GenericTypeArguments[0];

        listType.Name.Should().Be("TestSpecConditions");
        listType.GetProperty("LastTransitionTime").PropertyType.Should().Be<double?>();
        listType.GetProperty("Message").PropertyType.Should().Be<string?>();
    }

    [Fact]
    public async Task TestArray()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                array:
                  items:
                    type: string
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<string>>();
    }

    [Fact]
    public async Task TestArrayPresreveUnkown()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                array:
                  items:
                    x-kubernetes-preserve-unknown-fields: ""True""
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<JsonNode>>();
    }

    [Fact]
    public async Task TestArrayNumber()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                array:
                  items:
                    type: number
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<double>>();
    }

    [Fact]
    public async Task TestArrayInteger()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                array:
                  items:
                    type: integer
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<int>>();
    }

    [Fact]
    public async Task TestArrayInteger64()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                array:
                  items:
                    type: integer
                    format: int64
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<long>>();
    }

    [Fact]
    public async Task TestDict()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                customSelector:
                  additionalProperties:
                    type: string
                  type: object
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("CustomSelector").PropertyType.Should().Be<IDictionary<string, object>>();
    }

    [Fact]
    public async Task TestRequired()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                numberProp:
                  type: number
                numberProp2:
                  type: number
              required:
              - numberProp
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("NumberProp").PropertyType.Should().Be<double>();

        specType.GetProperty("NumberProp2").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public async Task TestRequiredNested()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                root:
                  type: object
                  properties:
                    numberProp:
                      type: number
                    numberProp2:
                      type: number
                  required:
                  - numberProp
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var rootType = specType.GetProperty("Root").PropertyType;

        rootType.GetProperty("NumberProp").PropertyType.Should().Be<double>();

        rootType.GetProperty("NumberProp2").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public async Task TestRequiredArray()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                array:
                  items:
                    type: object
                    properties:
                      numberProp:
                        type: number
                      numberProp2:
                        type: number
                    required:
                    - numberProp
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("Array").PropertyType.GenericTypeArguments[0];

        itemType.GetProperty("NumberProp").PropertyType.Should().Be<double>();

        itemType.GetProperty("NumberProp2").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public async Task TestIntOrString()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                intOrString:
                  anyOf:
                  - type: integer
                  - type: string
                  x-kubernetes-int-or-string: true
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("IntOrString").PropertyType.Should().Be<IntstrIntOrString?>();
    }

    [Fact]
    public async Task TestIntOrStringArray()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1beta1
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
              properties:
                intOrStringArray:
                  items:
                    anyOf:
                    - type: integer
                    - type: string
                    x-kubernetes-int-or-string: true
                  type: array
";
        var type = await GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("IntOrStringArray").PropertyType.GenericTypeArguments[0];

        itemType.Should().Be<IntstrIntOrString>();
    }
}
