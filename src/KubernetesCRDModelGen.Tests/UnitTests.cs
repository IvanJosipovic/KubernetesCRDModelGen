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
using System.Runtime.CompilerServices;

namespace KubernetesCRDModelGen.Tests;

public class UnitTest1
{
    private const string Namespace = "KubernetesCRDModelGen.Tests.Models";

    private static IGenerator GetGenerator()
    {
        var fac = LoggerFactory.Create((x) => { });

        return new Generator(fac);
    }

    private static Type? GetTypeYaml(string yaml, string kind)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetType((V1CustomResourceDefinition)crd[0], kind);
    }

    private static Type[]? GetTypeYaml(string yaml, string kind, string kindList)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetType((V1CustomResourceDefinition)crd[0], kind, kindList);
    }

    private static Type? GetType(V1CustomResourceDefinition crd, string kind)
    {
        var assembly = GetGenerator().GenerateAssembly(crd, Namespace);

        var types = assembly.Item1.DefinedTypes.Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(KubernetesEntityAttribute) && y.NamedArguments.Any(z => z.MemberName == "Kind" && z.TypedValue.Value.Equals(kind))));

        return types.First();
    }

    private static Type[]? GetType(V1CustomResourceDefinition crd, string kind, string kindList)
    {
        var assembly = GetGenerator().GenerateAssembly(crd, Namespace);

        return [.. assembly.Item1.DefinedTypes.Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(KubernetesEntityAttribute) && y.NamedArguments.Any(z => z.MemberName == "Kind" && new[]{kind, kindList}.Contains(z.TypedValue.Value))))];
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
        var code = GetCode(yaml);
        var types = GetTypeYaml(yaml, "Test", "TestList");
        types.Should().AllSatisfy(
          t => t.Namespace.Should().Be(Namespace + ".kubeui.com")
        );
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
        var types = GetTypeYaml(yaml, "Test", "TestList");
        types.Should().AllSatisfy(
          t => t.Assembly.ManifestModule.ScopeName.Should().Be("tests.kubeui.com.dll")
        );
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
        var types = GetTypeYaml(yaml, "Test", "TestList");

        ShouldHaveCorrectAttributeArguments(types[1], "Test");
        ShouldHaveCorrectAttributeArguments(types[0], "TestList");

        static void ShouldHaveCorrectAttributeArguments(Type type, string namedKind)
        {
          var attribute = type.CustomAttributes.First(x => x.AttributeType == typeof(KubernetesEntityAttribute));

          var kind = attribute.NamedArguments.First(x => x.MemberName == "Kind");
          kind.TypedValue.Value.Should().Be(namedKind);

          var group = attribute.NamedArguments.First(x => x.MemberName == "Group");
          group.TypedValue.Value.Should().Be("kubeui.com");

          var version = attribute.NamedArguments.First(x => x.MemberName == "ApiVersion");
          version.TypedValue.Value.Should().Be("v1beta1");

          var plural = attribute.NamedArguments.First(x => x.MemberName == "PluralName");
          plural.TypedValue.Value.Should().Be("tests");
        }
    }

    [Fact]
    public void TestKubernetesEntityNullListKind()
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
        var types = GetTypeYaml(yaml, "Test", "TestList");

        ShouldHaveCorrectAttributeArguments(types[1], "Test");
        ShouldHaveCorrectAttributeArguments(types[0], "TestList");

        static void ShouldHaveCorrectAttributeArguments(Type type, string namedKind)
        {
            var attribute = type.CustomAttributes.First(x => x.AttributeType == typeof(KubernetesEntityAttribute));

            var kind = attribute.NamedArguments.First(x => x.MemberName == "Kind");
            kind.TypedValue.Value.Should().Be(namedKind);

            var group = attribute.NamedArguments.First(x => x.MemberName == "Group");
            group.TypedValue.Value.Should().Be("kubeui.com");

            var version = attribute.NamedArguments.First(x => x.MemberName == "ApiVersion");
            version.TypedValue.Value.Should().Be("v1beta1");

            var plural = attribute.NamedArguments.First(x => x.MemberName == "PluralName");
            plural.TypedValue.Value.Should().Be("tests");
        }
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

        var typeList = GetTypeYaml(yaml, "TestList");
        typeList.Name.Should().Be("V1beta1TestList");
        typeList.IsAssignableTo(typeof(IKubernetesObject)).Should().BeTrue();
        typeList.IsAssignableTo(typeof(IKubernetesObject<V1ListMeta>)).Should().BeTrue();
        typeList.IsAssignableTo(typeof(IMetadata<V1ListMeta>)).Should().BeTrue();
        typeList.GetInterfaces().FirstOrDefault(x => x.Name == "IItems`1").Should().NotBeNull();
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
        var types = GetTypeYaml(yaml, "Test", "TestList");

        ShouldHaveCorrectFieldValues(types[1], "Test");
        ShouldHaveCorrectFieldValues(types[0], "TestList");

        static void ShouldHaveCorrectFieldValues(Type type, string namedKind)
        {
          type.GetField("KubeApiVersion").GetValue(null).Should().Be("v1beta1");
          type.GetField("KubeGroup").GetValue(null).Should().Be("kubeui.com");
          type.GetField("KubeKind").GetValue(null).Should().Be(namedKind);
          type.GetField("KubePluralName").GetValue(null).Should().Be("tests");

            var instance = Activator.CreateInstance(type);

            type.GetProperty("ApiVersion").GetValue(instance).Should().Be("kubeui.com/v1beta1");
            type.GetProperty("Kind").GetValue(instance).Should().Be(namedKind);
        }
    }

    [Fact]
    public void TestMultiVersion()
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
    - name: v1beta2
      served: true
      storage: false
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
        var type = GetTypeYaml(yaml, "Test", "TestList");

        type.Length.Should().Be(4);
        type[0].Name.Should().Be("V1beta1TestList");
        type[1].Name.Should().Be("V1beta1Test");
        type[2].Name.Should().Be("V1beta2TestList");
        type[3].Name.Should().Be("V1beta2Test");
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


        var prop = specType.GetProperty("NumberProp");
        prop.PropertyType.Should().Be(typeof(double));
        prop.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeTrue();

        var prop2 = specType.GetProperty("NumberProp2");
        prop2.PropertyType.Should().Be<Nullable<double>>();
        prop2.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();
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

    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
    public void TestEnumStringEmpty()
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

        enumType.Should().Be<string>();
    }

    /// <summary>
    /// Enums with blank values are not supported by JsonStringEnumConverter
    /// https://github.com/dotnet/runtime/issues/107367
    /// </summary>
    [Fact(Skip = "Enums with empty values are not supported")]
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

    /// <summary>
    /// Enums with blank values are not supported by JsonStringEnumConverter
    /// https://github.com/dotnet/runtime/issues/107367
    /// </summary>
    [Fact(Skip = "Enums with empty values are not supported")]
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

    [Fact]
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

    [Fact]
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
  "metadata": {
       "name": "test"
  },
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

    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
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
        CodeGenerator.CleanIdentifier(input, @namespace).Should().Be(expected);
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

    [Fact]
    public void TestKubeVirt()
    {
        var yaml = @"
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  labels:
    operator.kubevirt.io: ''
  name: kubevirts.kubevirt.io
spec:
  group: kubevirt.io
  names:
    categories:
    - all
    kind: KubeVirt
    plural: kubevirts
    shortNames:
    - kv
    - kvs
    singular: kubevirt
  scope: Namespaced
  versions:
  - additionalPrinterColumns:
    - jsonPath: .metadata.creationTimestamp
      name: Age
      type: date
    - jsonPath: .status.phase
      name: Phase
      type: string
    name: v1
    schema:
      openAPIV3Schema:
        description: KubeVirt represents the object deploying all KubeVirt resources
        properties:
          apiVersion:
            description: >-
              APIVersion defines the versioned schema of this representation of an object.

              Servers should convert recognized schemas to the latest internal value, and

              may reject unrecognized values.

              More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
            type: string
          kind:
            description: >-
              Kind is a string value representing the REST resource this object represents.

              Servers may infer this from the endpoint the client submits requests to.

              Cannot be updated.

              In CamelCase.

              More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            type: string
          metadata:
            type: object
          spec:
            properties:
              certificateRotateStrategy:
                properties:
                  selfSigned:
                    properties:
                      ca:
                        description: >-
                          CA configuration

                          CA certs are kept in the CA bundle as long as they are valid
                        properties:
                          duration:
                            description: The requested 'duration' (i.e. lifetime) of the Certificate.
                            type: string
                          renewBefore:
                            description: >-
                              The amount of time before the currently issued certificate's ""notAfter""

                              time that we will begin to attempt to renew the certificate.
                            type: string
                        type: object
                      caOverlapInterval:
                        description: Deprecated. Use CA.Duration and CA.RenewBefore instead
                        type: string
                      caRotateInterval:
                        description: Deprecated. Use CA.Duration instead
                        type: string
                      certRotateInterval:
                        description: Deprecated. Use Server.Duration instead
                        type: string
                      server:
                        description: >-
                          Server configuration

                          Certs are rotated and discarded
                        properties:
                          duration:
                            description: The requested 'duration' (i.e. lifetime) of the Certificate.
                            type: string
                          renewBefore:
                            description: >-
                              The amount of time before the currently issued certificate's ""notAfter""

                              time that we will begin to attempt to renew the certificate.
                            type: string
                        type: object
                    type: object
                type: object
              configuration:
                description: >-
                  holds kubevirt configurations.

                  same as the virt-configMap
                properties:
                  additionalGuestMemoryOverheadRatio:
                    description: >-
                      AdditionalGuestMemoryOverheadRatio can be used to increase the virtualization infrastructure

                      overhead. This is useful, since the calculation of this overhead is not accurate and cannot

                      be entirely known in advance. The ratio that is being set determines by which factor to increase

                      the overhead calculated by Kubevirt. A higher ratio means that the VMs would be less compromised

                      by node pressures, but would mean that fewer VMs could be scheduled to a node.

                      If not set, the default is 1.
                    type: string
                  apiConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                  architectureConfiguration:
                    properties:
                      amd64:
                        properties:
                          emulatedMachines:
                            items:
                              type: string
                            type: array
                            x-kubernetes-list-type: atomic
                          machineType:
                            type: string
                          ovmfPath:
                            type: string
                        type: object
                      arm64:
                        properties:
                          emulatedMachines:
                            items:
                              type: string
                            type: array
                            x-kubernetes-list-type: atomic
                          machineType:
                            type: string
                          ovmfPath:
                            type: string
                        type: object
                      defaultArchitecture:
                        type: string
                      ppc64le:
                        properties:
                          emulatedMachines:
                            items:
                              type: string
                            type: array
                            x-kubernetes-list-type: atomic
                          machineType:
                            type: string
                          ovmfPath:
                            type: string
                        type: object
                    type: object
                  autoCPULimitNamespaceLabelSelector:
                    description: >-
                      When set, AutoCPULimitNamespaceLabelSelector will set a CPU limit on virt-launcher for VMIs running inside

                      namespaces that match the label selector.

                      The CPU limit will equal the number of requested vCPUs.

                      This setting does not apply to VMIs with dedicated CPUs.
                    properties:
                      matchExpressions:
                        description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                        items:
                          description: >-
                            A label selector requirement is a selector that contains values, a key, and an operator that

                            relates the key and values.
                          properties:
                            key:
                              description: key is the label key that the selector applies to.
                              type: string
                            operator:
                              description: >-
                                operator represents a key's relationship to a set of values.

                                Valid operators are In, NotIn, Exists and DoesNotExist.
                              type: string
                            values:
                              description: >-
                                values is an array of string values. If the operator is In or NotIn,

                                the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                the values array must be empty. This array is replaced during a strategic

                                merge patch.
                              items:
                                type: string
                              type: array
                              x-kubernetes-list-type: atomic
                          required:
                          - key
                          - operator
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                      matchLabels:
                        additionalProperties:
                          type: string
                        description: >-
                          matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                          map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                          operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                        type: object
                    type: object
                    x-kubernetes-map-type: atomic
                  commonInstancetypesDeployment:
                    description: CommonInstancetypesDeployment controls the deployment of common-instancetypes resources
                    nullable: true
                    properties:
                      enabled:
                        description: Enabled controls the deployment of common-instancetypes resources, defaults to True.
                        nullable: true
                        type: boolean
                    type: object
                  controllerConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                  cpuModel:
                    type: string
                  cpuRequest:
                    anyOf:
                    - type: integer
                    - type: string
                    pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                    x-kubernetes-int-or-string: true
                  defaultRuntimeClass:
                    type: string
                  developerConfiguration:
                    description: DeveloperConfiguration holds developer options
                    properties:
                      clusterProfiler:
                        description: Enable the ability to pprof profile KubeVirt control plane
                        type: boolean
                      cpuAllocationRatio:
                        description: >-
                          For each requested virtual CPU, CPUAllocationRatio defines how much physical CPU to request per VMI

                          from the hosting node. The value is in fraction of a CPU thread (or core on non-hyperthreaded nodes).

                          For example, a value of 1 means 1 physical CPU thread per VMI CPU thread.

                          A value of 100 would be 1% of a physical thread allocated for each requested VMI thread.

                          This option has no effect on VMIs that request dedicated CPUs. More information at:

                          https://kubevirt.io/user-guide/operations/node_overcommit/#node-cpu-allocation-ratio

                          Defaults to 10
                        type: integer
                      diskVerification:
                        description: DiskVerification holds container disks verification limits
                        properties:
                          memoryLimit:
                            anyOf:
                            - type: integer
                            - type: string
                            pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                            x-kubernetes-int-or-string: true
                        required:
                        - memoryLimit
                        type: object
                      featureGates:
                        description: FeatureGates is the list of experimental features to enable. Defaults to none
                        items:
                          type: string
                        type: array
                      logVerbosity:
                        description: LogVerbosity sets log verbosity level of  various components
                        properties:
                          nodeVerbosity:
                            additionalProperties:
                              type: integer
                            description: NodeVerbosity represents a map of nodes with a specific verbosity level
                            type: object
                          virtAPI:
                            type: integer
                          virtController:
                            type: integer
                          virtHandler:
                            type: integer
                          virtLauncher:
                            type: integer
                          virtOperator:
                            type: integer
                          virtSynchronizationController:
                            type: integer
                        type: object
                      memoryOvercommit:
                        description: >-
                          MemoryOvercommit is the percentage of memory we want to give VMIs compared to the amount

                          given to its parent pod (virt-launcher). For example, a value of 102 means the VMI will

                          ""see"" 2% more memory than its parent pod. Values under 100 are effectively ""undercommits"".

                          Overcommits can lead to memory exhaustion, which in turn can lead to crashes. Use carefully.

                          Defaults to 100
                        type: integer
                      minimumClusterTSCFrequency:
                        description: >-
                          Allow overriding the automatically determined minimum TSC frequency of the cluster

                          and fixate the minimum to this frequency.
                        format: int64
                        type: integer
                      minimumReservePVCBytes:
                        description: >-
                          MinimumReservePVCBytes is the amount of space, in bytes, to leave unused on disks.

                          Defaults to 131072 (128KiB)
                        format: int64
                        type: integer
                      nodeSelectors:
                        additionalProperties:
                          type: string
                        description: >-
                          NodeSelectors allows restricting VMI creation to nodes that match a set of labels.

                          Defaults to none
                        type: object
                      pvcTolerateLessSpaceUpToPercent:
                        description: >-
                          LessPVCSpaceToleration determines how much smaller, in percentage, disk PVCs are

                          allowed to be compared to the requested size (to account for various overheads).

                          Defaults to 10
                        type: integer
                      useEmulation:
                        description: >-
                          UseEmulation can be set to true to allow fallback to software emulation

                          in case hardware-assisted emulation is not available. Defaults to false
                        type: boolean
                    type: object
                  emulatedMachines:
                    description: Deprecated. Use architectureConfiguration instead.
                    items:
                      type: string
                    type: array
                  evictionStrategy:
                    description: >-
                      EvictionStrategy defines at the cluster level if the VirtualMachineInstance should be

                      migrated instead of shut-off in case of a node drain. If the VirtualMachineInstance specific

                      field is set it overrides the cluster level one.
                    type: string
                  handlerConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                  imagePullPolicy:
                    description: PullPolicy describes a policy for if/when to pull a container image
                    type: string
                  instancetype:
                    description: Instancetype configuration
                    nullable: true
                    properties:
                      referencePolicy:
                        description: >-
                          ReferencePolicy defines how an instance type or preference should be referenced by the VM after submission, supported values are:

                          reference (default) - Where a copy of the original object is stashed in a ControllerRevision and referenced by the VM.

                          expand - Where the instance type or preference are expanded into the VM if no revisionNames have been populated.

                          expandAll - Where the instance type or preference are expanded into the VM regardless of revisionNames previously being populated.
                        enum:
                        - reference
                        - expand
                        - expandAll
                        nullable: true
                        type: string
                    type: object
                  ksmConfiguration:
                    description: KSMConfiguration holds the information regarding the enabling the KSM in the nodes (if available).
                    properties:
                      nodeLabelSelector:
                        description: >-
                          NodeLabelSelector is a selector that filters in which nodes the KSM will be enabled.

                          Empty NodeLabelSelector will enable ksm for every node.
                        properties:
                          matchExpressions:
                            description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                            items:
                              description: >-
                                A label selector requirement is a selector that contains values, a key, and an operator that

                                relates the key and values.
                              properties:
                                key:
                                  description: key is the label key that the selector applies to.
                                  type: string
                                operator:
                                  description: >-
                                    operator represents a key's relationship to a set of values.

                                    Valid operators are In, NotIn, Exists and DoesNotExist.
                                  type: string
                                values:
                                  description: >-
                                    values is an array of string values. If the operator is In or NotIn,

                                    the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                    the values array must be empty. This array is replaced during a strategic

                                    merge patch.
                                  items:
                                    type: string
                                  type: array
                                  x-kubernetes-list-type: atomic
                              required:
                              - key
                              - operator
                              type: object
                            type: array
                            x-kubernetes-list-type: atomic
                          matchLabels:
                            additionalProperties:
                              type: string
                            description: >-
                              matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                              map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                              operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                            type: object
                        type: object
                        x-kubernetes-map-type: atomic
                    type: object
                  liveUpdateConfiguration:
                    description: LiveUpdateConfiguration holds defaults for live update features
                    properties:
                      maxCpuSockets:
                        description: >-
                          MaxCpuSockets provides a MaxSockets value for VMs that do not provide their own.

                          For VMs with more sockets than maximum the MaxSockets will be set to equal number of sockets.
                        format: int32
                        type: integer
                      maxGuest:
                        anyOf:
                        - type: integer
                        - type: string
                        description: >-
                          MaxGuest defines the maximum amount memory that can be allocated

                          to the guest using hotplug.
                        pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                        x-kubernetes-int-or-string: true
                      maxHotplugRatio:
                        description: >-
                          MaxHotplugRatio is the ratio used to define the max amount

                          of a hotplug resource that can be made available to a VM

                          when the specific Max* setting is not defined (MaxCpuSockets, MaxGuest)

                          Example: VM is configured with 512Mi of guest memory, if MaxGuest is not

                          defined and MaxHotplugRatio is 2 then MaxGuest = 1Gi

                          defaults to 4
                        format: int32
                        type: integer
                    type: object
                  machineType:
                    description: Deprecated. Use architectureConfiguration instead.
                    type: string
                  mediatedDevicesConfiguration:
                    description: MediatedDevicesConfiguration holds information about MDEV types to be defined, if available
                    properties:
                      mediatedDeviceTypes:
                        items:
                          type: string
                        type: array
                        x-kubernetes-list-type: atomic
                      mediatedDevicesTypes:
                        description: Deprecated. Use mediatedDeviceTypes instead.
                        items:
                          type: string
                        type: array
                        x-kubernetes-list-type: atomic
                      nodeMediatedDeviceTypes:
                        items:
                          description: NodeMediatedDeviceTypesConfig holds information about MDEV types to be defined in a specific node that matches the NodeSelector field.
                          properties:
                            mediatedDeviceTypes:
                              items:
                                type: string
                              type: array
                              x-kubernetes-list-type: atomic
                            mediatedDevicesTypes:
                              description: Deprecated. Use mediatedDeviceTypes instead.
                              items:
                                type: string
                              type: array
                              x-kubernetes-list-type: atomic
                            nodeSelector:
                              additionalProperties:
                                type: string
                              description: >-
                                NodeSelector is a selector which must be true for the vmi to fit on a node.

                                Selector which must match a node's labels for the vmi to be scheduled on that node.

                                More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
                              type: object
                          required:
                          - nodeSelector
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                    type: object
                  memBalloonStatsPeriod:
                    format: int32
                    type: integer
                  migrations:
                    description: >-
                      MigrationConfiguration holds migration options.

                      Can be overridden for specific groups of VMs though migration policies.

                      Visit https://kubevirt.io/user-guide/operations/migration_policies/ for more information.
                    properties:
                      allowAutoConverge:
                        description: >-
                          AllowAutoConverge allows the platform to compromise performance/availability of VMIs to

                          guarantee successful VMI live migrations. Defaults to false
                        type: boolean
                      allowPostCopy:
                        description: >-
                          AllowPostCopy enables post-copy live migrations. Such migrations allow even the busiest VMIs

                          to successfully live-migrate. However, events like a network failure can cause a VMI crash.

                          If set to true, migrations will still start in pre-copy, but switch to post-copy when

                          CompletionTimeoutPerGiB triggers. Defaults to false
                        type: boolean
                      allowWorkloadDisruption:
                        description: >-
                          AllowWorkloadDisruption indicates that the migration shouldn't be

                          canceled after acceptableCompletionTime is exceeded. Instead, if

                          permitted, migration will be switched to post-copy or the VMI will be

                          paused to allow the migration to complete
                        type: boolean
                      bandwidthPerMigration:
                        anyOf:
                        - type: integer
                        - type: string
                        description: >-
                          BandwidthPerMigration limits the amount of network bandwidth live migrations are allowed to use.

                          The value is in quantity per second. Defaults to 0 (no limit)
                        pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                        x-kubernetes-int-or-string: true
                      completionTimeoutPerGiB:
                        description: >-
                          CompletionTimeoutPerGiB is the maximum number of seconds per GiB a migration is allowed to take.

                          If the timeout is reached, the migration will be either paused, switched

                          to post-copy or cancelled depending on other settings. Defaults to 150
                        format: int64
                        type: integer
                      disableTLS:
                        description: >-
                          When set to true, DisableTLS will disable the additional layer of live migration encryption

                          provided by KubeVirt. This is usually a bad idea. Defaults to false
                        type: boolean
                      matchSELinuxLevelOnMigration:
                        description: >-
                          By default, the SELinux level of target virt-launcher pods is forced to the level of the source virt-launcher.

                          When set to true, MatchSELinuxLevelOnMigration lets the CRI auto-assign a random level to the target.

                          That will ensure the target virt-launcher doesn't share categories with another pod on the node.

                          However, migrations will fail when using RWX volumes that don't automatically deal with SELinux levels.
                        type: boolean
                      network:
                        description: >-
                          Network is the name of the CNI network to use for live migrations. By default, migrations go

                          through the pod network.
                        type: string
                      nodeDrainTaintKey:
                        description: >-
                          NodeDrainTaintKey defines the taint key that indicates a node should be drained.

                          Note: this option relies on the deprecated node taint feature. Default: kubevirt.io/drain
                        type: string
                      parallelMigrationsPerCluster:
                        description: >-
                          ParallelMigrationsPerCluster is the total number of concurrent live migrations

                          allowed cluster-wide. Defaults to 5
                        format: int32
                        type: integer
                      parallelOutboundMigrationsPerNode:
                        description: >-
                          ParallelOutboundMigrationsPerNode is the maximum number of concurrent outgoing live migrations

                          allowed per node. Defaults to 2
                        format: int32
                        type: integer
                      progressTimeout:
                        description: >-
                          ProgressTimeout is the maximum number of seconds a live migration is allowed to make no progress.

                          Hitting this timeout means a migration transferred 0 data for that many seconds. The migration is

                          then considered stuck and therefore cancelled. Defaults to 150
                        format: int64
                        type: integer
                      unsafeMigrationOverride:
                        description: >-
                          UnsafeMigrationOverride allows live migrations to occur even if the compatibility check

                          indicates the migration will be unsafe to the guest. Defaults to false
                        type: boolean
                    type: object
                  minCPUModel:
                    type: string
                  network:
                    description: NetworkConfiguration holds network options
                    properties:
                      binding:
                        additionalProperties:
                          properties:
                            computeResourceOverhead:
                              description: >-
                                ComputeResourceOverhead specifies the resource overhead that should be added to the compute container when using the binding.

                                version: v1alphav1
                              properties:
                                limits:
                                  additionalProperties:
                                    anyOf:
                                    - type: integer
                                    - type: string
                                    pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                    x-kubernetes-int-or-string: true
                                  description: >-
                                    Limits describes the maximum amount of compute resources allowed.

                                    More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                                  type: object
                                requests:
                                  additionalProperties:
                                    anyOf:
                                    - type: integer
                                    - type: string
                                    pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                    x-kubernetes-int-or-string: true
                                  description: >-
                                    Requests describes the minimum amount of compute resources required.

                                    If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,

                                    otherwise to an implementation-defined value. Requests cannot exceed Limits.

                                    More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                                  type: object
                              type: object
                            domainAttachmentType:
                              description: >-
                                DomainAttachmentType is a standard domain network attachment method kubevirt supports.

                                Supported values: ""tap"", ""managedTap"" (since v1.4).

                                The standard domain attachment can be used instead or in addition to the sidecarImage.

                                version: 1alphav1
                              type: string
                            downwardAPI:
                              description: >-
                                DownwardAPI specifies what kind of data should be exposed to the binding plugin sidecar.

                                Supported values: ""device-info""

                                version: v1alphav1
                              type: string
                            migration:
                              description: >-
                                Migration means the VM using the plugin can be safely migrated

                                version: 1alphav1
                              properties:
                                method:
                                  description: >-
                                    Method defines a pre-defined migration methodology

                                    version: 1alphav1
                                  type: string
                              type: object
                            networkAttachmentDefinition:
                              description: >-
                                NetworkAttachmentDefinition references to a NetworkAttachmentDefinition CR object.

                                Format: <name>, <namespace>/<name>.

                                If namespace is not specified, VMI namespace is assumed.

                                version: 1alphav1
                              type: string
                            sidecarImage:
                              description: >-
                                SidecarImage references a container image that runs in the virt-launcher pod.

                                The sidecar handles (libvirt) domain configuration and optional services.

                                version: 1alphav1
                              type: string
                          type: object
                        type: object
                      defaultNetworkInterface:
                        type: string
                      permitBridgeInterfaceOnPodNetwork:
                        type: boolean
                      permitSlirpInterface:
                        description: >-
                          DeprecatedPermitSlirpInterface is an alias for the deprecated PermitSlirpInterface.

                          Deprecated: Removed in v1.3.
                        type: boolean
                    type: object
                  obsoleteCPUModels:
                    additionalProperties:
                      type: boolean
                    type: object
                  ovmfPath:
                    description: Deprecated. Use architectureConfiguration instead.
                    type: string
                  permittedHostDevices:
                    description: PermittedHostDevices holds information about devices allowed for passthrough
                    properties:
                      mediatedDevices:
                        items:
                          description: MediatedHostDevice represents a host mediated device allowed for passthrough
                          properties:
                            externalResourceProvider:
                              type: boolean
                            mdevNameSelector:
                              type: string
                            resourceName:
                              type: string
                          required:
                          - mdevNameSelector
                          - resourceName
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                      pciHostDevices:
                        items:
                          description: PciHostDevice represents a host PCI device allowed for passthrough
                          properties:
                            externalResourceProvider:
                              description: >-
                                If true, KubeVirt will leave the allocation and monitoring to an

                                external device plugin
                              type: boolean
                            pciVendorSelector:
                              description: The vendor_id:product_id tuple of the PCI device
                              type: string
                            resourceName:
                              description: >-
                                The name of the resource that is representing the device. Exposed by

                                a device plugin and requested by VMs. Typically of the form

                                vendor.com/product_name
                              type: string
                          required:
                          - pciVendorSelector
                          - resourceName
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                      usb:
                        items:
                          properties:
                            externalResourceProvider:
                              description: >-
                                If true, KubeVirt will leave the allocation and monitoring to an

                                external device plugin
                              type: boolean
                            resourceName:
                              description: >-
                                Identifies the list of USB host devices.

                                e.g: kubevirt.io/storage, kubevirt.io/bootable-usb, etc
                              type: string
                            selectors:
                              items:
                                properties:
                                  product:
                                    type: string
                                  vendor:
                                    type: string
                                required:
                                - product
                                - vendor
                                type: object
                              type: array
                              x-kubernetes-list-type: atomic
                          required:
                          - resourceName
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                    type: object
                  seccompConfiguration:
                    description: SeccompConfiguration holds Seccomp configuration for Kubevirt components
                    properties:
                      virtualMachineInstanceProfile:
                        description: VirtualMachineInstanceProfile defines what profile should be used with virt-launcher. Defaults to none
                        properties:
                          customProfile:
                            description: CustomProfile allows to request arbitrary profile for virt-launcher
                            properties:
                              localhostProfile:
                                type: string
                              runtimeDefaultProfile:
                                type: boolean
                            type: object
                        type: object
                    type: object
                  selinuxLauncherType:
                    type: string
                  smbios:
                    properties:
                      family:
                        type: string
                      manufacturer:
                        type: string
                      product:
                        type: string
                      sku:
                        type: string
                      version:
                        type: string
                    type: object
                  supportContainerResources:
                    description: SupportContainerResources specifies the resource requirements for various types of supporting containers such as container disks/virtiofs/sidecars and hotplug attachment pods. If omitted a sensible default will be supplied.
                    items:
                      description: SupportContainerResources are used to specify the cpu/memory request and limits for the containers that support various features of Virtual Machines. These containers are usually idle and don't require a lot of memory or cpu.
                      properties:
                        resources:
                          description: >-
                            ResourceRequirementsWithoutClaims describes the compute resource requirements.

                            This struct was taken from the k8s.ResourceRequirements and cleaned up the 'Claims' field.
                          properties:
                            limits:
                              additionalProperties:
                                anyOf:
                                - type: integer
                                - type: string
                                pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                x-kubernetes-int-or-string: true
                              description: >-
                                Limits describes the maximum amount of compute resources allowed.

                                More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                              type: object
                            requests:
                              additionalProperties:
                                anyOf:
                                - type: integer
                                - type: string
                                pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                x-kubernetes-int-or-string: true
                              description: >-
                                Requests describes the minimum amount of compute resources required.

                                If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,

                                otherwise to an implementation-defined value. Requests cannot exceed Limits.

                                More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                              type: object
                          type: object
                        type:
                          type: string
                      required:
                      - resources
                      - type
                      type: object
                    type: array
                    x-kubernetes-list-map-keys:
                    - type
                    x-kubernetes-list-type: map
                  supportedGuestAgentVersions:
                    description: deprecated
                    items:
                      type: string
                    type: array
                  tlsConfiguration:
                    description: TLSConfiguration holds TLS options
                    properties:
                      ciphers:
                        items:
                          type: string
                        type: array
                        x-kubernetes-list-type: set
                      minTLSVersion:
                        description: >-
                          MinTLSVersion is a way to specify the minimum protocol version that is acceptable for TLS connections.

                          Protocol versions are based on the following most common TLS configurations:

                            https://ssl-config.mozilla.org/

                          Note that SSLv3.0 is not a supported protocol version due to well known

                          vulnerabilities such as POODLE: https://en.wikipedia.org/wiki/POODLE
                        enum:
                        - VersionTLS10
                        - VersionTLS11
                        - VersionTLS12
                        - VersionTLS13
                        type: string
                    type: object
                  virtualMachineInstancesPerNode:
                    type: integer
                  virtualMachineOptions:
                    description: VirtualMachineOptions holds the cluster level information regarding the virtual machine.
                    properties:
                      disableFreePageReporting:
                        description: >-
                          DisableFreePageReporting disable the free page reporting of

                          memory balloon device https://libvirt.org/formatdomain.html#memory-balloon-device.

                          This will have effect only if AutoattachMemBalloon is not false and the vmi is not

                          requesting any high performance feature (dedicatedCPU/realtime/hugePages), in which free page reporting is always disabled.
                        type: object
                      disableSerialConsoleLog:
                        description: >-
                          DisableSerialConsoleLog disables logging the auto-attached default serial console.

                          If not set, serial console logs will be written to a file and then streamed from a container named 'guest-console-log'.

                          The value can be individually overridden for each VM, not relevant if AutoattachSerialConsole is disabled.
                        type: object
                    type: object
                  vmRolloutStrategy:
                    description: >-
                      VMRolloutStrategy defines how live-updatable fields, like CPU sockets, memory,

                      tolerations, and affinity, are propagated from a VM to its VMI.
                    enum:
                    - Stage
                    - LiveUpdate
                    nullable: true
                    type: string
                  vmStateStorageClass:
                    description: VMStateStorageClass is the name of the storage class to use for the PVCs created to preserve VM state, like TPM.
                    type: string
                  webhookConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                type: object
              customizeComponents:
                properties:
                  flags:
                    description: Configure the value used for deployment and daemonset resources
                    properties:
                      api:
                        additionalProperties:
                          type: string
                        type: object
                      controller:
                        additionalProperties:
                          type: string
                        type: object
                      handler:
                        additionalProperties:
                          type: string
                        type: object
                    type: object
                  patches:
                    items:
                      properties:
                        patch:
                          type: string
                        resourceName:
                          minLength: 1
                          type: string
                        resourceType:
                          minLength: 1
                          type: string
                        type:
                          type: string
                      required:
                      - patch
                      - resourceName
                      - resourceType
                      - type
                      type: object
                    type: array
                    x-kubernetes-list-type: atomic
                type: object
              imagePullPolicy:
                description: The ImagePullPolicy to use.
                type: string
              imagePullSecrets:
                description: >-
                  The imagePullSecrets to pull the container images from

                  Defaults to none
                items:
                  description: >-
                    LocalObjectReference contains enough information to let you locate the

                    referenced object inside the same namespace.
                  properties:
                    name:
                      default: ''
                      description: >-
                        Name of the referent.

                        This field is effectively required, but due to backwards compatibility is

                        allowed to be empty. Instances of this type with an empty value here are

                        almost certainly wrong.

                        More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
                      type: string
                  type: object
                  x-kubernetes-map-type: atomic
                type: array
                x-kubernetes-list-type: atomic
              imageRegistry:
                description: >-
                  The image registry to pull the container images from

                  Defaults to the same registry the operator's container image is pulled from.
                type: string
              imageTag:
                description: >-
                  The image tag to use for the continer images installed.

                  Defaults to the same tag as the operator's container image.
                type: string
              infra:
                description: selectors and tolerations that should apply to KubeVirt infrastructure components
                properties:
                  nodePlacement:
                    description: >-
                      nodePlacement describes scheduling configuration for specific

                      KubeVirt components
                    properties:
                      affinity:
                        description: >-
                          affinity enables pod affinity/anti-affinity placement expanding the types of constraints

                          that can be expressed with nodeSelector.

                          affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector

                          See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
                        properties:
                          nodeAffinity:
                            description: Describes node affinity scheduling rules for the pod.
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node matches the corresponding matchExpressions; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: >-
                                    An empty preferred scheduling term matches all objects with implicit weight 0

                                    (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
                                  properties:
                                    preference:
                                      description: A node selector term, associated with the corresponding weight.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    weight:
                                      description: Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - preference
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to an update), the system

                                  may or may not try to eventually evict the pod from its node.
                                properties:
                                  nodeSelectorTerms:
                                    description: Required. A list of node selector terms. The terms are ORed.
                                    items:
                                      description: >-
                                        A null or empty node selector term matches no objects. The requirements of

                                        them are ANDed.

                                        The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    type: array
                                    x-kubernetes-list-type: atomic
                                required:
                                - nodeSelectorTerms
                                type: object
                                x-kubernetes-map-type: atomic
                            type: object
                          podAffinity:
                            description: Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                          podAntiAffinity:
                            description: Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the anti-affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling anti-affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the anti-affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the anti-affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                        type: object
                      nodeSelector:
                        additionalProperties:
                          type: string
                        description: >-
                          nodeSelector is the node selector applied to the relevant kind of pods

                          It specifies a map of key-value pairs: for the pod to be eligible to run on a node,

                          the node must have each of the indicated key-value pairs as labels

                          (it can have additional labels as well).

                          See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector
                        type: object
                      tolerations:
                        description: >-
                          tolerations is a list of tolerations applied to the relevant kind of pods

                          See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info.

                          These are additional tolerations other than default ones.
                        items:
                          description: >-
                            The pod this Toleration is attached to tolerates any taint that matches

                            the triple <key,value,effect> using the matching operator <operator>.
                          properties:
                            effect:
                              description: >-
                                Effect indicates the taint effect to match. Empty means match all taint effects.

                                When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
                              type: string
                            key:
                              description: >-
                                Key is the taint key that the toleration applies to. Empty means match all taint keys.

                                If the key is empty, operator must be Exists; this combination means to match all values and all keys.
                              type: string
                            operator:
                              description: >-
                                Operator represents a key's relationship to the value.

                                Valid operators are Exists and Equal. Defaults to Equal.

                                Exists is equivalent to wildcard for value, so that a pod can

                                tolerate all taints of a particular category.
                              type: string
                            tolerationSeconds:
                              description: >-
                                TolerationSeconds represents the period of time the toleration (which must be

                                of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,

                                it is not set, which means tolerate the taint forever (do not evict). Zero and

                                negative values will be treated as 0 (evict immediately) by the system.
                              format: int64
                              type: integer
                            value:
                              description: >-
                                Value is the taint value the toleration matches to.

                                If the operator is Exists, the value should be empty, otherwise just a regular string.
                              type: string
                          type: object
                        type: array
                    type: object
                  replicas:
                    description: >-
                      replicas indicates how many replicas should be created for each KubeVirt infrastructure

                      component (like virt-api or virt-controller). Defaults to 2.

                      WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!
                    type: integer
                type: object
              monitorAccount:
                description: >-
                  The name of the Prometheus service account that needs read-access to KubeVirt endpoints

                  Defaults to prometheus-k8s
                type: string
              monitorNamespace:
                description: >-
                  The namespace Prometheus is deployed in

                  Defaults to openshift-monitor
                type: string
              productComponent:
                description: >-
                  Designate the apps.kubevirt.io/component label for KubeVirt components.

                  Useful if KubeVirt is included as part of a product.

                  If ProductComponent is not specified, the component label default value is kubevirt.
                type: string
              productName:
                description: >-
                  Designate the apps.kubevirt.io/part-of label for KubeVirt components.

                  Useful if KubeVirt is included as part of a product.

                  If ProductName is not specified, the part-of label will be omitted.
                type: string
              productVersion:
                description: >-
                  Designate the apps.kubevirt.io/version label for KubeVirt components.

                  Useful if KubeVirt is included as part of a product.

                  If ProductVersion is not specified, KubeVirt's version will be used.
                type: string
              serviceMonitorNamespace:
                description: >-
                  The namespace the service monitor will be deployed
                   When ServiceMonitorNamespace is set, then we'll install the service monitor object in that namespace
                  otherwise we will use the monitoring namespace.
                type: string
              synchronizationPort:
                description: Specify the port to listen on for VMI status synchronization traffic. Default is 9185
                type: string
              uninstallStrategy:
                description: >-
                  Specifies if kubevirt can be deleted if workloads are still present.

                  This is mainly a precaution to avoid accidental data loss
                type: string
              workloadUpdateStrategy:
                description: >-
                  WorkloadUpdateStrategy defines at the cluster level how to handle

                  automated workload updates
                properties:
                  batchEvictionInterval:
                    description: >-
                      BatchEvictionInterval Represents the interval to wait before issuing the next

                      batch of shutdowns


                      Defaults to 1 minute
                    type: string
                  batchEvictionSize:
                    description: >-
                      BatchEvictionSize Represents the number of VMIs that can be forced updated per

                      the BatchShutdownInteral interval


                      Defaults to 10
                    type: integer
                  workloadUpdateMethods:
                    description: >-
                      WorkloadUpdateMethods defines the methods that can be used to disrupt workloads

                      during automated workload updates.

                      When multiple methods are present, the least disruptive method takes

                      precedence over more disruptive methods. For example if both LiveMigrate and Shutdown

                      methods are listed, only VMs which are not live migratable will be restarted/shutdown


                      An empty list defaults to no automated workload updating
                    items:
                      type: string
                    type: array
                    x-kubernetes-list-type: atomic
                type: object
              workloads:
                description: selectors and tolerations that should apply to KubeVirt workloads
                properties:
                  nodePlacement:
                    description: >-
                      nodePlacement describes scheduling configuration for specific

                      KubeVirt components
                    properties:
                      affinity:
                        description: >-
                          affinity enables pod affinity/anti-affinity placement expanding the types of constraints

                          that can be expressed with nodeSelector.

                          affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector

                          See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
                        properties:
                          nodeAffinity:
                            description: Describes node affinity scheduling rules for the pod.
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node matches the corresponding matchExpressions; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: >-
                                    An empty preferred scheduling term matches all objects with implicit weight 0

                                    (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
                                  properties:
                                    preference:
                                      description: A node selector term, associated with the corresponding weight.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    weight:
                                      description: Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - preference
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to an update), the system

                                  may or may not try to eventually evict the pod from its node.
                                properties:
                                  nodeSelectorTerms:
                                    description: Required. A list of node selector terms. The terms are ORed.
                                    items:
                                      description: >-
                                        A null or empty node selector term matches no objects. The requirements of

                                        them are ANDed.

                                        The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    type: array
                                    x-kubernetes-list-type: atomic
                                required:
                                - nodeSelectorTerms
                                type: object
                                x-kubernetes-map-type: atomic
                            type: object
                          podAffinity:
                            description: Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                          podAntiAffinity:
                            description: Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the anti-affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling anti-affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the anti-affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the anti-affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                        type: object
                      nodeSelector:
                        additionalProperties:
                          type: string
                        description: >-
                          nodeSelector is the node selector applied to the relevant kind of pods

                          It specifies a map of key-value pairs: for the pod to be eligible to run on a node,

                          the node must have each of the indicated key-value pairs as labels

                          (it can have additional labels as well).

                          See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector
                        type: object
                      tolerations:
                        description: >-
                          tolerations is a list of tolerations applied to the relevant kind of pods

                          See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info.

                          These are additional tolerations other than default ones.
                        items:
                          description: >-
                            The pod this Toleration is attached to tolerates any taint that matches

                            the triple <key,value,effect> using the matching operator <operator>.
                          properties:
                            effect:
                              description: >-
                                Effect indicates the taint effect to match. Empty means match all taint effects.

                                When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
                              type: string
                            key:
                              description: >-
                                Key is the taint key that the toleration applies to. Empty means match all taint keys.

                                If the key is empty, operator must be Exists; this combination means to match all values and all keys.
                              type: string
                            operator:
                              description: >-
                                Operator represents a key's relationship to the value.

                                Valid operators are Exists and Equal. Defaults to Equal.

                                Exists is equivalent to wildcard for value, so that a pod can

                                tolerate all taints of a particular category.
                              type: string
                            tolerationSeconds:
                              description: >-
                                TolerationSeconds represents the period of time the toleration (which must be

                                of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,

                                it is not set, which means tolerate the taint forever (do not evict). Zero and

                                negative values will be treated as 0 (evict immediately) by the system.
                              format: int64
                              type: integer
                            value:
                              description: >-
                                Value is the taint value the toleration matches to.

                                If the operator is Exists, the value should be empty, otherwise just a regular string.
                              type: string
                          type: object
                        type: array
                    type: object
                  replicas:
                    description: >-
                      replicas indicates how many replicas should be created for each KubeVirt infrastructure

                      component (like virt-api or virt-controller). Defaults to 2.

                      WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!
                    type: integer
                type: object
            type: object
          status:
            description: KubeVirtStatus represents information pertaining to a KubeVirt deployment.
            properties:
              conditions:
                items:
                  description: KubeVirtCondition represents a condition of a KubeVirt deployment
                  properties:
                    lastProbeTime:
                      format: date-time
                      nullable: true
                      type: string
                    lastTransitionTime:
                      format: date-time
                      nullable: true
                      type: string
                    message:
                      type: string
                    reason:
                      type: string
                    status:
                      type: string
                    type:
                      type: string
                  required:
                  - status
                  - type
                  type: object
                type: array
              defaultArchitecture:
                type: string
              generations:
                items:
                  description: GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made.
                  properties:
                    group:
                      description: group is the group of the thing you're tracking
                      type: string
                    hash:
                      description: hash is an optional field set for resources without generation that are content sensitive like secrets and configmaps
                      type: string
                    lastGeneration:
                      description: lastGeneration is the last generation of the workload controller involved
                      format: int64
                      type: integer
                    name:
                      description: name is the name of the thing you're tracking
                      type: string
                    namespace:
                      description: namespace is where the thing you're tracking is
                      type: string
                    resource:
                      description: resource is the resource type of the thing you're tracking
                      type: string
                  required:
                  - group
                  - lastGeneration
                  - name
                  - resource
                  type: object
                type: array
                x-kubernetes-list-type: atomic
              observedDeploymentConfig:
                type: string
              observedDeploymentID:
                type: string
              observedGeneration:
                format: int64
                type: integer
              observedKubeVirtRegistry:
                type: string
              observedKubeVirtVersion:
                type: string
              operatorVersion:
                type: string
              outdatedVirtualMachineInstanceWorkloads:
                type: integer
              phase:
                description: KubeVirtPhase is a label for the phase of a KubeVirt deployment at the current time.
                type: string
              synchronizationAddresses:
                items:
                  type: string
                type: array
                x-kubernetes-list-type: atomic
              targetDeploymentConfig:
                type: string
              targetDeploymentID:
                type: string
              targetKubeVirtRegistry:
                type: string
              targetKubeVirtVersion:
                type: string
            type: object
        required:
        - spec
        type: object
    served: true
    storage: true
    subresources:
      status: {}
  - additionalPrinterColumns:
    - jsonPath: .metadata.creationTimestamp
      name: Age
      type: date
    - jsonPath: .status.phase
      name: Phase
      type: string
    deprecated: true
    deprecationWarning: kubevirt.io/v1alpha3 is now deprecated and will be removed in a future release.
    name: v1alpha3
    schema:
      openAPIV3Schema:
        description: KubeVirt represents the object deploying all KubeVirt resources
        properties:
          apiVersion:
            description: >-
              APIVersion defines the versioned schema of this representation of an object.

              Servers should convert recognized schemas to the latest internal value, and

              may reject unrecognized values.

              More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
            type: string
          kind:
            description: >-
              Kind is a string value representing the REST resource this object represents.

              Servers may infer this from the endpoint the client submits requests to.

              Cannot be updated.

              In CamelCase.

              More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            type: string
          metadata:
            type: object
          spec:
            properties:
              certificateRotateStrategy:
                properties:
                  selfSigned:
                    properties:
                      ca:
                        description: >-
                          CA configuration

                          CA certs are kept in the CA bundle as long as they are valid
                        properties:
                          duration:
                            description: The requested 'duration' (i.e. lifetime) of the Certificate.
                            type: string
                          renewBefore:
                            description: >-
                              The amount of time before the currently issued certificate's ""notAfter""

                              time that we will begin to attempt to renew the certificate.
                            type: string
                        type: object
                      caOverlapInterval:
                        description: Deprecated. Use CA.Duration and CA.RenewBefore instead
                        type: string
                      caRotateInterval:
                        description: Deprecated. Use CA.Duration instead
                        type: string
                      certRotateInterval:
                        description: Deprecated. Use Server.Duration instead
                        type: string
                      server:
                        description: >-
                          Server configuration

                          Certs are rotated and discarded
                        properties:
                          duration:
                            description: The requested 'duration' (i.e. lifetime) of the Certificate.
                            type: string
                          renewBefore:
                            description: >-
                              The amount of time before the currently issued certificate's ""notAfter""

                              time that we will begin to attempt to renew the certificate.
                            type: string
                        type: object
                    type: object
                type: object
              configuration:
                description: >-
                  holds kubevirt configurations.

                  same as the virt-configMap
                properties:
                  additionalGuestMemoryOverheadRatio:
                    description: >-
                      AdditionalGuestMemoryOverheadRatio can be used to increase the virtualization infrastructure

                      overhead. This is useful, since the calculation of this overhead is not accurate and cannot

                      be entirely known in advance. The ratio that is being set determines by which factor to increase

                      the overhead calculated by Kubevirt. A higher ratio means that the VMs would be less compromised

                      by node pressures, but would mean that fewer VMs could be scheduled to a node.

                      If not set, the default is 1.
                    type: string
                  apiConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                  architectureConfiguration:
                    properties:
                      amd64:
                        properties:
                          emulatedMachines:
                            items:
                              type: string
                            type: array
                            x-kubernetes-list-type: atomic
                          machineType:
                            type: string
                          ovmfPath:
                            type: string
                        type: object
                      arm64:
                        properties:
                          emulatedMachines:
                            items:
                              type: string
                            type: array
                            x-kubernetes-list-type: atomic
                          machineType:
                            type: string
                          ovmfPath:
                            type: string
                        type: object
                      defaultArchitecture:
                        type: string
                      ppc64le:
                        properties:
                          emulatedMachines:
                            items:
                              type: string
                            type: array
                            x-kubernetes-list-type: atomic
                          machineType:
                            type: string
                          ovmfPath:
                            type: string
                        type: object
                    type: object
                  autoCPULimitNamespaceLabelSelector:
                    description: >-
                      When set, AutoCPULimitNamespaceLabelSelector will set a CPU limit on virt-launcher for VMIs running inside

                      namespaces that match the label selector.

                      The CPU limit will equal the number of requested vCPUs.

                      This setting does not apply to VMIs with dedicated CPUs.
                    properties:
                      matchExpressions:
                        description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                        items:
                          description: >-
                            A label selector requirement is a selector that contains values, a key, and an operator that

                            relates the key and values.
                          properties:
                            key:
                              description: key is the label key that the selector applies to.
                              type: string
                            operator:
                              description: >-
                                operator represents a key's relationship to a set of values.

                                Valid operators are In, NotIn, Exists and DoesNotExist.
                              type: string
                            values:
                              description: >-
                                values is an array of string values. If the operator is In or NotIn,

                                the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                the values array must be empty. This array is replaced during a strategic

                                merge patch.
                              items:
                                type: string
                              type: array
                              x-kubernetes-list-type: atomic
                          required:
                          - key
                          - operator
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                      matchLabels:
                        additionalProperties:
                          type: string
                        description: >-
                          matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                          map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                          operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                        type: object
                    type: object
                    x-kubernetes-map-type: atomic
                  commonInstancetypesDeployment:
                    description: CommonInstancetypesDeployment controls the deployment of common-instancetypes resources
                    nullable: true
                    properties:
                      enabled:
                        description: Enabled controls the deployment of common-instancetypes resources, defaults to True.
                        nullable: true
                        type: boolean
                    type: object
                  controllerConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                  cpuModel:
                    type: string
                  cpuRequest:
                    anyOf:
                    - type: integer
                    - type: string
                    pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                    x-kubernetes-int-or-string: true
                  defaultRuntimeClass:
                    type: string
                  developerConfiguration:
                    description: DeveloperConfiguration holds developer options
                    properties:
                      clusterProfiler:
                        description: Enable the ability to pprof profile KubeVirt control plane
                        type: boolean
                      cpuAllocationRatio:
                        description: >-
                          For each requested virtual CPU, CPUAllocationRatio defines how much physical CPU to request per VMI

                          from the hosting node. The value is in fraction of a CPU thread (or core on non-hyperthreaded nodes).

                          For example, a value of 1 means 1 physical CPU thread per VMI CPU thread.

                          A value of 100 would be 1% of a physical thread allocated for each requested VMI thread.

                          This option has no effect on VMIs that request dedicated CPUs. More information at:

                          https://kubevirt.io/user-guide/operations/node_overcommit/#node-cpu-allocation-ratio

                          Defaults to 10
                        type: integer
                      diskVerification:
                        description: DiskVerification holds container disks verification limits
                        properties:
                          memoryLimit:
                            anyOf:
                            - type: integer
                            - type: string
                            pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                            x-kubernetes-int-or-string: true
                        required:
                        - memoryLimit
                        type: object
                      featureGates:
                        description: FeatureGates is the list of experimental features to enable. Defaults to none
                        items:
                          type: string
                        type: array
                      logVerbosity:
                        description: LogVerbosity sets log verbosity level of  various components
                        properties:
                          nodeVerbosity:
                            additionalProperties:
                              type: integer
                            description: NodeVerbosity represents a map of nodes with a specific verbosity level
                            type: object
                          virtAPI:
                            type: integer
                          virtController:
                            type: integer
                          virtHandler:
                            type: integer
                          virtLauncher:
                            type: integer
                          virtOperator:
                            type: integer
                          virtSynchronizationController:
                            type: integer
                        type: object
                      memoryOvercommit:
                        description: >-
                          MemoryOvercommit is the percentage of memory we want to give VMIs compared to the amount

                          given to its parent pod (virt-launcher). For example, a value of 102 means the VMI will

                          ""see"" 2% more memory than its parent pod. Values under 100 are effectively ""undercommits"".

                          Overcommits can lead to memory exhaustion, which in turn can lead to crashes. Use carefully.

                          Defaults to 100
                        type: integer
                      minimumClusterTSCFrequency:
                        description: >-
                          Allow overriding the automatically determined minimum TSC frequency of the cluster

                          and fixate the minimum to this frequency.
                        format: int64
                        type: integer
                      minimumReservePVCBytes:
                        description: >-
                          MinimumReservePVCBytes is the amount of space, in bytes, to leave unused on disks.

                          Defaults to 131072 (128KiB)
                        format: int64
                        type: integer
                      nodeSelectors:
                        additionalProperties:
                          type: string
                        description: >-
                          NodeSelectors allows restricting VMI creation to nodes that match a set of labels.

                          Defaults to none
                        type: object
                      pvcTolerateLessSpaceUpToPercent:
                        description: >-
                          LessPVCSpaceToleration determines how much smaller, in percentage, disk PVCs are

                          allowed to be compared to the requested size (to account for various overheads).

                          Defaults to 10
                        type: integer
                      useEmulation:
                        description: >-
                          UseEmulation can be set to true to allow fallback to software emulation

                          in case hardware-assisted emulation is not available. Defaults to false
                        type: boolean
                    type: object
                  emulatedMachines:
                    description: Deprecated. Use architectureConfiguration instead.
                    items:
                      type: string
                    type: array
                  evictionStrategy:
                    description: >-
                      EvictionStrategy defines at the cluster level if the VirtualMachineInstance should be

                      migrated instead of shut-off in case of a node drain. If the VirtualMachineInstance specific

                      field is set it overrides the cluster level one.
                    type: string
                  handlerConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                  imagePullPolicy:
                    description: PullPolicy describes a policy for if/when to pull a container image
                    type: string
                  instancetype:
                    description: Instancetype configuration
                    nullable: true
                    properties:
                      referencePolicy:
                        description: >-
                          ReferencePolicy defines how an instance type or preference should be referenced by the VM after submission, supported values are:

                          reference (default) - Where a copy of the original object is stashed in a ControllerRevision and referenced by the VM.

                          expand - Where the instance type or preference are expanded into the VM if no revisionNames have been populated.

                          expandAll - Where the instance type or preference are expanded into the VM regardless of revisionNames previously being populated.
                        enum:
                        - reference
                        - expand
                        - expandAll
                        nullable: true
                        type: string
                    type: object
                  ksmConfiguration:
                    description: KSMConfiguration holds the information regarding the enabling the KSM in the nodes (if available).
                    properties:
                      nodeLabelSelector:
                        description: >-
                          NodeLabelSelector is a selector that filters in which nodes the KSM will be enabled.

                          Empty NodeLabelSelector will enable ksm for every node.
                        properties:
                          matchExpressions:
                            description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                            items:
                              description: >-
                                A label selector requirement is a selector that contains values, a key, and an operator that

                                relates the key and values.
                              properties:
                                key:
                                  description: key is the label key that the selector applies to.
                                  type: string
                                operator:
                                  description: >-
                                    operator represents a key's relationship to a set of values.

                                    Valid operators are In, NotIn, Exists and DoesNotExist.
                                  type: string
                                values:
                                  description: >-
                                    values is an array of string values. If the operator is In or NotIn,

                                    the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                    the values array must be empty. This array is replaced during a strategic

                                    merge patch.
                                  items:
                                    type: string
                                  type: array
                                  x-kubernetes-list-type: atomic
                              required:
                              - key
                              - operator
                              type: object
                            type: array
                            x-kubernetes-list-type: atomic
                          matchLabels:
                            additionalProperties:
                              type: string
                            description: >-
                              matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                              map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                              operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                            type: object
                        type: object
                        x-kubernetes-map-type: atomic
                    type: object
                  liveUpdateConfiguration:
                    description: LiveUpdateConfiguration holds defaults for live update features
                    properties:
                      maxCpuSockets:
                        description: >-
                          MaxCpuSockets provides a MaxSockets value for VMs that do not provide their own.

                          For VMs with more sockets than maximum the MaxSockets will be set to equal number of sockets.
                        format: int32
                        type: integer
                      maxGuest:
                        anyOf:
                        - type: integer
                        - type: string
                        description: >-
                          MaxGuest defines the maximum amount memory that can be allocated

                          to the guest using hotplug.
                        pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                        x-kubernetes-int-or-string: true
                      maxHotplugRatio:
                        description: >-
                          MaxHotplugRatio is the ratio used to define the max amount

                          of a hotplug resource that can be made available to a VM

                          when the specific Max* setting is not defined (MaxCpuSockets, MaxGuest)

                          Example: VM is configured with 512Mi of guest memory, if MaxGuest is not

                          defined and MaxHotplugRatio is 2 then MaxGuest = 1Gi

                          defaults to 4
                        format: int32
                        type: integer
                    type: object
                  machineType:
                    description: Deprecated. Use architectureConfiguration instead.
                    type: string
                  mediatedDevicesConfiguration:
                    description: MediatedDevicesConfiguration holds information about MDEV types to be defined, if available
                    properties:
                      mediatedDeviceTypes:
                        items:
                          type: string
                        type: array
                        x-kubernetes-list-type: atomic
                      mediatedDevicesTypes:
                        description: Deprecated. Use mediatedDeviceTypes instead.
                        items:
                          type: string
                        type: array
                        x-kubernetes-list-type: atomic
                      nodeMediatedDeviceTypes:
                        items:
                          description: NodeMediatedDeviceTypesConfig holds information about MDEV types to be defined in a specific node that matches the NodeSelector field.
                          properties:
                            mediatedDeviceTypes:
                              items:
                                type: string
                              type: array
                              x-kubernetes-list-type: atomic
                            mediatedDevicesTypes:
                              description: Deprecated. Use mediatedDeviceTypes instead.
                              items:
                                type: string
                              type: array
                              x-kubernetes-list-type: atomic
                            nodeSelector:
                              additionalProperties:
                                type: string
                              description: >-
                                NodeSelector is a selector which must be true for the vmi to fit on a node.

                                Selector which must match a node's labels for the vmi to be scheduled on that node.

                                More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
                              type: object
                          required:
                          - nodeSelector
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                    type: object
                  memBalloonStatsPeriod:
                    format: int32
                    type: integer
                  migrations:
                    description: >-
                      MigrationConfiguration holds migration options.

                      Can be overridden for specific groups of VMs though migration policies.

                      Visit https://kubevirt.io/user-guide/operations/migration_policies/ for more information.
                    properties:
                      allowAutoConverge:
                        description: >-
                          AllowAutoConverge allows the platform to compromise performance/availability of VMIs to

                          guarantee successful VMI live migrations. Defaults to false
                        type: boolean
                      allowPostCopy:
                        description: >-
                          AllowPostCopy enables post-copy live migrations. Such migrations allow even the busiest VMIs

                          to successfully live-migrate. However, events like a network failure can cause a VMI crash.

                          If set to true, migrations will still start in pre-copy, but switch to post-copy when

                          CompletionTimeoutPerGiB triggers. Defaults to false
                        type: boolean
                      allowWorkloadDisruption:
                        description: >-
                          AllowWorkloadDisruption indicates that the migration shouldn't be

                          canceled after acceptableCompletionTime is exceeded. Instead, if

                          permitted, migration will be switched to post-copy or the VMI will be

                          paused to allow the migration to complete
                        type: boolean
                      bandwidthPerMigration:
                        anyOf:
                        - type: integer
                        - type: string
                        description: >-
                          BandwidthPerMigration limits the amount of network bandwidth live migrations are allowed to use.

                          The value is in quantity per second. Defaults to 0 (no limit)
                        pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                        x-kubernetes-int-or-string: true
                      completionTimeoutPerGiB:
                        description: >-
                          CompletionTimeoutPerGiB is the maximum number of seconds per GiB a migration is allowed to take.

                          If the timeout is reached, the migration will be either paused, switched

                          to post-copy or cancelled depending on other settings. Defaults to 150
                        format: int64
                        type: integer
                      disableTLS:
                        description: >-
                          When set to true, DisableTLS will disable the additional layer of live migration encryption

                          provided by KubeVirt. This is usually a bad idea. Defaults to false
                        type: boolean
                      matchSELinuxLevelOnMigration:
                        description: >-
                          By default, the SELinux level of target virt-launcher pods is forced to the level of the source virt-launcher.

                          When set to true, MatchSELinuxLevelOnMigration lets the CRI auto-assign a random level to the target.

                          That will ensure the target virt-launcher doesn't share categories with another pod on the node.

                          However, migrations will fail when using RWX volumes that don't automatically deal with SELinux levels.
                        type: boolean
                      network:
                        description: >-
                          Network is the name of the CNI network to use for live migrations. By default, migrations go

                          through the pod network.
                        type: string
                      nodeDrainTaintKey:
                        description: >-
                          NodeDrainTaintKey defines the taint key that indicates a node should be drained.

                          Note: this option relies on the deprecated node taint feature. Default: kubevirt.io/drain
                        type: string
                      parallelMigrationsPerCluster:
                        description: >-
                          ParallelMigrationsPerCluster is the total number of concurrent live migrations

                          allowed cluster-wide. Defaults to 5
                        format: int32
                        type: integer
                      parallelOutboundMigrationsPerNode:
                        description: >-
                          ParallelOutboundMigrationsPerNode is the maximum number of concurrent outgoing live migrations

                          allowed per node. Defaults to 2
                        format: int32
                        type: integer
                      progressTimeout:
                        description: >-
                          ProgressTimeout is the maximum number of seconds a live migration is allowed to make no progress.

                          Hitting this timeout means a migration transferred 0 data for that many seconds. The migration is

                          then considered stuck and therefore cancelled. Defaults to 150
                        format: int64
                        type: integer
                      unsafeMigrationOverride:
                        description: >-
                          UnsafeMigrationOverride allows live migrations to occur even if the compatibility check

                          indicates the migration will be unsafe to the guest. Defaults to false
                        type: boolean
                    type: object
                  minCPUModel:
                    type: string
                  network:
                    description: NetworkConfiguration holds network options
                    properties:
                      binding:
                        additionalProperties:
                          properties:
                            computeResourceOverhead:
                              description: >-
                                ComputeResourceOverhead specifies the resource overhead that should be added to the compute container when using the binding.

                                version: v1alphav1
                              properties:
                                limits:
                                  additionalProperties:
                                    anyOf:
                                    - type: integer
                                    - type: string
                                    pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                    x-kubernetes-int-or-string: true
                                  description: >-
                                    Limits describes the maximum amount of compute resources allowed.

                                    More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                                  type: object
                                requests:
                                  additionalProperties:
                                    anyOf:
                                    - type: integer
                                    - type: string
                                    pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                    x-kubernetes-int-or-string: true
                                  description: >-
                                    Requests describes the minimum amount of compute resources required.

                                    If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,

                                    otherwise to an implementation-defined value. Requests cannot exceed Limits.

                                    More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                                  type: object
                              type: object
                            domainAttachmentType:
                              description: >-
                                DomainAttachmentType is a standard domain network attachment method kubevirt supports.

                                Supported values: ""tap"", ""managedTap"" (since v1.4).

                                The standard domain attachment can be used instead or in addition to the sidecarImage.

                                version: 1alphav1
                              type: string
                            downwardAPI:
                              description: >-
                                DownwardAPI specifies what kind of data should be exposed to the binding plugin sidecar.

                                Supported values: ""device-info""

                                version: v1alphav1
                              type: string
                            migration:
                              description: >-
                                Migration means the VM using the plugin can be safely migrated

                                version: 1alphav1
                              properties:
                                method:
                                  description: >-
                                    Method defines a pre-defined migration methodology

                                    version: 1alphav1
                                  type: string
                              type: object
                            networkAttachmentDefinition:
                              description: >-
                                NetworkAttachmentDefinition references to a NetworkAttachmentDefinition CR object.

                                Format: <name>, <namespace>/<name>.

                                If namespace is not specified, VMI namespace is assumed.

                                version: 1alphav1
                              type: string
                            sidecarImage:
                              description: >-
                                SidecarImage references a container image that runs in the virt-launcher pod.

                                The sidecar handles (libvirt) domain configuration and optional services.

                                version: 1alphav1
                              type: string
                          type: object
                        type: object
                      defaultNetworkInterface:
                        type: string
                      permitBridgeInterfaceOnPodNetwork:
                        type: boolean
                      permitSlirpInterface:
                        description: >-
                          DeprecatedPermitSlirpInterface is an alias for the deprecated PermitSlirpInterface.

                          Deprecated: Removed in v1.3.
                        type: boolean
                    type: object
                  obsoleteCPUModels:
                    additionalProperties:
                      type: boolean
                    type: object
                  ovmfPath:
                    description: Deprecated. Use architectureConfiguration instead.
                    type: string
                  permittedHostDevices:
                    description: PermittedHostDevices holds information about devices allowed for passthrough
                    properties:
                      mediatedDevices:
                        items:
                          description: MediatedHostDevice represents a host mediated device allowed for passthrough
                          properties:
                            externalResourceProvider:
                              type: boolean
                            mdevNameSelector:
                              type: string
                            resourceName:
                              type: string
                          required:
                          - mdevNameSelector
                          - resourceName
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                      pciHostDevices:
                        items:
                          description: PciHostDevice represents a host PCI device allowed for passthrough
                          properties:
                            externalResourceProvider:
                              description: >-
                                If true, KubeVirt will leave the allocation and monitoring to an

                                external device plugin
                              type: boolean
                            pciVendorSelector:
                              description: The vendor_id:product_id tuple of the PCI device
                              type: string
                            resourceName:
                              description: >-
                                The name of the resource that is representing the device. Exposed by

                                a device plugin and requested by VMs. Typically of the form

                                vendor.com/product_name
                              type: string
                          required:
                          - pciVendorSelector
                          - resourceName
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                      usb:
                        items:
                          properties:
                            externalResourceProvider:
                              description: >-
                                If true, KubeVirt will leave the allocation and monitoring to an

                                external device plugin
                              type: boolean
                            resourceName:
                              description: >-
                                Identifies the list of USB host devices.

                                e.g: kubevirt.io/storage, kubevirt.io/bootable-usb, etc
                              type: string
                            selectors:
                              items:
                                properties:
                                  product:
                                    type: string
                                  vendor:
                                    type: string
                                required:
                                - product
                                - vendor
                                type: object
                              type: array
                              x-kubernetes-list-type: atomic
                          required:
                          - resourceName
                          type: object
                        type: array
                        x-kubernetes-list-type: atomic
                    type: object
                  seccompConfiguration:
                    description: SeccompConfiguration holds Seccomp configuration for Kubevirt components
                    properties:
                      virtualMachineInstanceProfile:
                        description: VirtualMachineInstanceProfile defines what profile should be used with virt-launcher. Defaults to none
                        properties:
                          customProfile:
                            description: CustomProfile allows to request arbitrary profile for virt-launcher
                            properties:
                              localhostProfile:
                                type: string
                              runtimeDefaultProfile:
                                type: boolean
                            type: object
                        type: object
                    type: object
                  selinuxLauncherType:
                    type: string
                  smbios:
                    properties:
                      family:
                        type: string
                      manufacturer:
                        type: string
                      product:
                        type: string
                      sku:
                        type: string
                      version:
                        type: string
                    type: object
                  supportContainerResources:
                    description: SupportContainerResources specifies the resource requirements for various types of supporting containers such as container disks/virtiofs/sidecars and hotplug attachment pods. If omitted a sensible default will be supplied.
                    items:
                      description: SupportContainerResources are used to specify the cpu/memory request and limits for the containers that support various features of Virtual Machines. These containers are usually idle and don't require a lot of memory or cpu.
                      properties:
                        resources:
                          description: >-
                            ResourceRequirementsWithoutClaims describes the compute resource requirements.

                            This struct was taken from the k8s.ResourceRequirements and cleaned up the 'Claims' field.
                          properties:
                            limits:
                              additionalProperties:
                                anyOf:
                                - type: integer
                                - type: string
                                pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                x-kubernetes-int-or-string: true
                              description: >-
                                Limits describes the maximum amount of compute resources allowed.

                                More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                              type: object
                            requests:
                              additionalProperties:
                                anyOf:
                                - type: integer
                                - type: string
                                pattern: ^(\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\+|-)?(([0-9]+(\.[0-9]*)?)|(\.[0-9]+))))?$
                                x-kubernetes-int-or-string: true
                              description: >-
                                Requests describes the minimum amount of compute resources required.

                                If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,

                                otherwise to an implementation-defined value. Requests cannot exceed Limits.

                                More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
                              type: object
                          type: object
                        type:
                          type: string
                      required:
                      - resources
                      - type
                      type: object
                    type: array
                    x-kubernetes-list-map-keys:
                    - type
                    x-kubernetes-list-type: map
                  supportedGuestAgentVersions:
                    description: deprecated
                    items:
                      type: string
                    type: array
                  tlsConfiguration:
                    description: TLSConfiguration holds TLS options
                    properties:
                      ciphers:
                        items:
                          type: string
                        type: array
                        x-kubernetes-list-type: set
                      minTLSVersion:
                        description: >-
                          MinTLSVersion is a way to specify the minimum protocol version that is acceptable for TLS connections.

                          Protocol versions are based on the following most common TLS configurations:

                            https://ssl-config.mozilla.org/

                          Note that SSLv3.0 is not a supported protocol version due to well known

                          vulnerabilities such as POODLE: https://en.wikipedia.org/wiki/POODLE
                        enum:
                        - VersionTLS10
                        - VersionTLS11
                        - VersionTLS12
                        - VersionTLS13
                        type: string
                    type: object
                  virtualMachineInstancesPerNode:
                    type: integer
                  virtualMachineOptions:
                    description: VirtualMachineOptions holds the cluster level information regarding the virtual machine.
                    properties:
                      disableFreePageReporting:
                        description: >-
                          DisableFreePageReporting disable the free page reporting of

                          memory balloon device https://libvirt.org/formatdomain.html#memory-balloon-device.

                          This will have effect only if AutoattachMemBalloon is not false and the vmi is not

                          requesting any high performance feature (dedicatedCPU/realtime/hugePages), in which free page reporting is always disabled.
                        type: object
                      disableSerialConsoleLog:
                        description: >-
                          DisableSerialConsoleLog disables logging the auto-attached default serial console.

                          If not set, serial console logs will be written to a file and then streamed from a container named 'guest-console-log'.

                          The value can be individually overridden for each VM, not relevant if AutoattachSerialConsole is disabled.
                        type: object
                    type: object
                  vmRolloutStrategy:
                    description: >-
                      VMRolloutStrategy defines how live-updatable fields, like CPU sockets, memory,

                      tolerations, and affinity, are propagated from a VM to its VMI.
                    enum:
                    - Stage
                    - LiveUpdate
                    nullable: true
                    type: string
                  vmStateStorageClass:
                    description: VMStateStorageClass is the name of the storage class to use for the PVCs created to preserve VM state, like TPM.
                    type: string
                  webhookConfiguration:
                    description: >-
                      ReloadableComponentConfiguration holds all generic k8s configuration options which can

                      be reloaded by components without requiring a restart.
                    properties:
                      restClient:
                        description: RestClient can be used to tune certain aspects of the k8s client in use.
                        properties:
                          rateLimiter:
                            description: RateLimiter allows selecting and configuring different rate limiters for the k8s client.
                            properties:
                              tokenBucketRateLimiter:
                                properties:
                                  burst:
                                    description: >-
                                      Maximum burst for throttle.

                                      If it's zero, the component default will be used
                                    type: integer
                                  qps:
                                    description: >-
                                      QPS indicates the maximum QPS to the apiserver from this client.

                                      If it's zero, the component default will be used
                                    type: number
                                required:
                                - burst
                                - qps
                                type: object
                            type: object
                        type: object
                    type: object
                type: object
              customizeComponents:
                properties:
                  flags:
                    description: Configure the value used for deployment and daemonset resources
                    properties:
                      api:
                        additionalProperties:
                          type: string
                        type: object
                      controller:
                        additionalProperties:
                          type: string
                        type: object
                      handler:
                        additionalProperties:
                          type: string
                        type: object
                    type: object
                  patches:
                    items:
                      properties:
                        patch:
                          type: string
                        resourceName:
                          minLength: 1
                          type: string
                        resourceType:
                          minLength: 1
                          type: string
                        type:
                          type: string
                      required:
                      - patch
                      - resourceName
                      - resourceType
                      - type
                      type: object
                    type: array
                    x-kubernetes-list-type: atomic
                type: object
              imagePullPolicy:
                description: The ImagePullPolicy to use.
                type: string
              imagePullSecrets:
                description: >-
                  The imagePullSecrets to pull the container images from

                  Defaults to none
                items:
                  description: >-
                    LocalObjectReference contains enough information to let you locate the

                    referenced object inside the same namespace.
                  properties:
                    name:
                      default: ''
                      description: >-
                        Name of the referent.

                        This field is effectively required, but due to backwards compatibility is

                        allowed to be empty. Instances of this type with an empty value here are

                        almost certainly wrong.

                        More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
                      type: string
                  type: object
                  x-kubernetes-map-type: atomic
                type: array
                x-kubernetes-list-type: atomic
              imageRegistry:
                description: >-
                  The image registry to pull the container images from

                  Defaults to the same registry the operator's container image is pulled from.
                type: string
              imageTag:
                description: >-
                  The image tag to use for the continer images installed.

                  Defaults to the same tag as the operator's container image.
                type: string
              infra:
                description: selectors and tolerations that should apply to KubeVirt infrastructure components
                properties:
                  nodePlacement:
                    description: >-
                      nodePlacement describes scheduling configuration for specific

                      KubeVirt components
                    properties:
                      affinity:
                        description: >-
                          affinity enables pod affinity/anti-affinity placement expanding the types of constraints

                          that can be expressed with nodeSelector.

                          affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector

                          See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
                        properties:
                          nodeAffinity:
                            description: Describes node affinity scheduling rules for the pod.
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node matches the corresponding matchExpressions; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: >-
                                    An empty preferred scheduling term matches all objects with implicit weight 0

                                    (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
                                  properties:
                                    preference:
                                      description: A node selector term, associated with the corresponding weight.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    weight:
                                      description: Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - preference
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to an update), the system

                                  may or may not try to eventually evict the pod from its node.
                                properties:
                                  nodeSelectorTerms:
                                    description: Required. A list of node selector terms. The terms are ORed.
                                    items:
                                      description: >-
                                        A null or empty node selector term matches no objects. The requirements of

                                        them are ANDed.

                                        The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    type: array
                                    x-kubernetes-list-type: atomic
                                required:
                                - nodeSelectorTerms
                                type: object
                                x-kubernetes-map-type: atomic
                            type: object
                          podAffinity:
                            description: Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                          podAntiAffinity:
                            description: Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the anti-affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling anti-affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the anti-affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the anti-affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                        type: object
                      nodeSelector:
                        additionalProperties:
                          type: string
                        description: >-
                          nodeSelector is the node selector applied to the relevant kind of pods

                          It specifies a map of key-value pairs: for the pod to be eligible to run on a node,

                          the node must have each of the indicated key-value pairs as labels

                          (it can have additional labels as well).

                          See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector
                        type: object
                      tolerations:
                        description: >-
                          tolerations is a list of tolerations applied to the relevant kind of pods

                          See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info.

                          These are additional tolerations other than default ones.
                        items:
                          description: >-
                            The pod this Toleration is attached to tolerates any taint that matches

                            the triple <key,value,effect> using the matching operator <operator>.
                          properties:
                            effect:
                              description: >-
                                Effect indicates the taint effect to match. Empty means match all taint effects.

                                When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
                              type: string
                            key:
                              description: >-
                                Key is the taint key that the toleration applies to. Empty means match all taint keys.

                                If the key is empty, operator must be Exists; this combination means to match all values and all keys.
                              type: string
                            operator:
                              description: >-
                                Operator represents a key's relationship to the value.

                                Valid operators are Exists and Equal. Defaults to Equal.

                                Exists is equivalent to wildcard for value, so that a pod can

                                tolerate all taints of a particular category.
                              type: string
                            tolerationSeconds:
                              description: >-
                                TolerationSeconds represents the period of time the toleration (which must be

                                of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,

                                it is not set, which means tolerate the taint forever (do not evict). Zero and

                                negative values will be treated as 0 (evict immediately) by the system.
                              format: int64
                              type: integer
                            value:
                              description: >-
                                Value is the taint value the toleration matches to.

                                If the operator is Exists, the value should be empty, otherwise just a regular string.
                              type: string
                          type: object
                        type: array
                    type: object
                  replicas:
                    description: >-
                      replicas indicates how many replicas should be created for each KubeVirt infrastructure

                      component (like virt-api or virt-controller). Defaults to 2.

                      WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!
                    type: integer
                type: object
              monitorAccount:
                description: >-
                  The name of the Prometheus service account that needs read-access to KubeVirt endpoints

                  Defaults to prometheus-k8s
                type: string
              monitorNamespace:
                description: >-
                  The namespace Prometheus is deployed in

                  Defaults to openshift-monitor
                type: string
              productComponent:
                description: >-
                  Designate the apps.kubevirt.io/component label for KubeVirt components.

                  Useful if KubeVirt is included as part of a product.

                  If ProductComponent is not specified, the component label default value is kubevirt.
                type: string
              productName:
                description: >-
                  Designate the apps.kubevirt.io/part-of label for KubeVirt components.

                  Useful if KubeVirt is included as part of a product.

                  If ProductName is not specified, the part-of label will be omitted.
                type: string
              productVersion:
                description: >-
                  Designate the apps.kubevirt.io/version label for KubeVirt components.

                  Useful if KubeVirt is included as part of a product.

                  If ProductVersion is not specified, KubeVirt's version will be used.
                type: string
              serviceMonitorNamespace:
                description: >-
                  The namespace the service monitor will be deployed
                   When ServiceMonitorNamespace is set, then we'll install the service monitor object in that namespace
                  otherwise we will use the monitoring namespace.
                type: string
              synchronizationPort:
                description: Specify the port to listen on for VMI status synchronization traffic. Default is 9185
                type: string
              uninstallStrategy:
                description: >-
                  Specifies if kubevirt can be deleted if workloads are still present.

                  This is mainly a precaution to avoid accidental data loss
                type: string
              workloadUpdateStrategy:
                description: >-
                  WorkloadUpdateStrategy defines at the cluster level how to handle

                  automated workload updates
                properties:
                  batchEvictionInterval:
                    description: >-
                      BatchEvictionInterval Represents the interval to wait before issuing the next

                      batch of shutdowns


                      Defaults to 1 minute
                    type: string
                  batchEvictionSize:
                    description: >-
                      BatchEvictionSize Represents the number of VMIs that can be forced updated per

                      the BatchShutdownInteral interval


                      Defaults to 10
                    type: integer
                  workloadUpdateMethods:
                    description: >-
                      WorkloadUpdateMethods defines the methods that can be used to disrupt workloads

                      during automated workload updates.

                      When multiple methods are present, the least disruptive method takes

                      precedence over more disruptive methods. For example if both LiveMigrate and Shutdown

                      methods are listed, only VMs which are not live migratable will be restarted/shutdown


                      An empty list defaults to no automated workload updating
                    items:
                      type: string
                    type: array
                    x-kubernetes-list-type: atomic
                type: object
              workloads:
                description: selectors and tolerations that should apply to KubeVirt workloads
                properties:
                  nodePlacement:
                    description: >-
                      nodePlacement describes scheduling configuration for specific

                      KubeVirt components
                    properties:
                      affinity:
                        description: >-
                          affinity enables pod affinity/anti-affinity placement expanding the types of constraints

                          that can be expressed with nodeSelector.

                          affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector

                          See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity
                        properties:
                          nodeAffinity:
                            description: Describes node affinity scheduling rules for the pod.
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node matches the corresponding matchExpressions; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: >-
                                    An empty preferred scheduling term matches all objects with implicit weight 0

                                    (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
                                  properties:
                                    preference:
                                      description: A node selector term, associated with the corresponding weight.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    weight:
                                      description: Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - preference
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to an update), the system

                                  may or may not try to eventually evict the pod from its node.
                                properties:
                                  nodeSelectorTerms:
                                    description: Required. A list of node selector terms. The terms are ORed.
                                    items:
                                      description: >-
                                        A null or empty node selector term matches no objects. The requirements of

                                        them are ANDed.

                                        The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
                                      properties:
                                        matchExpressions:
                                          description: A list of node selector requirements by node's labels.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchFields:
                                          description: A list of node selector requirements by node's fields.
                                          items:
                                            description: >-
                                              A node selector requirement is a selector that contains values, a key, and an operator

                                              that relates the key and values.
                                            properties:
                                              key:
                                                description: The label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  Represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
                                                type: string
                                              values:
                                                description: >-
                                                  An array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. If the operator is Gt or Lt, the values

                                                  array must have a single element, which will be interpreted as an integer.

                                                  This array is replaced during a strategic merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    type: array
                                    x-kubernetes-list-type: atomic
                                required:
                                - nodeSelectorTerms
                                type: object
                                x-kubernetes-map-type: atomic
                            type: object
                          podAffinity:
                            description: Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                          podAntiAffinity:
                            description: Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
                            properties:
                              preferredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  The scheduler will prefer to schedule pods to nodes that satisfy

                                  the anti-affinity expressions specified by this field, but it may choose

                                  a node that violates one or more of the expressions. The node that is

                                  most preferred is the one with the greatest sum of weights, i.e.

                                  for each node that meets all of the scheduling requirements (resource

                                  request, requiredDuringScheduling anti-affinity expressions, etc.),

                                  compute a sum by iterating through the elements of this field and adding

                                  ""weight"" to the sum if the node has pods which matches the corresponding podAffinityTerm; the

                                  node(s) with the highest sum are the most preferred.
                                items:
                                  description: The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
                                  properties:
                                    podAffinityTerm:
                                      description: Required. A pod affinity term, associated with the corresponding weight.
                                      properties:
                                        labelSelector:
                                          description: >-
                                            A label query over a set of resources, in this case pods.

                                            If it's null, this PodAffinityTerm matches with no Pods.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        matchLabelKeys:
                                          description: >-
                                            MatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                            Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        mismatchLabelKeys:
                                          description: >-
                                            MismatchLabelKeys is a set of pod label keys to select which pods will

                                            be taken into consideration. The keys are used to lookup values from the

                                            incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                            to select the group of existing pods which pods will be taken into consideration

                                            for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                            pod labels will be ignored. The default value is empty.

                                            The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                            Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                            This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        namespaceSelector:
                                          description: >-
                                            A label query over the set of namespaces that the term applies to.

                                            The term is applied to the union of the namespaces selected by this field

                                            and the ones listed in the namespaces field.

                                            null selector and null or empty namespaces list means ""this pod's namespace"".

                                            An empty selector ({}) matches all namespaces.
                                          properties:
                                            matchExpressions:
                                              description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                              items:
                                                description: >-
                                                  A label selector requirement is a selector that contains values, a key, and an operator that

                                                  relates the key and values.
                                                properties:
                                                  key:
                                                    description: key is the label key that the selector applies to.
                                                    type: string
                                                  operator:
                                                    description: >-
                                                      operator represents a key's relationship to a set of values.

                                                      Valid operators are In, NotIn, Exists and DoesNotExist.
                                                    type: string
                                                  values:
                                                    description: >-
                                                      values is an array of string values. If the operator is In or NotIn,

                                                      the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                      the values array must be empty. This array is replaced during a strategic

                                                      merge patch.
                                                    items:
                                                      type: string
                                                    type: array
                                                    x-kubernetes-list-type: atomic
                                                required:
                                                - key
                                                - operator
                                                type: object
                                              type: array
                                              x-kubernetes-list-type: atomic
                                            matchLabels:
                                              additionalProperties:
                                                type: string
                                              description: >-
                                                matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                                map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                                operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                              type: object
                                          type: object
                                          x-kubernetes-map-type: atomic
                                        namespaces:
                                          description: >-
                                            namespaces specifies a static list of namespace names that the term applies to.

                                            The term is applied to the union of the namespaces listed in this field

                                            and the ones selected by namespaceSelector.

                                            null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                          items:
                                            type: string
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        topologyKey:
                                          description: >-
                                            This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                            the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                            whose value of the label with key topologyKey matches that of any node on which any of the

                                            selected pods is running.

                                            Empty topologyKey is not allowed.
                                          type: string
                                      required:
                                      - topologyKey
                                      type: object
                                    weight:
                                      description: >-
                                        weight associated with matching the corresponding podAffinityTerm,

                                        in the range 1-100.
                                      format: int32
                                      type: integer
                                  required:
                                  - podAffinityTerm
                                  - weight
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                              requiredDuringSchedulingIgnoredDuringExecution:
                                description: >-
                                  If the anti-affinity requirements specified by this field are not met at

                                  scheduling time, the pod will not be scheduled onto the node.

                                  If the anti-affinity requirements specified by this field cease to be met

                                  at some point during pod execution (e.g. due to a pod label update), the

                                  system may or may not try to eventually evict the pod from its node.

                                  When there are multiple elements, the lists of nodes corresponding to each

                                  podAffinityTerm are intersected, i.e. all terms must be satisfied.
                                items:
                                  description: >-
                                    Defines a set of pods (namely those matching the labelSelector

                                    relative to the given namespace(s)) that this pod should be

                                    co-located (affinity) or not co-located (anti-affinity) with,

                                    where co-located is defined as running on a node whose value of

                                    the label with key <topologyKey> matches that of any node on which

                                    a pod of the set of pods is running
                                  properties:
                                    labelSelector:
                                      description: >-
                                        A label query over a set of resources, in this case pods.

                                        If it's null, this PodAffinityTerm matches with no Pods.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    matchLabelKeys:
                                      description: >-
                                        MatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both matchLabelKeys and labelSelector.

                                        Also, matchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    mismatchLabelKeys:
                                      description: >-
                                        MismatchLabelKeys is a set of pod label keys to select which pods will

                                        be taken into consideration. The keys are used to lookup values from the

                                        incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)'

                                        to select the group of existing pods which pods will be taken into consideration

                                        for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming

                                        pod labels will be ignored. The default value is empty.

                                        The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.

                                        Also, mismatchLabelKeys cannot be set when labelSelector isn't set.

                                        This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    namespaceSelector:
                                      description: >-
                                        A label query over the set of namespaces that the term applies to.

                                        The term is applied to the union of the namespaces selected by this field

                                        and the ones listed in the namespaces field.

                                        null selector and null or empty namespaces list means ""this pod's namespace"".

                                        An empty selector ({}) matches all namespaces.
                                      properties:
                                        matchExpressions:
                                          description: matchExpressions is a list of label selector requirements. The requirements are ANDed.
                                          items:
                                            description: >-
                                              A label selector requirement is a selector that contains values, a key, and an operator that

                                              relates the key and values.
                                            properties:
                                              key:
                                                description: key is the label key that the selector applies to.
                                                type: string
                                              operator:
                                                description: >-
                                                  operator represents a key's relationship to a set of values.

                                                  Valid operators are In, NotIn, Exists and DoesNotExist.
                                                type: string
                                              values:
                                                description: >-
                                                  values is an array of string values. If the operator is In or NotIn,

                                                  the values array must be non-empty. If the operator is Exists or DoesNotExist,

                                                  the values array must be empty. This array is replaced during a strategic

                                                  merge patch.
                                                items:
                                                  type: string
                                                type: array
                                                x-kubernetes-list-type: atomic
                                            required:
                                            - key
                                            - operator
                                            type: object
                                          type: array
                                          x-kubernetes-list-type: atomic
                                        matchLabels:
                                          additionalProperties:
                                            type: string
                                          description: >-
                                            matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels

                                            map is equivalent to an element of matchExpressions, whose key field is ""key"", the

                                            operator is ""In"", and the values array contains only ""value"". The requirements are ANDed.
                                          type: object
                                      type: object
                                      x-kubernetes-map-type: atomic
                                    namespaces:
                                      description: >-
                                        namespaces specifies a static list of namespace names that the term applies to.

                                        The term is applied to the union of the namespaces listed in this field

                                        and the ones selected by namespaceSelector.

                                        null or empty namespaces list and null namespaceSelector means ""this pod's namespace"".
                                      items:
                                        type: string
                                      type: array
                                      x-kubernetes-list-type: atomic
                                    topologyKey:
                                      description: >-
                                        This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching

                                        the labelSelector in the specified namespaces, where co-located is defined as running on a node

                                        whose value of the label with key topologyKey matches that of any node on which any of the

                                        selected pods is running.

                                        Empty topologyKey is not allowed.
                                      type: string
                                  required:
                                  - topologyKey
                                  type: object
                                type: array
                                x-kubernetes-list-type: atomic
                            type: object
                        type: object
                      nodeSelector:
                        additionalProperties:
                          type: string
                        description: >-
                          nodeSelector is the node selector applied to the relevant kind of pods

                          It specifies a map of key-value pairs: for the pod to be eligible to run on a node,

                          the node must have each of the indicated key-value pairs as labels

                          (it can have additional labels as well).

                          See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector
                        type: object
                      tolerations:
                        description: >-
                          tolerations is a list of tolerations applied to the relevant kind of pods

                          See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info.

                          These are additional tolerations other than default ones.
                        items:
                          description: >-
                            The pod this Toleration is attached to tolerates any taint that matches

                            the triple <key,value,effect> using the matching operator <operator>.
                          properties:
                            effect:
                              description: >-
                                Effect indicates the taint effect to match. Empty means match all taint effects.

                                When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
                              type: string
                            key:
                              description: >-
                                Key is the taint key that the toleration applies to. Empty means match all taint keys.

                                If the key is empty, operator must be Exists; this combination means to match all values and all keys.
                              type: string
                            operator:
                              description: >-
                                Operator represents a key's relationship to the value.

                                Valid operators are Exists and Equal. Defaults to Equal.

                                Exists is equivalent to wildcard for value, so that a pod can

                                tolerate all taints of a particular category.
                              type: string
                            tolerationSeconds:
                              description: >-
                                TolerationSeconds represents the period of time the toleration (which must be

                                of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,

                                it is not set, which means tolerate the taint forever (do not evict). Zero and

                                negative values will be treated as 0 (evict immediately) by the system.
                              format: int64
                              type: integer
                            value:
                              description: >-
                                Value is the taint value the toleration matches to.

                                If the operator is Exists, the value should be empty, otherwise just a regular string.
                              type: string
                          type: object
                        type: array
                    type: object
                  replicas:
                    description: >-
                      replicas indicates how many replicas should be created for each KubeVirt infrastructure

                      component (like virt-api or virt-controller). Defaults to 2.

                      WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!
                    type: integer
                type: object
            type: object
          status:
            description: KubeVirtStatus represents information pertaining to a KubeVirt deployment.
            properties:
              conditions:
                items:
                  description: KubeVirtCondition represents a condition of a KubeVirt deployment
                  properties:
                    lastProbeTime:
                      format: date-time
                      nullable: true
                      type: string
                    lastTransitionTime:
                      format: date-time
                      nullable: true
                      type: string
                    message:
                      type: string
                    reason:
                      type: string
                    status:
                      type: string
                    type:
                      type: string
                  required:
                  - status
                  - type
                  type: object
                type: array
              defaultArchitecture:
                type: string
              generations:
                items:
                  description: GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made.
                  properties:
                    group:
                      description: group is the group of the thing you're tracking
                      type: string
                    hash:
                      description: hash is an optional field set for resources without generation that are content sensitive like secrets and configmaps
                      type: string
                    lastGeneration:
                      description: lastGeneration is the last generation of the workload controller involved
                      format: int64
                      type: integer
                    name:
                      description: name is the name of the thing you're tracking
                      type: string
                    namespace:
                      description: namespace is where the thing you're tracking is
                      type: string
                    resource:
                      description: resource is the resource type of the thing you're tracking
                      type: string
                  required:
                  - group
                  - lastGeneration
                  - name
                  - resource
                  type: object
                type: array
                x-kubernetes-list-type: atomic
              observedDeploymentConfig:
                type: string
              observedDeploymentID:
                type: string
              observedGeneration:
                format: int64
                type: integer
              observedKubeVirtRegistry:
                type: string
              observedKubeVirtVersion:
                type: string
              operatorVersion:
                type: string
              outdatedVirtualMachineInstanceWorkloads:
                type: integer
              phase:
                description: KubeVirtPhase is a label for the phase of a KubeVirt deployment at the current time.
                type: string
              synchronizationAddresses:
                items:
                  type: string
                type: array
                x-kubernetes-list-type: atomic
              targetDeploymentConfig:
                type: string
              targetDeploymentID:
                type: string
              targetKubeVirtRegistry:
                type: string
              targetKubeVirtVersion:
                type: string
            type: object
        required:
        - spec
        type: object
    served: true
    storage: false
    subresources:
      status: {}

";
        var type = GetTypeYaml(yaml, "KubeVirt");

        var specType = type.GetProperty("Spec").PropertyType;

        specType.Should().NotBeNull();
    }

    [Fact]
    public void TestRequiredNumber()
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
        - name: v1
          served: true
          storage: true
          schema:
            openAPIV3Schema:
              type: object
              required:
              - spec
              properties:
                spec:
                  type: object
                  description: Demo of string field with required and nullable combinations
                  required:
                    - reqNullable
                    - reqNonNull
                    - reqNullableDefault
                    - reqNonNullDefault
                  properties:
                    reqNullable:
                      type: number
                      nullable: true
                      description: required and may be null
                    reqNonNull:
                      type: number
                      nullable: false
                      description: required and must be non null
                    reqNullableDefault:
                      type: number
                      nullable: true
                      description: required and may be null
                      default: 1
                    reqNonNullDefault:
                      type: number
                      nullable: false
                      description: required and must be non null
                      default: 1

                    optNullable:
                      type: number
                      nullable: true
                      description: optional may be omitted or set to null
                    optNonNull:
                      type: number
                      nullable: false
                      description: optional may be omitted but if present must be non null
                    optNullableDefault:
                      type: number
                      nullable: true
                      description: optional may be omitted or set to null
                      default: 1
                    optNonNullDefault:
                      type: number
                      nullable: false
                      description: optional may be omitted but if present must be non null
                      default: 1
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");
        var specType = type.GetProperty("Spec").PropertyType;

        // reqNullable: required and may be null
        var reqNullable = specType.GetProperty("ReqNullable");
        reqNullable.PropertyType.Should().Be<Nullable<double>>();
        reqNullable.IsNullableReferenceType().Should().BeTrue();
        reqNullable.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeTrue();

        // reqNonNull: required and must be non null
        var reqNonNull = specType.GetProperty("ReqNonNull");
        reqNonNull.PropertyType.Should().Be<double>();
        reqNonNull.IsNullableReferenceType().Should().BeFalse();
        reqNonNull.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeTrue();

        // reqNullableDefault: optional and nullable with default
        var reqNullableDefault = specType.GetProperty("ReqNullableDefault");
        reqNullableDefault.PropertyType.Should().Be<Nullable<double>>();
        reqNullableDefault.IsNullableReferenceType().Should().BeTrue();
        reqNullableDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // reqNonNull: optional and non-null with default
        var reqNonNullDefault = specType.GetProperty("ReqNonNullDefault");
        reqNonNullDefault.PropertyType.Should().Be<Nullable<double>>();
        reqNonNullDefault.IsNullableReferenceType().Should().BeTrue();
        reqNonNullDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // Optional

        // optNullable: optional and nullable
        var optNullable = specType.GetProperty("OptNullable");
        optNullable.PropertyType.Should().Be<Nullable<double>>();
        optNullable.IsNullableReferenceType().Should().BeTrue();
        optNullable.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // optNonNull: optional but if present must be non-null
        var optNonNull = specType.GetProperty("OptNonNull");
        optNonNull.PropertyType.Should().Be<Nullable<double>>();
        optNonNull.IsNullableReferenceType().Should().BeTrue();
        optNonNull.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // optNullable: optional and nullable with default
        var optNullableDefault = specType.GetProperty("OptNullableDefault");
        optNullableDefault.PropertyType.Should().Be<Nullable<double>>();
        optNullableDefault.IsNullableReferenceType().Should().BeTrue();
        optNullableDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // optNonNull: optional but if present must be non-null with default
        var optNonNullDefault = specType.GetProperty("OptNonNullDefault");
        optNonNullDefault.PropertyType.Should().Be<Nullable<double>>();
        optNonNullDefault.IsNullableReferenceType().Should().BeTrue();
        optNonNullDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();
    }

    [Fact]
    public void TestRequiredString()
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
        - name: v1
          served: true
          storage: true
          schema:
            openAPIV3Schema:
              type: object
              required:
              - spec
              properties:
                spec:
                  type: object
                  description: Demo of string field with required and nullable combinations
                  required:
                    - reqNullable
                    - reqNonNull
                    - reqNullableDefault
                    - reqNonNullDefault
                  properties:
                    reqNullable:
                      type: string
                      nullable: true
                      description: required and may be null
                    reqNonNull:
                      type: string
                      nullable: false
                      description: required and must be non null

                    reqNullableDefault:
                      type: string
                      nullable: true
                      description: required and may be null
                      default: '1'
                    reqNonNullDefault:
                      type: string
                      nullable: false
                      description: required and must be non null
                      default: '1'

                    optNullable:
                      type: string
                      nullable: true
                      description: optional may be omitted or set to null
                    optNonNull:
                      type: string
                      nullable: false
                      description: optional may be omitted but if present must be non null

                    optNullableDefault:
                      type: string
                      nullable: true
                      description: optional may be omitted or set to null
                      default: '1'

                    optNonNullDefault:
                      type: string
                      nullable: false
                      description: optional may be omitted but if present must be non null
                      default: '1'
    ";
        var code = GetCode(yaml);
        var type = GetTypeYaml(yaml, "Test");
        var specType = type.GetProperty("Spec").PropertyType;

        // reqNullable: required and may be null
        // true true false
        var reqNullable = specType.GetProperty("ReqNullable");
        reqNullable.PropertyType.Should().Be<string>();
        reqNullable.IsNullableReferenceType().Should().BeTrue();
        reqNullable.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeTrue();

        // reqNonNull: required and must be non null
        // true false false
        var reqNonNull = specType.GetProperty("ReqNonNull");
        reqNonNull.PropertyType.Should().Be<string>();
        reqNonNull.IsNullableReferenceType().Should().BeFalse();
        reqNonNull.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeTrue();

        // reqNullableDefault: optional and nullable with default
        // true true true
        var reqNullableDefault = specType.GetProperty("ReqNullableDefault");
        reqNullableDefault.PropertyType.Should().Be<string>();
        reqNullableDefault.IsNullableReferenceType().Should().BeTrue();
        reqNullableDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // reqNonNull: optional and non-null with default
        // true false true
        var reqNonNullDefault = specType.GetProperty("ReqNonNullDefault");
        reqNonNullDefault.PropertyType.Should().Be<string>();
        reqNonNullDefault.IsNullableReferenceType().Should().BeTrue();
        reqNonNullDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // Optional

        // optNullable: optional and nullable
        // false true false
        var optNullable = specType.GetProperty("OptNullable");
        optNullable.PropertyType.Should().Be<string>();
        optNullable.IsNullableReferenceType().Should().BeTrue();
        optNullable.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // optNonNull: optional but if present must be non-null
        // false false false
        var optNonNull = specType.GetProperty("OptNonNull");
        optNonNull.PropertyType.Should().Be<string>();
        optNonNull.IsNullableReferenceType().Should().BeTrue();
        optNonNull.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // optNullable: optional and nullable with default
        // false true true
        var optNullableDefault = specType.GetProperty("OptNullableDefault");
        optNullableDefault.PropertyType.Should().Be<string>();
        optNullableDefault.IsNullableReferenceType().Should().BeTrue();
        optNullableDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();

        // optNonNull: optional but if present must be non-null with default
        // false false true
        var optNonNullDefault = specType.GetProperty("OptNonNullDefault");
        optNonNullDefault.PropertyType.Should().Be<string>();
        optNonNullDefault.IsNullableReferenceType().Should().BeTrue();
        optNonNullDefault.IsDefined(typeof(RequiredMemberAttribute), inherit: false).Should().BeFalse();
    }
}

public static class ReflectionHelpers
{
    public static bool IsNullableReferenceType(this PropertyInfo property)
    {
        // If it's a value type, only Nullable<T> counts
        if (property.PropertyType.IsValueType)
            return Nullable.GetUnderlyingType(property.PropertyType) != null;

        var nullabilityContext = new NullabilityInfoContext();
        var nullableStringInfo = nullabilityContext.Create(property);

        return nullableStringInfo.ReadState == NullabilityState.Nullable;
    }
}