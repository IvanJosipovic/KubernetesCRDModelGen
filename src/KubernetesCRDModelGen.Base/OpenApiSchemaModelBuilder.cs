using Microsoft.OpenApi;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Base;

internal sealed class OpenApiSchemaModelBuilder
{
    private const string KubePreserveUnknownFields = "x-kubernetes-preserve-unknown-fields";
    private const string KubeIntOrString = "x-kubernetes-int-or-string";

    public bool EnumSupport { get; set; } = true;

    public GeneratedCompilationUnitModel BuildCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind)
        => new(@namespace, group, BuildTypes(schema, kind, version, group, plural, listKind));

    public IReadOnlyList<GeneratedTypeModel> BuildTypes(IOpenApiSchema schema, string kind, string? version = null, string? group = null, string? plural = null, string? listKind = null)
        => BuildTypes(schema, kind, new HashSet<string>(StringComparer.Ordinal), version, group, plural, listKind);

    private IReadOnlyList<GeneratedTypeModel> BuildTypes(IOpenApiSchema schema, string kind, HashSet<string> typeNames, string? version = null, string? group = null, string? plural = null, string? listKind = null)
    {
        var isRoot = version != null && group != null && plural != null;
        listKind ??= kind + "List";

        var types = new List<GeneratedTypeModel>();
        var propertyNames = new HashSet<string>(StringComparer.Ordinal);
        var className = CodeGenerationUtilities.CleanIdentifier((isRoot ? version : string.Empty) + " " + kind);

        if (string.IsNullOrEmpty(className) || !typeNames.Add(className!))
        {
            return [];
        }
        var classNameValue = className!;

        var baseTypes = new List<string>();
        var fields = new List<GeneratedFieldModel>();
        var properties = new List<GeneratedPropertyModel>();

        if (isRoot)
        {
            baseTypes.Add("IKubernetesObject<V1ObjectMeta>");

            var classListName = CodeGenerationUtilities.CleanIdentifier(version + listKind);
            if (string.IsNullOrEmpty(classListName) || !typeNames.Add(classListName!))
            {
                return [];
            }
            var classListNameValue = classListName!;

            var kubeApiVersion = new GeneratedFieldModel("KubeApiVersion", "string", version!);
            var kubeKind = new GeneratedFieldModel("KubeKind", "string", kind);
            var kubeListKind = new GeneratedFieldModel("KubeKind", "string", listKind!);
            var kubeGroup = new GeneratedFieldModel("KubeGroup", "string", group!);
            var kubePluralName = new GeneratedFieldModel("KubePluralName", "string", plural!);

            fields.AddRange([kubeApiVersion, kubeKind, kubeGroup, kubePluralName]);
            properties.AddRange([
                new GeneratedPropertyModel("ApiVersion", "apiVersion", "string", "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources", false, group + "/" + version),
                new GeneratedPropertyModel("Kind", "kind", "string", "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", false, kind),
                new GeneratedPropertyModel("Metadata", "metadata", "V1ObjectMeta", "Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata", false)
            ]);

            types.Add(new GeneratedClassModel(
                classListNameValue,
                schema.Description,
                true,
                ["IKubernetesObject<V1ListMeta>", $"IItems<{classNameValue}>"],
                [kubeApiVersion, kubeListKind, kubeGroup, kubePluralName],
                [
                    new GeneratedPropertyModel("ApiVersion", "apiVersion", "string", "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources", false, group + "/" + version),
                    new GeneratedPropertyModel("Kind", "kind", "string", "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", false, listKind),
                    new GeneratedPropertyModel("Metadata", "metadata", "V1ListMeta", "ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}."),
                    new GeneratedPropertyModel("Items", "items", $"IList<{classNameValue}>", $"List of {classNameValue} objects.")
                ]));
        }

        if (schema.Extensions != null &&
            schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var preserve) &&
            preserve is JsonNodeExtension preserveNode &&
            preserveNode.Node.GetValueKind() == JsonValueKind.True)
        {
            properties.Add(new GeneratedPropertyModel("ExtensionData", "ExtensionData", "IDictionary<string, JsonElement>", null, true, null, false, true));
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
                if (isRoot && (property.Key == "apiVersion" || property.Key == "kind" || property.Key == "metadata"))
                {
                    continue;
                }

                var typeName = ResolveType(property.Value, types, typeNames, classNameValue, property.Key);
                var isRequired = requiredNames?.Contains(property.Key) == true;
                var isNullable = property.Value.Type.HasValue && property.Value.Type.Value.HasFlag(JsonSchemaType.Null);
                var hasDefault = property.Value.Default != null;
                var defaultValue = GetDefaultValue(property.Value.Default);

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
                    baseTypes.Add(resultNullable ? $"ISpec<{typeName}?>" : $"ISpec<{typeName}>");
                }

                if (isRoot && property.Key == "status")
                {
                    baseTypes.Add(resultNullable ? $"IStatus<{typeName}?>" : $"IStatus<{typeName}>");
                }

                var generatedProperty = CreatePropertyModel(typeName, property.Key, property.Value.Description, resultNullable, resultRequired, defaultValue);
                var count = 1;
                while (!propertyNames.Add(generatedProperty.Name))
                {
                    generatedProperty = CreatePropertyModel(typeName, property.Key + count++, property.Value.Description, resultNullable, resultRequired, defaultValue);
                }

                properties.Add(generatedProperty);
            }
        }

        types.Add(new GeneratedClassModel(classNameValue, schema.Description, isRoot, baseTypes, fields, properties));
        return types;
    }

    private static GeneratedPropertyModel CreatePropertyModel(string typeName, string propertyName, string? description, bool isNullable, bool isRequired, string? defaultValue)
    {
        var identifier = CodeGenerationUtilities.CleanIdentifier(propertyName) ?? propertyName;
        return new GeneratedPropertyModel(identifier, propertyName, typeName, description, isNullable, defaultValue, isRequired);
    }

    private string ResolveType(IOpenApiSchema schema, List<GeneratedTypeModel> types, HashSet<string> typeNames, string parentClassName, string propertyName)
    {
        if (schema.Extensions != null &&
            schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var preserveUnknownFields) &&
            preserveUnknownFields is JsonNodeExtension preserveUnknownFieldsNode &&
            preserveUnknownFieldsNode.Node.GetValueKind() == JsonValueKind.True)
        {
            return nameof(JsonNode);
        }

        if (schema.Extensions != null &&
            schema.Extensions.TryGetValue(KubeIntOrString, out var intOrString) &&
            intOrString is JsonNodeExtension intOrStringNode &&
            intOrStringNode.Node.GetValueKind() == JsonValueKind.True)
        {
            return "IntOrString";
        }

        switch (schema.Type)
        {
            case JsonSchemaType.Null | JsonSchemaType.Object:
            case JsonSchemaType.Object:
                if (schema.AdditionalProperties != null)
                {
                    return $"IDictionary<string, {ResolveType(schema.AdditionalProperties, types, typeNames, parentClassName, propertyName)}>";
                }

                var nestedClassName = CodeGenerationUtilities.CleanIdentifier(parentClassName + " " + propertyName);
                if (string.IsNullOrEmpty(nestedClassName))
                {
                    return "object";
                }

                types.AddRange(BuildTypes(schema, nestedClassName!, typeNames));
                return nestedClassName!;

            case JsonSchemaType.Null | JsonSchemaType.String:
            case JsonSchemaType.String:
                return EnumSupport && HasStringEnumValues(schema.Enum)
                    ? BuildEnum(schema, types, typeNames, parentClassName, propertyName)
                    : "string";

            case JsonSchemaType.Null | JsonSchemaType.Number:
            case JsonSchemaType.Number:
                return "double";

            case JsonSchemaType.Null | JsonSchemaType.Boolean:
            case JsonSchemaType.Boolean:
                return "bool";

            case JsonSchemaType.Null | JsonSchemaType.Integer:
            case JsonSchemaType.Integer:
                return schema.Format == "int64" ? "long" : "int";

            case JsonSchemaType.Null | JsonSchemaType.Array:
            case JsonSchemaType.Array:
                if (EnumSupport && HasStringEnumValues(schema.Enum))
                {
                    return $"IList<{BuildEnum(schema, types, typeNames, parentClassName, propertyName)}>";
                }

                if (schema.Items is null)
                {
                    return "IList<object>";
                }

                return $"IList<{ResolveType(schema.Items, types, typeNames, parentClassName, propertyName)}>";

            default:
                throw new Exception("Unsupported Type: " + JsonSerializer.Serialize(schema, CodeGeneratorSourceGenerationContext.Default.IOpenApiSchema));
        }
    }

    private string BuildEnum(IOpenApiSchema schema, List<GeneratedTypeModel> types, HashSet<string> typeNames, string parentClassName, string propertyName)
    {
        var enumName = CodeGenerationUtilities.CleanIdentifier(parentClassName + " " + propertyName) + "Enum";
        if (string.IsNullOrEmpty(enumName))
        {
            return enumName;
        }
        var enumNameValue = enumName!;

        if (!typeNames.Add(enumNameValue))
        {
            return enumNameValue;
        }

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

            members.Add(new GeneratedEnumMemberModel(identifier!, value, value));
        }

        types.Add(new GeneratedEnumModel(enumNameValue, schema.Description, members));
        return enumNameValue;
    }

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

    private static string? GetDefaultValue(JsonNode? value)
    {
        if (value is null || value.GetValueKind() != JsonValueKind.String)
        {
            return null;
        }

        return value.GetValue<string>();
    }
}

[JsonSerializable(typeof(IOpenApiSchema))]
internal partial class CodeGeneratorSourceGenerationContext : JsonSerializerContext
{
}
