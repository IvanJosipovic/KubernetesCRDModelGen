using Microsoft.OpenApi;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace KubernetesCRDModelGen.Base;

internal sealed class OpenApiSchemaModelBuilder
{
    private const string KubeEmbeddedType = "x-kubernetes-embedded-type";
    private const string KubeEmbeddedResource = "x-kubernetes-embedded-resource";
    private const string KubePreserveUnknownFields = "x-kubernetes-preserve-unknown-fields";
    private const string KubeIntOrString = "x-kubernetes-int-or-string";
    private static readonly GeneratedTypeReference StringType = Named("string");
    private static readonly GeneratedTypeReference ByteArrayType = Named("byte[]");
    private static readonly GeneratedTypeReference ObjectType = Named("object");
    private static readonly GeneratedTypeReference FloatType = Named("float");
    private static readonly GeneratedTypeReference DoubleType = Named("double");
    private static readonly GeneratedTypeReference BoolType = Named("bool");
    private static readonly GeneratedTypeReference IntType = Named("int");
    private static readonly GeneratedTypeReference LongType = Named("long");
    private static readonly GeneratedTypeReference DateTimeType = Named(nameof(DateTime));
    private static readonly GeneratedTypeReference TimeSpanType = Named(nameof(TimeSpan));
    private static readonly GeneratedTypeReference JsonNodeType = Named(nameof(JsonNode));
    private static readonly GeneratedTypeReference JsonElementType = Named(nameof(JsonElement));
    private static readonly GeneratedTypeReference IntOrStringType = Named("IntOrString");
    private static readonly GeneratedTypeReference V1ObjectMetaType = Named("V1ObjectMeta");
    private static readonly GeneratedTypeReference V1ListMetaType = Named("V1ListMeta");

    public bool EnumSupport { get; set; } = true;

