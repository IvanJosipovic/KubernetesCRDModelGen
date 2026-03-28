using k8s;
using k8s.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Text.Json;

namespace KubernetesCRDModelGen.Tests;

public partial class GeneratorTests
{
    protected const string Namespace = "KubernetesCRDModelGen.Tests.Models";

    protected static IGenerator GetGenerator()
    {
        return new Generator();
    }

    protected static Type? GetTypeYaml(string yaml, string kind)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetType((V1CustomResourceDefinition)crd[0], kind);
    }

    protected static Type[]? GetTypeYaml(string yaml, string kind, string kindList)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetType((V1CustomResourceDefinition)crd[0], kind, kindList);
    }

    protected static Type? GetType(V1CustomResourceDefinition crd, string kind)
    {
        var result = GetGenerator().GenerateAssembly(crd, Namespace);

        var types = result.Assembly!.DefinedTypes.Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(KubernetesEntityAttribute) && y.NamedArguments.Any(z => z.MemberName == "Kind" && z.TypedValue.Value.Equals(kind))));

        return types.First();
    }

    protected static Type[]? GetType(V1CustomResourceDefinition crd, string kind, string kindList)
    {
        var result = GetGenerator().GenerateAssembly(crd, Namespace);

        return [.. result.Assembly!.DefinedTypes.Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(KubernetesEntityAttribute) && y.NamedArguments.Any(z => z.MemberName == "Kind" && new[] { kind, kindList }.Contains(z.TypedValue.Value))))];
    }

    protected static string GetCode(string yaml)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GetCode((V1CustomResourceDefinition)crd[0]);
    }

    protected static string GetCode(V1CustomResourceDefinition crd)
    {
        return GetGenerator().GenerateCode(crd, Namespace);
    }

    protected static GeneratedAssemblyResult GenerateAssembly(string yaml, string? @namespace = null)
    {
        var crd = KubernetesYaml.LoadAllFromString(yaml);

        return GenerateAssembly((V1CustomResourceDefinition)crd[0], @namespace);
    }

    protected static GeneratedAssemblyResult GenerateAssembly(V1CustomResourceDefinition crd, string? @namespace = null)
    {
        return GetGenerator().GenerateAssembly(crd, @namespace ?? Namespace);
    }

    protected static MemberInfo[] GetMembers(Type type)
    {
        if (type != null && Nullable.GetUnderlyingType(type) != null)
        {
            type = Nullable.GetUnderlyingType(type);
        }

        return type.GetMembers(BindingFlags.Public | BindingFlags.Static);
    }

    private static readonly MethodInfo DeserializeJsonMethod = typeof(KubernetesJson).GetMethod(nameof(KubernetesJson.Deserialize), BindingFlags.Static | BindingFlags.Public, [typeof(string), typeof(JsonSerializerOptions)]);

    protected static object DeserializeKubeJson(string json, Type type)
    {
        var method = DeserializeJsonMethod.MakeGenericMethod(type);

        return method.Invoke(null, [json, null]);
    }

    private static readonly MethodInfo DeserializeYamlMethod = typeof(KubernetesYaml).GetMethod(nameof(KubernetesYaml.Deserialize), BindingFlags.Static | BindingFlags.Public, [typeof(string), typeof(bool)]);

    protected static object DeserializeKubeYaml(string yaml, Type type)
    {
        var method = DeserializeYamlMethod.MakeGenericMethod(type);

        return method.Invoke(null, [yaml, false]);
    }
}

public static class ReflectionHelpers
{
    public static bool IsNullableReferenceType(this PropertyInfo property)
    {
        if (property.PropertyType.IsValueType)
        {
            return Nullable.GetUnderlyingType(property.PropertyType) != null;
        }

        var nullabilityContext = new NullabilityInfoContext();
        var nullableStringInfo = nullabilityContext.Create(property);

        return nullableStringInfo.ReadState == NullabilityState.Nullable;
    }
}
