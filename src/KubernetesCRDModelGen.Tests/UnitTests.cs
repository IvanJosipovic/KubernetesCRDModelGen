using k8s.Models;
using k8s;
using FluentAssertions;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System;
using Xunit;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Collections;
using Microsoft.Extensions.Logging;
using System.Reflection.Emit;

namespace KubernetesCRDModelGen.Tests;

public class UnitTest1
{
    private const string Namespace = "KubernetesCRDModelGen.Tests.Models";

    private static IGenerator GetGenerator()
    {
        var fac = LoggerFactory.Create((x) => { });

        return new Generator(fac.CreateLogger<Generator>());
    }

    private static Type? GetTypeYaml(string yaml, string kind)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetType((V1CustomResourceDefinition)crd[0], kind);
    }

    private static Type? GetType(V1CustomResourceDefinition crd, string kind)
    {
        var assembly = GetGenerator().GenerateAssembly(crd, Namespace);

        var types = assembly.Item1.DefinedTypes.Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(KubernetesEntityAttribute) && y.NamedArguments.Any(z => z.MemberName == "Kind" && z.TypedValue.Value.Equals(kind))));

        return types.First();
    }

    private static string GetCode(string yaml)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetCode((V1CustomResourceDefinition)crd[0]);
    }

    private static string GetCode(V1CustomResourceDefinition crd)
    {
        return GetGenerator().GenerateCode(crd, Namespace);
    }

    [Fact]
    public void TestNamespace()
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
        var type = GetTypeYaml(yaml, "Test");

        type.Namespace.Should().Be(Namespace + ".kubeui.com");
    }

    [Fact]
    public void TestAssemblyName()
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
        var type = GetTypeYaml(yaml, "Test");

        type.Assembly.ManifestModule.ScopeName.Should().Be("tests.kubeui.com.dll");
    }

    [Fact]
    public void TestKubernetesEntity()
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
        var type = GetTypeYaml(yaml, "Test");

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
    public void TestBaseClasses()
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
            status:
              type: object
";
        var type = GetTypeYaml(yaml, "Test");
        type.Name.Should().Be("V1beta1Test");
        type.IsAssignableTo(typeof(IKubernetesObject)).Should().BeTrue();
        type.IsAssignableTo(typeof(IKubernetesObject<V1ObjectMeta>)).Should().BeTrue();
        type.IsAssignableTo(typeof(IMetadata<V1ObjectMeta>)).Should().BeTrue();
        type.GetInterfaces().FirstOrDefault(x => x.Name == "ISpec`1").Should().NotBeNull();
        type.GetInterfaces().FirstOrDefault(x => x.Name == "IStatus`1").Should().NotBeNull();
    }

    [Fact]
    public void TestConstants()
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
        var type = GetTypeYaml(yaml, "Test");

        type.GetField("KubeApiVersion").GetValue(null).Should().Be("v1beta1");
        type.GetField("KubeGroup").GetValue(null).Should().Be("kubeui.com");
        type.GetField("KubeKind").GetValue(null).Should().Be("Test");
        type.GetField("KubePluralName").GetValue(null).Should().Be("tests");
    }

    [Fact]
    public void TestString()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("SomeString").PropertyType.Should().Be<string?>();
    }

    [Fact]
    public void TestBool()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("SomeBool").PropertyType.Should().Be<bool?>();
    }

    [Fact]
    public void TestInt()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("IntProp").PropertyType.Should().Be<int?>();
    }

    [Fact]
    public void TestInt64()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Int64Prop").PropertyType.Should().Be<long?>();
    }

    [Fact]
    public void TestNumber()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("NumberProp").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public void TestUnknownFields()
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
        var type = GetTypeYaml(yaml, "Test");

        type.GetProperty("Spec").PropertyType.Should().Be<JsonNode>();

        type.GetProperty("Status").PropertyType.Should().Be<JsonNode>();
    }

    [Fact]
    public void TestUnknownFields2()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Values").PropertyType.Should().Be<JsonNode?>();
    }

    [Fact]
    public void TestSpecialChars()
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
                some~!@#$%^&*()-=_+.String:
                  type: string
";
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("SomeString").PropertyType.Should().Be<string>();
    }

    [Fact]
    public void TestArrayObject()
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
              type: array
              items:
                properties:
                  lastTransitionTime:
                    type: number
                  message:
                    type: string
                type: object