    public GeneratedCompilationUnitModel BuildCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind, bool isObsolete = false, string? obsoleteMessage = null)
        => new(@namespace, group, BuildTypes(schema, kind, version, group, plural, listKind, isObsolete, obsoleteMessage));

    public GeneratedCompilationUnitModel BuildCompilationUnitWithWarnings(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind, Action<string>? reportWarning = null, bool isObsolete = false, string? obsoleteMessage = null)
        => new(@namespace, group, BuildTypesWithWarnings(schema, kind, reportWarning, version, group, plural, listKind, isObsolete, obsoleteMessage));

    public IReadOnlyList<GeneratedTypeModel> BuildTypes(IOpenApiSchema schema, string kind, string? version = null, string? group = null, string? plural = null, string? listKind = null, bool isObsolete = false, string? obsoleteMessage = null)
        => BuildTypes(schema, kind, new HashSet<string>(StringComparer.Ordinal), false, reportWarning: null, version, group, plural, listKind, isObsolete, obsoleteMessage);

    public IReadOnlyList<GeneratedTypeModel> BuildTypesWithWarnings(IOpenApiSchema schema, string kind, Action<string>? reportWarning = null, string? version = null, string? group = null, string? plural = null, string? listKind = null, bool isObsolete = false, string? obsoleteMessage = null)
        => BuildTypes(schema, kind, new HashSet<string>(StringComparer.Ordinal), false, reportWarning, version, group, plural, listKind, isObsolete, obsoleteMessage);

    private IReadOnlyList<GeneratedTypeModel> BuildTypes(IOpenApiSchema schema, string kind, HashSet<string> typeNames, bool nameReserved, Action<string>? reportWarning = null, string? version = null, string? group = null, string? plural = null, string? listKind = null, bool isObsolete = false, string? obsoleteMessage = null)
    {
        var isRoot = version != null && group != null && plural != null;
        listKind ??= kind + "List";

        var types = new List<GeneratedTypeModel>();
        var propertyNames = new HashSet<string>(StringComparer.Ordinal);
        var className = CodeGenerationUtilities.CleanIdentifier((isRoot ? version : string.Empty) + " " + kind);

        if (string.IsNullOrEmpty(className))
        {
            return [];
        }

        if (!nameReserved && !typeNames.Add(className!))
        {
            return [];
        }
        var classNameValue = className!;

        var baseTypes = new List<GeneratedTypeReference>();
        var fields = new List<GeneratedFieldModel>();
        var properties = new List<GeneratedPropertyModel>();

        if (isRoot)
        {
            baseTypes.Add(Generic("IKubernetesObject", V1ObjectMetaType));

            var classListName = CodeGenerationUtilities.CleanIdentifier(version + listKind);
            if (string.IsNullOrEmpty(classListName) || !typeNames.Add(classListName!))
            {
                return [];
            }
            var classListNameValue = classListName!;

            var kubeApiVersion = new GeneratedFieldModel("KubeApiVersion", StringType, version!);
            var kubeKind = new GeneratedFieldModel("KubeKind", StringType, kind);
            var kubeListKind = new GeneratedFieldModel("KubeKind", StringType, listKind!);
            var kubeGroup = new GeneratedFieldModel("KubeGroup", StringType, group!);
            var kubePluralName = new GeneratedFieldModel("KubePluralName", StringType, plural!);

            fields.AddRange([kubeApiVersion, kubeKind, kubeGroup, kubePluralName]);
            properties.AddRange([
                new GeneratedPropertyModel("ApiVersion", "apiVersion", StringType, "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources", false, group + "/" + version),
                new GeneratedPropertyModel("Kind", "kind", StringType, "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", false, kind),
                new GeneratedPropertyModel("Metadata", "metadata", V1ObjectMetaType, "Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata", false)
            ]);

            types.Add(new GeneratedClassModel(
                classListNameValue,
                schema.Description,
                true,
                [Generic("IKubernetesObject", V1ListMetaType), Generic("IItems", Named(classNameValue))],
                [kubeApiVersion, kubeListKind, kubeGroup, kubePluralName],
                [
                    new GeneratedPropertyModel("ApiVersion", "apiVersion", StringType, "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources", false, group + "/" + version),
                    new GeneratedPropertyModel("Kind", "kind", StringType, "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", false, listKind),
                    new GeneratedPropertyModel("Metadata", "metadata", V1ListMetaType, "ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}."),
                    new GeneratedPropertyModel("Items", "items", Generic("IList", Named(classNameValue)), $"List of {classNameValue} objects.")
                ],
                isObsolete,
                obsoleteMessage));
        }

        if (schema.Extensions != null &&
            schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var preserve) &&
            preserve is JsonNodeExtension preserveNode &&
            preserveNode.Node.GetValueKind() == JsonValueKind.True)
        {
            properties.Add(new GeneratedPropertyModel("ExtensionData", "ExtensionData", Generic("IDictionary", StringType, JsonElementType), null, true, null, false, true));
            propertyNames.Add("ExtensionData");
        }

        var isEmbeddedType = IsTrueExtension(schema.Extensions, KubeEmbeddedType)
            || IsTrueExtension(schema.Extensions, KubeEmbeddedResource);
        if (isEmbeddedType && !isRoot)
        {
            AddEmbeddedResourceProperties(properties, propertyNames);
        }

        if (schema.Properties != null)
        {
            HashSet<string>? requiredNames = null;
            if (schema.Required is { Count: > 0 })
            {
                requiredNames = new HashSet<string>(schema.Required, StringComparer.Ordinal);
            }

            foreach (var property in schema.Properties)
            {
                if ((isRoot || isEmbeddedType) && (property.Key == "apiVersion" || property.Key == "kind" || property.Key == "metadata"))
                {
                    continue;
                }

                var type = ResolveType(property.Value, types, typeNames, classNameValue, property.Key, reportWarning, isObsolete, obsoleteMessage);
                var isRequired = requiredNames?.Contains(property.Key) == true;
                var isNullable = property.Value.Type.HasValue && property.Value.Type.Value.HasFlag(JsonSchemaType.Null);
                var hasDefault = property.Value.Default != null;
                var resultNullable =
                    (isRequired && isNullable && !hasDefault)
                    || (isRequired && isNullable && hasDefault)
                    || (isRequired && !isNullable && hasDefault)
                    || (!isRequired && isNullable && !hasDefault)
                    || (!isRequired && !isNullable && !hasDefault)
                    || (!isRequired && isNullable && hasDefault)
                    || (!isRequired && !isNullable && hasDefault);

                var resultRequired =
                    (isRequired && isNullable && !hasDefault)
                    || (isRequired && !isNullable && !hasDefault);

                if (isRoot && property.Key == "spec")
                {
                    baseTypes.Add(Generic("ISpec", resultNullable ? Nullable(type) : type));
                }

                if (isRoot && property.Key == "status")
                {
                    baseTypes.Add(Generic("IStatus", resultNullable ? Nullable(type) : type));
                }

                var generatedProperty = CreatePropertyModel(type, property.Key, property.Value.Description, resultNullable, resultRequired);
                var count = 1;
                while (!propertyNames.Add(generatedProperty.Name))
                {
                    generatedProperty = CreatePropertyModel(type, property.Key + count++, property.Value.Description, resultNullable, resultRequired);
                }

                properties.Add(generatedProperty);
            }
        }

        types.Add(new GeneratedClassModel(classNameValue, schema.Description, isRoot, baseTypes, fields, properties, isObsolete, obsoleteMessage));
        return types;
    }

    private static GeneratedPropertyModel CreatePropertyModel(GeneratedTypeReference type, string propertyName, string? description, bool isNullable, bool isRequired)
    {
        var identifier = CodeGenerationUtilities.CleanIdentifier(propertyName) ?? propertyName;
        return new GeneratedPropertyModel(identifier, propertyName, type, description, isNullable, null, isRequired);
    }

    private static void AddEmbeddedResourceProperties(List<GeneratedPropertyModel> properties, HashSet<string> propertyNames)
    {
        AddPropertyIfMissing(
            properties,
            propertyNames,
            new GeneratedPropertyModel("ApiVersion", "apiVersion", StringType, "APIVersion defines the versioned schema of this representation of an object.", true));
        AddPropertyIfMissing(
            properties,
            propertyNames,
            new GeneratedPropertyModel("Kind", "kind", StringType, "Kind is a string value representing the REST resource this object represents.", true));
        AddPropertyIfMissing(
            properties,
            propertyNames,
            new GeneratedPropertyModel("Metadata", "metadata", V1ObjectMetaType, "Standard object's metadata.", true));
    }

    private static void AddPropertyIfMissing(List<GeneratedPropertyModel> properties, HashSet<string> propertyNames, GeneratedPropertyModel property)
    {
        if (!propertyNames.Add(property.Name))
        {
            return;
        }

        properties.Add(property);
    }

    private GeneratedTypeReference ResolveType(IOpenApiSchema schema, List<GeneratedTypeModel> types, HashSet<string> typeNames, string parentClassName, string propertyName, Action<string>? reportWarning = null, bool isObsolete = false, string? obsoleteMessage = null)
    {
        if (schema.Extensions != null &&
            schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var preserveUnknownFields) &&
            preserveUnknownFields is JsonNodeExtension preserveUnknownFieldsNode &&
            preserveUnknownFieldsNode.Node.GetValueKind() == JsonValueKind.True)
        {
            return JsonNodeType;
        }

        if (schema.Extensions != null &&
            schema.Extensions.TryGetValue(KubeIntOrString, out var intOrString) &&
            intOrString is JsonNodeExtension intOrStringNode &&
            intOrStringNode.Node.GetValueKind() == JsonValueKind.True)
        {
            return IntOrStringType;
        }

        switch (schema.Type)
        {
            case JsonSchemaType.Null | JsonSchemaType.Object:
            case JsonSchemaType.Object:
                if (schema.AdditionalProperties != null)
                {
                    return Generic("IDictionary", StringType, ResolveType(schema.AdditionalProperties, types, typeNames, parentClassName, propertyName, reportWarning, isObsolete, obsoleteMessage));
                }

                var nestedClassName = GetUniqueTypeName(parentClassName + " " + propertyName, typeNames);
                if (nestedClassName is null)
                {
                    return ObjectType;
                }

                types.AddRange(BuildTypes(schema, nestedClassName, typeNames, true, reportWarning, isObsolete: isObsolete, obsoleteMessage: obsoleteMessage));
                return Named(nestedClassName);

            case JsonSchemaType.Null | JsonSchemaType.String:
            case JsonSchemaType.String:
                return EnumSupport && HasStringEnumValues(schema.Enum)
                    ? BuildEnum(schema, types, typeNames, parentClassName, propertyName, isObsolete, obsoleteMessage)
                    : ResolveStringType(schema.Format);

            case JsonSchemaType.Null | JsonSchemaType.Number:
            case JsonSchemaType.Number:
                return schema.Format == "float" ? FloatType : DoubleType;

            case JsonSchemaType.Null | JsonSchemaType.Boolean:
            case JsonSchemaType.Boolean:
                return BoolType;

            case JsonSchemaType.Null | JsonSchemaType.Integer:
            case JsonSchemaType.Integer:
                return ResolveIntegerType(schema.Format, propertyName, reportWarning);

            case JsonSchemaType.Null | JsonSchemaType.Array:
            case JsonSchemaType.Array:
                if (EnumSupport && HasStringEnumValues(schema.Enum))
                {
                    return Generic("IList", BuildEnum(schema, types, typeNames, parentClassName, propertyName, isObsolete, obsoleteMessage));
                }

                if (schema.Items is null)
                {
                    return Generic("IList", ObjectType);
                }

                return Generic("IList", ResolveType(schema.Items, types, typeNames, parentClassName, propertyName, reportWarning, isObsolete, obsoleteMessage));

            default:
                throw new Exception("Unsupported Type: " + JsonSerializer.Serialize(schema, CodeGeneratorSourceGenerationContext.Default.IOpenApiSchema));
        }
    }

    private GeneratedTypeReference BuildEnum(IOpenApiSchema schema, List<GeneratedTypeModel> types, HashSet<string> typeNames, string parentClassName, string propertyName, bool isObsolete = false, string? obsoleteMessage = null)
    {
        var enumName = GetUniqueTypeName(parentClassName + " " + propertyName + "Enum", typeNames);
        if (enumName is null)
        {
            return StringType;
        }
        var enumNameValue = enumName;

        var memberNames = new HashSet<string>(StringComparer.Ordinal);
        var enumValues = schema.Enum!;
        var members = new List<GeneratedEnumMemberModel>(enumValues.Count);

        for (var i = 0; i < enumValues.Count; i++)
        {
            var option = enumValues[i];
            if (option.GetValueKind() != JsonValueKind.String)
            {
                continue;
            }

            var value = option.GetValue<string>()!;
            var identifier = CodeGenerationUtilities.CleanIdentifier(value);
            var baseIdentifier = identifier;

            if (string.IsNullOrEmpty(identifier))
            {
                identifier = "Option" + i;
                baseIdentifier = identifier;
            }

            var count = 1;
            while (!memberNames.Add(identifier!))
            {
                identifier = baseIdentifier + count++;
            }

            members.Add(new GeneratedEnumMemberModel(identifier!, value, null));
        }

        types.Add(new GeneratedEnumModel(enumNameValue, schema.Description, members, isObsolete, obsoleteMessage));
        return Named(enumNameValue);
    }

    private static GeneratedTypeReference ResolveStringType(string? format)
        => format switch
        {
            "binary" => ByteArrayType,
            "byte" => ByteArrayType,
            "date" => DateTimeType,
            "date-time" => DateTimeType,
            "duration" => TimeSpanType,
            _ => StringType
        };

    private static GeneratedTypeReference ResolveIntegerType(string? format, string propertyName, Action<string>? reportWarning)
    {
        switch (format)
        {
            case null:
            case "":
            case "int32":
                return IntType;
            case "int64":
                return LongType;
            default:
                reportWarning?.Invoke($"Unsupported integer format '{format}' on property '{propertyName}'. Falling back to int.");
                return IntType;
        }
    }

    private static bool IsTrueExtension(IDictionary<string, IOpenApiExtension>? extensions, string extensionName)
        => extensions != null
           && extensions.TryGetValue(extensionName, out var extension)
           && extension is JsonNodeExtension nodeExtension
           && nodeExtension.Node.GetValueKind() == JsonValueKind.True;

    private static string? GetUniqueTypeName(string candidate, HashSet<string> typeNames)
    {
        var baseName = CodeGenerationUtilities.CleanIdentifier(candidate);
        if (string.IsNullOrEmpty(baseName))
        {
            return null;
        }

        var baseNameValue = baseName!;
        var uniqueName = baseNameValue;
        var count = 1;
        while (!typeNames.Add(uniqueName))
        {
            uniqueName = baseNameValue + count++;
        }

        return uniqueName;
    }

    private static GeneratedNamedTypeReference Named(string name)
        => new(name);

    private static GeneratedGenericTypeReference Generic(string name, GeneratedTypeReference typeArgument)
        => new(name, [typeArgument]);

    private static GeneratedGenericTypeReference Generic(string name, GeneratedTypeReference left, GeneratedTypeReference right)
        => new(name, [left, right]);

    private static GeneratedNullableTypeReference Nullable(GeneratedTypeReference type)
        => new(type);

    private static bool HasStringEnumValues(IList<JsonNode>? values)
    {
        if (values is null || values.Count == 0)
        {
            return false;
        }

        for (var i = 0; i < values.Count; i++)
        {
            var value = values[i];
            if (value is null || value.GetValueKind() != JsonValueKind.String || string.IsNullOrEmpty(value.GetValue<string>()))
            {
                return false;
            }
        }

        return true;
    }

}

[JsonSerializable(typeof(IOpenApiSchema))]
[ExcludeFromCodeCoverage]
internal partial class CodeGeneratorSourceGenerationContext : JsonSerializerContext
{
}