";
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        typeof(IList<>).IsAssignableFrom(specType.GetGenericTypeDefinition()).Should().BeTrue();

        var listType = specType.GenericTypeArguments[0];

        listType.Name.Should().Be("V1beta1TestSpec");
        listType.GetProperty("LastTransitionTime").PropertyType.Should().Be<double?>();
        listType.GetProperty("Message").PropertyType.Should().Be<string?>();
    }

    [Fact]
    public void TestArray()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<string>>();
    }

    [Fact]
    public void TestArrayPreserveUnknown()
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
                    x-kubernetes-preserve-unknown-fields: true
                  type: array
";
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<JsonNode>>();
    }

    [Fact]
    public void TestArrayNumber()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<double>>();
    }

    [Fact]
    public void TestArrayInteger()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<int>>();
    }

    [Fact]
    public void TestArrayInteger64()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("Array").PropertyType.Should().Be<IList<long>>();
    }

    [Fact]
    public void TestDict()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("CustomSelector").PropertyType.Should().Be<IDictionary<string, string>>();
    }

    [Fact]
    public void TestRequired()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("NumberProp").PropertyType.Should().Be<double>();

        specType.GetProperty("NumberProp2").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public void TestRequiredNested()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var rootType = specType.GetProperty("Root").PropertyType;

        rootType.GetProperty("NumberProp").PropertyType.Should().Be<double>();

        rootType.GetProperty("NumberProp2").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public void TestRequiredArray()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("Array").PropertyType.GenericTypeArguments[0];

        var arrayType = typeof(IList<>).MakeGenericType(itemType);

        specType.GetProperty("Array").PropertyType.Should().Be(arrayType);

        itemType.GetProperty("NumberProp").PropertyType.Should().Be<double>();

        itemType.GetProperty("NumberProp2").PropertyType.Should().Be<double?>();
    }

    [Fact]
    public void TestIntOrString()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("IntOrString").PropertyType.Should().Be<IntstrIntOrString?>();
    }

    [Fact]
    public void TestIntOrStringArray()
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
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("IntOrStringArray").PropertyType.GenericTypeArguments[0];

        itemType.Should().Be<IntstrIntOrString>();
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumDuplicate()
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
                    testEnum:
                      enum:
                      - always
                      - Always
                      - Always-
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = specType.GetProperty("TestEnum").PropertyType;

        Nullable.GetUnderlyingType(enumType).IsEnum.Should().BeTrue();

        var members = GetMembers(enumType);

        members.Should().HaveCount(3);

        members[0].Name.Should().Be("Always");
        members[0].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("always");
        members[1].Name.Should().Be("Always1");
        members[1].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("Always");
        members[2].Name.Should().Be("Always2");
        members[2].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("Always-");
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumString()
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
                    testEnum:
                      enum:
                      - always
                      - ifNotPresent
                      - never
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = specType.GetProperty("TestEnum").PropertyType;

        Nullable.GetUnderlyingType(enumType).IsEnum.Should().BeTrue();

        var members = GetMembers(enumType);

        members.Should().HaveCount(3);

        members[0].Name.Should().Be("Always");
        members[0].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("always");
        members[1].Name.Should().Be("IfNotPresent");
        members[1].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("ifNotPresent");
        members[2].Name.Should().Be("Never");
        members[2].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("never");
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumArray()
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
                    enumArray:
                      items:
                        type: string
                        enum:
                        - Always
                        - IfNotPresent
                        - test_test
                      type: array
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var itemType = specType.GetProperty("EnumArray").PropertyType;

        typeof(IList<>).IsAssignableFrom(itemType.GetGenericTypeDefinition()).Should().BeTrue();

        itemType.GenericTypeArguments[0].IsEnum.Should().BeTrue();

        var members = GetMembers(itemType.GenericTypeArguments[0]);

        members.Should().HaveCount(3);

        members[0].Name.Should().Be("Always");
        members[0].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("Always");
        members[1].Name.Should().Be("IfNotPresent");
        members[1].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("IfNotPresent");
        members[2].Name.Should().Be("TestTest");
        members[2].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("test_test");
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumStringEmptyJson()
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
                    testEnum:
                      enum:
                      - always
                      - ''
                      - never
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = specType.GetProperty("TestEnum").PropertyType;

        Nullable.GetUnderlyingType(enumType).IsEnum.Should().BeTrue();

        var members = GetMembers(enumType);

        members.Should().HaveCount(3);

        members[0].Name.Should().Be("Always");
        members[0].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("always");
        members[1].Name.Should().Be("Option1");
        members[1].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("");
        members[2].Name.Should().Be("Never");
        members[2].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("never");

        var testJson = "{\"spec\": {\"testEnum\\: \"\" } }";

        var @object = DeserializeKubeJson(testJson, type);

        var spec = @object.GetType().GetProperty("Spec").GetValue(@object);

        spec.GetType().GetProperty("TestEnum").GetValue(spec).Should().Be(Enum.Parse(enumType, "Option1"));

        var testJson2 = KubernetesJson.Serialize(@object);

        testJson2.Should().Be(testJson);
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumStringEmptyYaml()
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
                    testEnum:
                      enum:
                      - always
                      - ''
                      - never
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = specType.GetProperty("TestEnum").PropertyType;

        enumType = Nullable.GetUnderlyingType(enumType);

        enumType.IsEnum.Should().BeTrue();

        var members = GetMembers(enumType);

        members.Should().HaveCount(3);

        members[0].Name.Should().Be("Always");
        members[0].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("always");
        members[1].Name.Should().Be("Option1");
        members[1].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("");
        members[2].Name.Should().Be("Never");
        members[2].GetCustomAttribute<EnumMemberAttribute>().Value.Should().Be("never");

        var testYaml = "spec:\r\n  testEnum: ''";

        var @object = DeserializeKubeYaml(testYaml, type);

        var spec = @object.GetType().GetProperty("Spec").GetValue(@object);

        spec.GetType().GetProperty("TestEnum").GetValue(spec).Should().Be(Enum.Parse(enumType, "Option1"));

        var testYaml2 = KubernetesYaml.Serialize(@object);
        testYaml2.Should().Be(testYaml);
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumDeSerializeJson()
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
                    testEnum:
                      enum:
                      - always
                      - ifNotPresent
                      - test_test
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = Nullable.GetUnderlyingType(specType.GetProperty("TestEnum").PropertyType);

        var objJson = """
        {
          "apiVersion": "v1beta1",
          "kind": "Test",
          "metadata": {},
          "spec": {
            "testEnum": "test_test"
          }
        }
        """;

        var deserializeMethod = typeof(KubernetesJson).GetMethod("Deserialize", [typeof(string), typeof(JsonSerializerOptions)]).MakeGenericMethod(type);
        var obj = deserializeMethod.Invoke(null, [objJson, null]);

        obj.Should().NotBeNull();
        var spec = type.GetProperty("Spec")!.GetValue(obj);

        spec.GetType().GetProperty("TestEnum")!.GetValue(spec)!.Should().Be(Enum.Parse(enumType, "TestTest"));
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumArrayDeSerializeJson()
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
                    testEnum:
                      items:
                        enum:
                        - always
                        - ifNotPresent
                        - 'test_test'
                        type: string
                      type: array
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = specType.GetProperty("TestEnum").PropertyType.GenericTypeArguments[0];

        var objJson = """
{
  "apiVersion": "v1beta1",
  "kind": "Test",
  "spec": {
        "testEnum": [
            "test_test"
        ]
    }
}
""";

        var deserializeMethod = typeof(KubernetesJson).GetMethod("Deserialize", [typeof(string), typeof(JsonSerializerOptions)]).MakeGenericMethod(type);
        var obj = deserializeMethod.Invoke(null, [objJson, null]);

        obj.Should().NotBeNull();
        var spec = type.GetProperty("Spec")!.GetValue(obj);

        var prop = spec.GetType().GetProperty("TestEnum")!.GetValue(spec);

        ((IList)prop).Count.Should().Be(1);

        ((IList)prop)[0].Should().Be(Enum.Parse(enumType, "TestTest"));
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumSerializeJson()
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
                    testEnum:
                      enum:
                      - always
                      - ifNotPresent
                      - test_test
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = Nullable.GetUnderlyingType(specType.GetProperty("TestEnum").PropertyType);

        var obj = Activator.CreateInstance(type);

        type.GetProperty("ApiVersion").SetValue(obj, "v1beta1");
        type.GetProperty("Kind").SetValue(obj, "Test");

        type.GetProperty("Spec")!.SetValue(obj, Activator.CreateInstance(type.GetProperty("Spec").PropertyType));

        var spec = type.GetProperty("Spec").GetValue(obj);

        spec.GetType().GetProperty("TestEnum")!.SetValue(spec, Enum.Parse(enumType, "TestTest"));

        var objJson = KubernetesJson.Serialize(obj);

        objJson.Should().Be("""{"apiVersion":"v1beta1","kind":"Test","spec":{"testEnum":"test_test"}}""");
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumArraySerializeJson()
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
                    testEnum:
                      items:
                        enum:
                        - always
                        - ifNotPresent
                        - 'test_test'
                        type: string
                      type: array
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var obj = Activator.CreateInstance(type);

        type.GetProperty("ApiVersion").SetValue(obj, "v1beta1");
        type.GetProperty("Kind").SetValue(obj, "Test");

        type.GetProperty("Spec")!.SetValue(obj, Activator.CreateInstance(type.GetProperty("Spec").PropertyType));

        var spec = type.GetProperty("Spec").GetValue(obj);

        var propertyType = spec.GetType().GetProperty("TestEnum");

        var list = typeof(List<>).MakeGenericType(propertyType.PropertyType.GenericTypeArguments[0]);

        var listInstance = Activator.CreateInstance(list);

         ((IList)listInstance).Add(Enum.Parse(propertyType.PropertyType.GenericTypeArguments[0], "TestTest"));

        propertyType.SetValue(spec, listInstance);

        var objJson = KubernetesJson.Serialize(obj);

        objJson.Should().Be("""{"apiVersion":"v1beta1","kind":"Test","spec":{"testEnum":["test_test"]}}""");
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumDeSerializeYaml()
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
                    testEnum:
                      enum:
                      - always
                      - ifNotPresent
                      - test_test
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = Nullable.GetUnderlyingType(specType.GetProperty("TestEnum").PropertyType);

        var objYaml = """
apiVersion: "v1beta1"
kind: "Test"
metadata:
spec:
  testEnum: "test_test"
""";

        var deserializeMethod = typeof(KubernetesYaml).GetMethod("Deserialize", [typeof(string), typeof(bool)]).MakeGenericMethod(type);
        var obj = deserializeMethod.Invoke(null, [objYaml, false]);

        obj.Should().NotBeNull();
        var spec = type.GetProperty("Spec")!.GetValue(obj);

        spec.GetType().GetProperty("TestEnum")!.GetValue(spec)!.Should().Be(Enum.Parse(enumType, "TestTest"));
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumArrayDeSerializeYaml()
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
                    testEnum:
                      items:
                        enum:
                        - always
                        - ifNotPresent
                        - 'test_test'
                        type: string
                      type: array
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = specType.GetProperty("TestEnum").PropertyType.GenericTypeArguments[0];

        var objYaml = """
apiVersion: "v1beta1"
kind: "Test"
metadata:
spec:
  testEnum:
  - test_test
""";

        var deserializeMethod = typeof(KubernetesYaml).GetMethod("Deserialize", [typeof(string), typeof(bool)]).MakeGenericMethod(type);
        var obj = deserializeMethod.Invoke(null, [objYaml, false]);

        obj.Should().NotBeNull();
        var spec = type.GetProperty("Spec")!.GetValue(obj);

        var list = (IList)spec.GetType().GetProperty("TestEnum")!.GetValue(spec);

        list[0].Should().Be(Enum.Parse(enumType, "TestTest"));
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumSerializeYaml()
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
                    testEnum:
                      enum:
                      - always
                      - ifNotPresent
                      - test_test
                      type: string
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = Nullable.GetUnderlyingType(specType.GetProperty("TestEnum").PropertyType);

        var obj = Activator.CreateInstance(type);

        type.GetProperty("ApiVersion").SetValue(obj, "v1beta1");
        type.GetProperty("Kind").SetValue(obj, "Test");

        type.GetProperty("Spec")!.SetValue(obj, Activator.CreateInstance(type.GetProperty("Spec").PropertyType));

        var spec = type.GetProperty("Spec").GetValue(obj);

        spec.GetType().GetProperty("TestEnum")!.SetValue(spec, Enum.Parse(enumType, "TestTest"));

        var objYaml = KubernetesYaml.Serialize(obj);

        objYaml.Should().Be("""
apiVersion: v1beta1
kind: Test
spec:
  testEnum: test_test
""");
    }

    [Fact(Skip = "Enum Support")]
    public void TestEnumArraySerializeYaml()
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
                    testEnum:
                      items:
                        enum:
                        - always
                        - ifNotPresent
                        - 'test_test'
                        type: string
                      type: array
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var enumType = Nullable.GetUnderlyingType(specType.GetProperty("TestEnum").PropertyType);

        var obj = Activator.CreateInstance(type);

        type.GetProperty("ApiVersion").SetValue(obj, "v1beta1");
        type.GetProperty("Kind").SetValue(obj, "Test");

        type.GetProperty("Spec")!.SetValue(obj, Activator.CreateInstance(type.GetProperty("Spec").PropertyType));

        var spec = type.GetProperty("Spec").GetValue(obj);

        var propertyType = spec.GetType().GetProperty("TestEnum");

        var list = typeof(List<>).MakeGenericType(propertyType.PropertyType.GenericTypeArguments[0]);

        var listInstance = Activator.CreateInstance(list);

        ((IList)listInstance).Add(Enum.Parse(propertyType.PropertyType.GenericTypeArguments[0], "TestTest"));

        propertyType.SetValue(spec, listInstance);
        var objYaml = KubernetesYaml.Serialize(obj);

        objYaml.Should().Be("""
apiVersion: v1beta1
kind: Test
spec:
  testEnum:
  - test_test
""");
    }

    [Fact]
    public void TestObject()
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
                nested1:
                  type: object
                  properties:
                    nested11:
                      type: object
                      properties:
                        prop1:
                          type: string
";
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var nested1 = specType.GetProperty("Nested1").PropertyType;

        nested1.Name.Should().Be("V1beta1TestSpecNested1");
        nested1.IsClass.Should().BeTrue();

        var nested11 = nested1.GetProperty("Nested11").PropertyType;

        nested11.Name.Should().Be("V1beta1TestSpecNested1Nested11");
        nested11.IsClass.Should().BeTrue();
        nested11.GetProperty("Prop1").PropertyType.Should().Be<string>();
    }

    [Fact]
    public void TestObjectSameName()
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
                nested:
                  type: object
                  properties:
                    nested:
                      type: object
                      properties:
                        prop1:
                          type: string
";
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        var nested1 = specType.GetProperty("Nested").PropertyType;

        nested1.Name.Should().Be("V1beta1TestSpecNested");
        nested1.IsClass.Should().BeTrue();

        var nested11 = nested1.GetProperty("Nested").PropertyType;

        nested11.Name.Should().Be("V1beta1TestSpecNestedNested");
        nested11.IsClass.Should().BeTrue();
        nested11.GetProperty("Prop1").PropertyType.Should().Be<string>();
    }

    [Fact]
    public void TestArrayObjectSameName()
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
              type: array
              items:
                type: object
                properties:
                  spec:
                    type: array
                    items:
                      type: object
                      properties:
                        prop1:
                          type: string
";
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        typeof(IList<>).IsAssignableFrom(specType.GetGenericTypeDefinition()).Should().BeTrue();

        var listType = specType.GenericTypeArguments[0];

        listType.Name.Should().Be("V1beta1TestSpec");

        typeof(IList<>).IsAssignableFrom(specType.GetGenericTypeDefinition()).Should().BeTrue();

        var specType2 = listType.GetProperty("Spec").PropertyType;

        var listType2 = specType2.GenericTypeArguments[0];

        listType2.Name.Should().Be("V1beta1TestSpecSpec");
    }

    private static MemberInfo[] GetMembers(Type type)
    {
        if (type != null && Nullable.GetUnderlyingType(type) != null)
        {
            type = Nullable.GetUnderlyingType(type);
        }

        return type.GetMembers(BindingFlags.Public | BindingFlags.Static);
    }

    [Theory]
    //Namespace
    [InlineData("test", "test", true)]
    [InlineData("test.test", "test.test", true)]
    [InlineData("KubernetesCRDModelGen.Tests.Models.networking.internal.knative.dev", "KubernetesCRDModelGen.Tests.Models.networking.@internal.knative.dev", true)]

    //Type or Property Name
    [InlineData("test", "Test")]
    [InlineData("test test", "TestTest")]

    public void TestCleanIdentifier(string input, string expected, bool @namespace = false)
    {
        Generator.CleanIdentifier(input, @namespace).Should().Be(expected);
    }

    [Fact]
    public void TestDuplicatePropertyName()
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
                mirror_percent:
                    type: string
                mirrorPercent:
                    type: string
                mirror__Percent:
                    type: string
";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.GetProperty("MirrorPercent").PropertyType.Should().Be<string?>();
        specType.GetProperty("MirrorPercent1").PropertyType.Should().Be<string?>();
        specType.GetProperty("MirrorPercent2").PropertyType.Should().Be<string?>();
    }

    private static readonly MethodInfo _deserializeJson = typeof(KubernetesJson).GetMethod(nameof(KubernetesJson.Deserialize), BindingFlags.Static | BindingFlags.Public, [typeof(string), typeof(JsonSerializerOptions)]);

    public static object DeserializeKubeJson(string json, Type type)
    {
        var fooRef = _deserializeJson.MakeGenericMethod(type);

        return fooRef.Invoke(null, [json, null]);
    }

    private static readonly MethodInfo _deserializeYaml = typeof(KubernetesYaml).GetMethod(nameof(KubernetesYaml.Deserialize), BindingFlags.Static | BindingFlags.Public, [typeof(string), typeof(bool)]);

    public static object DeserializeKubeYaml(string yaml, Type type)
    {
        var fooRef = _deserializeYaml.MakeGenericMethod(type);

        return fooRef.Invoke(null, [yaml, false]);
    }
}
