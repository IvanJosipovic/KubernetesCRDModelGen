using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Security;

namespace KubernetesCRDModelGen.Base;

/// <inheritdoc/>
public class CodeGenerator : ICodeGenerator
{
    private const string KubePreserveUnknownFields = "x-kubernetes-preserve-unknown-fields";

    private const string KubeIntOrString = "x-kubernetes-int-or-string";

    private static readonly string CurrentVersion = typeof(CodeGenerator).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? string.Empty;

    private static readonly SyntaxList<UsingDirectiveSyntax> Usings = SyntaxFactory.List([
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("k8s")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("k8s.Models")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Runtime.Serialization")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.Json")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.Json.Nodes")),
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.Json.Serialization")),
    ]);

    private static readonly AttributeListSyntax GeneratedCodeAttributeList = SyntaxFactory.AttributeList().AddAttributes([
        SyntaxFactory.Attribute(
            SyntaxFactory.ParseName("global::System.CodeDom.Compiler.GeneratedCode"))
            .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList([
                SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("KubernetesCRDModelGen"))),
                SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(CurrentVersion)))
            ]))),
    ]);

    private static readonly AttributeListSyntax ExcludeFromCodeCoverageAttributeList = SyntaxFactory.AttributeList().AddAttributes([
        SyntaxFactory.Attribute(SyntaxFactory.ParseName("global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage"))
    ]);

    private static readonly AttributeListSyntax KubernetesEntityAttributeList = SyntaxFactory.AttributeList().AddAttributes([
        SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("KubernetesEntity"))
            .WithArgumentList(
                SyntaxFactory.AttributeArgumentList()
                .AddArguments(
                    SyntaxFactory.AttributeArgument(
                        SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("Group")),
                        null,
                        SyntaxFactory.IdentifierName("KubeGroup")),
                    SyntaxFactory.AttributeArgument(
                        SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("Kind")),
                        null,
                        SyntaxFactory.IdentifierName("KubeKind")),
                    SyntaxFactory.AttributeArgument(
                        SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("ApiVersion")),
                        null,
                        SyntaxFactory.IdentifierName("KubeApiVersion")),
                    SyntaxFactory.AttributeArgument(
                        SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("PluralName")),
                        null,
                        SyntaxFactory.IdentifierName("KubePluralName"))))
    ]);

    private static readonly object CacheLock = new();
    private static readonly Dictionary<(string Name, bool Namespace), string?> CleanIdentifierCache = new();
    private static readonly Dictionary<string, SyntaxTriviaList> SummaryTriviaCache = new(StringComparer.Ordinal);
    private static readonly Dictionary<string, TypeSyntax> TypeSyntaxCache = new(StringComparer.Ordinal);
    private static readonly HashSet<char> InvalidFileNameCharacters = [.. Path.GetInvalidFileNameChars()];
    private static readonly NameSyntax JsonConverterAttributeName = SyntaxFactory.IdentifierName("JsonConverter");
    private static readonly NameSyntax JsonExtensionDataAttributeName = SyntaxFactory.IdentifierName("JsonExtensionData");
    private static readonly NameSyntax EnumMemberAttributeName = SyntaxFactory.IdentifierName("EnumMember");
    private static readonly NameSyntax JsonStringEnumMemberNameAttributeName = SyntaxFactory.IdentifierName("JsonStringEnumMemberName");
    private static readonly AccessorListSyntax AutoPropertyAccessorList = SyntaxFactory.AccessorList(
        SyntaxFactory.List(
            [
                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
            ]));

    private bool EnumSupport = true;

    /// <inheritdoc/>
    public void SetEnumSupport(bool enabled)
    {
        EnumSupport = enabled;
    }

    /// <inheritdoc/>
    public CompilationUnitSyntax GenerateCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind)
    {
        return GenerateCompilationUnit(@namespace, group, GenerateClass(schema, kind, version, group, plural, listKind));
    }

    /// <inheritdoc/>
    public CompilationUnitSyntax GenerateCompilationUnit(string @namespace, string group, MemberDeclarationSyntax[] members)
    {
        var namespaceDeclaration = SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName(CleanIdentifier(@namespace + "." + group, true)))
            .AddMembers(members);

        var compilationUnit = SyntaxFactory.CompilationUnit()
            .WithUsings(Usings)
            .WithLeadingTrivia(
                SyntaxFactory.TriviaList(
                    SyntaxFactory.Trivia(SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.EnableKeyword), true))))
            .AddMembers(namespaceDeclaration);

        return compilationUnit;
    }

    /// <inheritdoc/>
    public BaseTypeDeclarationSyntax[] GenerateClass(IOpenApiSchema schema, string kind, string? version = null, string? group = null, string? plural = null, string? listKind = null)
        => GenerateClass(schema, kind, new HashSet<string>(StringComparer.Ordinal), version, group, plural, listKind);

    private BaseTypeDeclarationSyntax[] GenerateClass(IOpenApiSchema schema, string kind, HashSet<string> typeNames, string? version = null, string? group = null, string? plural = null, string? listKind = null)
    {
        bool isRoot = version != null && group != null && plural != null;

        listKind ??= kind + "List";

        var types = new List<BaseTypeDeclarationSyntax>();
        var propertyNames = new HashSet<string>(StringComparer.Ordinal);
        var classMembers = new List<MemberDeclarationSyntax>();

        var className = CleanIdentifier((isRoot ? version : string.Empty) + " " + kind);
        if (string.IsNullOrEmpty(className) || !typeNames.Add(className))
        {
            return [];
        }

        var @class = SyntaxFactory.ClassDeclaration(className)
                        .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
                        .AddAttributeLists(GeneratedCodeAttributeList)
                        .AddAttributeLists(ExcludeFromCodeCoverageAttributeList)
                        .WithLeadingTrivia(CreateSummaryTrivia(schema.Description));

        if (isRoot)
        {
            // Base Classes
            @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(GetTypeSyntax("IKubernetesObject<V1ObjectMeta>")));

            var classListName = CleanIdentifier(version + listKind);
            if (string.IsNullOrEmpty(classListName) || !typeNames.Add(classListName))
            {
                return [];
            }

            var @classList = SyntaxFactory.ClassDeclaration(classListName)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
                .AddAttributeLists(GeneratedCodeAttributeList)
                .AddAttributeLists(ExcludeFromCodeCoverageAttributeList)
                .WithLeadingTrivia(CreateSummaryTrivia(schema.Description));

            @classList = @classList.AddBaseListTypes(SyntaxFactory.SimpleBaseType(GetTypeSyntax("IKubernetesObject<V1ListMeta>")));

            @classList = @classList.AddBaseListTypes(SyntaxFactory.SimpleBaseType(GetTypeSyntax($"IItems<{className}>")));

            @class = @class.AddAttributeLists(KubernetesEntityAttributeList);
            @classList = @classList.AddAttributeLists(KubernetesEntityAttributeList);

            // Create the field declarations for the KubernetesEntity attribute
            var kubeApiVersion = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(
                        GetTypeSyntax("string"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("KubeApiVersion")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(version!)))))))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

            var kubeKind = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(
                        GetTypeSyntax("string"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("KubeKind")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(kind!)))))))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

            var kubeListKind = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(
                        GetTypeSyntax("string"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("KubeKind")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(listKind!)))))))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

            var kubeGroup = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(
                        GetTypeSyntax("string"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("KubeGroup")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(group!)))))))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

            var kubePluralName = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(
                        GetTypeSyntax("string"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("KubePluralName")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(plural!)))))))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

            // Create a property declaration for ApiVersion
            var apiVersion = CreateProperty("string", "apiVersion", "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources", false, group + "/" + version);

            // Create a property declaration for Kind
            var kindProp = CreateProperty("string", "kind", "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", false, kind);

            // Create a property declaration for Metadata
            var metaProp = CreateProperty("V1ObjectMeta", "metadata", "Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata", isNullable: false);

            classMembers.AddRange([kubeApiVersion, kubeKind, kubeGroup, kubePluralName, apiVersion, kindProp, metaProp]);

            // Create a property declaration for List Kind
            var kindListProp = CreateProperty("string", "kind", "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", false, listKind);

            // Create a property declaration for List Metadata
            var metaListProp = CreateProperty("V1ListMeta", "metadata", "ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.");

            // Create a property declaration for List Kind
            var kindIListProp = CreateProperty($"IList<{className}>", "items", $"List of {className} objects.");

            @classList = @classList.AddMembers([kubeApiVersion, kubeListKind, kubeGroup, kubePluralName, apiVersion, kindListProp, metaListProp, kindIListProp]);
            types.Add(@classList);
        }

        if (schema.Extensions != null && schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var preserve) && preserve is JsonNodeExtension preserve1 && preserve1.Node.GetValueKind() == JsonValueKind.True)
        {
            // Create property
            var property = SyntaxFactory.PropertyDeclaration(
                    SyntaxFactory.NullableType(
                        GetTypeSyntax("IDictionary<string, JsonElement>")
                    ),
                    SyntaxFactory.Identifier("ExtensionData")
                )
                .WithModifiers(
                    SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.PublicKeyword)
                    )
                )
                .WithAccessorList(
                    SyntaxFactory.AccessorList(
                        SyntaxFactory.List(
                            [
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                            ]
                        )
                    )
                )
                .WithAttributeLists(
                    SyntaxFactory.SingletonList(
                        SyntaxFactory.AttributeList(
                        SyntaxFactory.SingletonSeparatedList(SyntaxFactory.Attribute(JsonExtensionDataAttributeName))
                        )
                    )
                );

            classMembers.Add(property);
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
                if (isRoot)
                {
                    // Root Model, skip these fields as we are adding them above
                    if (property.Key == "apiVersion" || property.Key == "kind" || property.Key == "metadata")
                    {
                        continue;
                    }
                }

                var type = GetOrGenerateType(property.Value, types, typeNames, @class.Identifier.Text, property.Key);

                var isRequired = requiredNames?.Contains(property.Key) == true;
                var isNullable = property.Value.Type.HasValue && property.Value.Type.Value.HasFlag(JsonSchemaType.Null);
                var hasDefault = property.Value.Default != null;

                var resultNullable =
                                       (isRequired && isNullable && !hasDefault)
                                  //|| (isRequired && !isNullable && !hasDefault)
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
                    var specType = GetTypeSyntax(type);
                    if (resultNullable)
                    {
                        specType = SyntaxFactory.NullableType(specType);
                    }

                    // Add ISpec base class with the final nullability of the generated Spec type.
                    @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(
                        SyntaxFactory.GenericName("ISpec")
                            .WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                                SyntaxFactory.SingletonSeparatedList(specType)))));
                }

                if (isRoot && property.Key == "status")
                {
                    var statusType = GetTypeSyntax(type);
                    if (resultNullable)
                    {
                        statusType = SyntaxFactory.NullableType(statusType);
                    }

                    // Add IStatus base class with the final nullability of the generated Status type.
                    @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(
                        SyntaxFactory.GenericName("IStatus")
                            .WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                                SyntaxFactory.SingletonSeparatedList(statusType)))));
                }

                var newProperty = CreateProperty(type, property.Key, property.Value.Description, isRequired: resultRequired, isNullable: resultNullable);

                //Check if class already contains a property with the same name
                var count = 1;
                while (!propertyNames.Add(newProperty.Identifier.Text))
                {
                    newProperty = CreateProperty(type, property.Key + count++, property.Value.Description, isRequired: resultRequired, isNullable: resultNullable);
                }

                classMembers.Add(newProperty);
            }
        }
        @class = @class.AddMembers([.. classMembers]);
        types.Add(@class);

        return [.. types];
    }

    private string GetOrGenerateType(IOpenApiSchema schema, List<BaseTypeDeclarationSyntax> types, HashSet<string> typeNames, string parentClassName, string propertyName)
    {
        if (schema.Extensions != null && schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var value2) && value2 is JsonNodeExtension value3 && value3.Node.GetValueKind() == JsonValueKind.True)
        {
            return nameof(JsonNode);
        }
        else if (schema.Extensions != null && schema.Extensions.TryGetValue(KubeIntOrString, out var value) && value is JsonNodeExtension value1 && value1.Node.GetValueKind() == JsonValueKind.True)
        {
            return "IntOrString";
        }

        switch (schema.Type)
        {
            case JsonSchemaType.Null | JsonSchemaType.Object:
            case JsonSchemaType.Object:
                if (schema.AdditionalProperties != null)
                {
                    return $"IDictionary<string, {GetOrGenerateType(schema.AdditionalProperties, types, typeNames, parentClassName, propertyName)}>";
                }
                else
                {
                    var nestedClasses = GenerateClass(schema, CleanIdentifier(parentClassName + " " + propertyName), typeNames);
                    types.AddRange(nestedClasses);

                    return nestedClasses[nestedClasses.Length - 1].Identifier.Text;
                }
            case JsonSchemaType.Null | JsonSchemaType.String:
            case JsonSchemaType.String:
                if (EnumSupport && HasStringEnumValues(schema.Enum))
                    return GenerateEnum(schema, types, typeNames, parentClassName, propertyName);
                return "string";
            case JsonSchemaType.Null | JsonSchemaType.Number:
            case JsonSchemaType.Number:
                return "double";
            case JsonSchemaType.Null | JsonSchemaType.Boolean:
            case JsonSchemaType.Boolean:
                return "bool";
            case JsonSchemaType.Null | JsonSchemaType.Integer:
            case JsonSchemaType.Integer:
                if (schema.Format == "int64")
                    return "long";
                else
                    return "int";
            case JsonSchemaType.Null | JsonSchemaType.Array:
            case JsonSchemaType.Array:

                if (EnumSupport && HasStringEnumValues(schema.Enum))
                {
                    return $"IList<{GenerateEnum(schema, types, typeNames, parentClassName, propertyName)}>";
                }

                return $"IList<{GetOrGenerateType(schema.Items, types, typeNames, parentClassName, propertyName)}>";
            default:
                throw new Exception("Unsupported Type: " + JsonSerializer.Serialize(schema, CodeGeneratorSourceGenerationContext.Default.IOpenApiSchema));
        }
    }

    private static string GenerateEnum(IOpenApiSchema schema, List<BaseTypeDeclarationSyntax> types, HashSet<string> typeNames, string parentClassName, string propertyName)
    {
        var enumName = CleanIdentifier(parentClassName + " " + propertyName) + "Enum";
        var memberNames = new HashSet<string>(StringComparer.Ordinal);
        var enumMembers = new List<EnumMemberDeclarationSyntax>();
        if (string.IsNullOrEmpty(enumName) || !typeNames.Add(enumName))
        {
            return enumName;
        }

        var enumDeclaration = SyntaxFactory.EnumDeclaration(enumName)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddAttributeLists(GeneratedCodeAttributeList)
            .AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(
                SyntaxFactory.Attribute(JsonConverterAttributeName)
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.TypeOfExpression(
                                        GetTypeSyntax($"JsonStringEnumConverter<{enumName}>")
                                    )
                                )
                            )
                        ))
            ))
            .WithLeadingTrivia(
                CreateSummaryTrivia(schema.Description));

        for (var i = 0; i < schema.Enum.Count; i++)
        {
            var option = schema.Enum[i];

            if (option.GetValueKind() == JsonValueKind.String)
            {
                var value = option.GetValue<string>();
                var identifier = CleanIdentifier(value);
                var baseIdentifier = identifier;

                if (string.IsNullOrEmpty(identifier))
                {
                    identifier = "Option" + i;
                    baseIdentifier = identifier;
                }

                // Check if identifier already exists
                var c = 1;
                while (!memberNames.Add(identifier))
                {
                    identifier = baseIdentifier + c++;
                }

                enumMembers.Add(
                    SyntaxFactory.EnumMemberDeclaration(SyntaxFactory.Identifier(identifier))
                        .WithAttributeLists(
                            SyntaxFactory.SingletonList(
                                SyntaxFactory.AttributeList(
                                    SyntaxFactory.SeparatedList(
                                        [
                                            SyntaxFactory.Attribute(EnumMemberAttributeName)
                                                .WithArgumentList(
                                                    SyntaxFactory.AttributeArgumentList(
                                                        SyntaxFactory.SingletonSeparatedList(
                                                            SyntaxFactory.AttributeArgument(
                                                                SyntaxFactory.NameEquals("Value"),
                                                                null,
                                                                SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(value))
                                                            )
                                                        )
                                                    )
                                                ),
                                            SyntaxFactory.Attribute(JsonStringEnumMemberNameAttributeName)
                                                .WithArgumentList(
                                                    SyntaxFactory.AttributeArgumentList(
                                                        SyntaxFactory.SingletonSeparatedList(
                                                            SyntaxFactory.AttributeArgument(
                                                                SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(value))
                                                            )
                                                        )
                                                    )
                                                )
                                        ]
                                    )
                                )
                            )
                        )
                        .WithLeadingTrivia(
                            CreateSummaryTrivia(value)));
            }
        }

        enumDeclaration = enumDeclaration.AddMembers([.. enumMembers]);
        types.Add(enumDeclaration);

        return enumDeclaration.Identifier.Text;
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

    private PropertyDeclarationSyntax CreateProperty(string typeName, string propertyName, string comment = "", bool isNullable = true, string? defaultValue = null, bool isRequired = false)
    {
        PropertyDeclarationSyntax propDecleration;
        var propertyType = GetTypeSyntax(typeName);

        if (isNullable)
        {
            propDecleration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.NullableType(propertyType), CleanIdentifier(propertyName))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
        }
        else
        {
            propDecleration = SyntaxFactory.PropertyDeclaration(propertyType, CleanIdentifier(propertyName))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
        }

        if (isRequired && defaultValue == null)
        {
            propDecleration = propDecleration.AddModifiers(SyntaxFactory.Token(SyntaxKind.RequiredKeyword));
        }

        propDecleration = propDecleration.WithAccessorList(
            AutoPropertyAccessorList);

        propDecleration = propDecleration.AddAttributeLists(
            SyntaxFactory.AttributeList(
                SyntaxFactory.SingletonSeparatedList(
                    SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("JsonPropertyName"))
                        .WithArgumentList(
                            SyntaxFactory.AttributeArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.AttributeArgument(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression,
                                            SyntaxFactory.Literal(propertyName)))))))));
        propDecleration = propDecleration.WithLeadingTrivia(
            CreateSummaryTrivia(comment));

        if (!string.IsNullOrEmpty(defaultValue))
        {
            propDecleration = propDecleration.WithInitializer(
                SyntaxFactory.EqualsValueClause(
                    SyntaxFactory.LiteralExpression(
                        SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(defaultValue)
                    )
                )
            )
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
        }

        return propDecleration;
    }

    internal static string? CleanIdentifier(string name, bool @namespace = false)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var cacheKey = (name, @namespace);
        lock (CacheLock)
        {
            if (CleanIdentifierCache.TryGetValue(cacheKey, out var cached))
            {
                return cached;
            }
        }

        // trim off leading and trailing whitespace
        name = name.Trim();

        // should deal with spaces => camel casing;
        if (@namespace == false)
        {
            name = name.Dehumanize();
        }

        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var sb = new StringBuilder(name.Length + 1);
        if (!SyntaxFacts.IsIdentifierStartCharacter(name[0]))
        {
            // the first characters
            sb.Append('_');
        }

        foreach (var ch in name)
        {
            if (SyntaxFacts.IsIdentifierPartCharacter(ch) || (@namespace && ch == '.'))
            {
                sb.Append(ch);
            }
        }

        var result = sb.ToString();

        if (SyntaxFacts.GetKeywordKind(result) != SyntaxKind.None)
        {
            result = '@' + result;
        }

        if (@namespace)
        {
            var namespaceBuilder = new StringBuilder(result.Length + 4);
            var start = 0;
            for (var i = 0; i <= result.Length; i++)
            {
                if (i == result.Length || result[i] == '.')
                {
                    if (namespaceBuilder.Length > 0)
                    {
                        namespaceBuilder.Append('.');
                    }

                    var chunk = result.Substring(start, i - start);
                    if (SyntaxFacts.GetKeywordKind(chunk) != SyntaxKind.None)
                    {
                        namespaceBuilder.Append('@');
                    }

                    namespaceBuilder.Append(chunk);
                    start = i + 1;
                }
            }

            result = namespaceBuilder.ToString();
        }

        lock (CacheLock)
        {
            CleanIdentifierCache[cacheKey] = result;
        }

        return result;
    }

    private static SyntaxTriviaList CreateSummaryTrivia(string? text)
    {
        var normalizedText = text?.Replace("\r\n", "\n").Replace('\r', '\n') ?? string.Empty;
        lock (CacheLock)
        {
            if (SummaryTriviaCache.TryGetValue(normalizedText, out var cached))
            {
                return cached;
            }
        }

        SyntaxTriviaList trivia;
        if (!normalizedText.Contains('\n'))
        {
            trivia = SyntaxFactory.ParseLeadingTrivia(
                $"/// <summary>{SecurityElement.Escape(normalizedText) ?? string.Empty}</summary>{Environment.NewLine}");
        }
        else
        {
            var builder = new StringBuilder(normalizedText.Length + 32);
            builder.Append("/// <summary>").Append(Environment.NewLine);

            var lineStart = 0;
            for (var i = 0; i <= normalizedText.Length; i++)
            {
                if (i == normalizedText.Length || normalizedText[i] == '\n')
                {
                    var line = normalizedText.Substring(lineStart, i - lineStart);
                    builder.Append("/// ").Append(SecurityElement.Escape(line) ?? string.Empty).Append(Environment.NewLine);
                    lineStart = i + 1;
                }
            }

            builder.Append("/// </summary>").Append(Environment.NewLine);
            trivia = SyntaxFactory.ParseLeadingTrivia(builder.ToString());
        }

        lock (CacheLock)
        {
            SummaryTriviaCache[normalizedText] = trivia;
        }

        return trivia;
    }

    private static TypeSyntax GetTypeSyntax(string typeName)
    {
        lock (CacheLock)
        {
            if (TypeSyntaxCache.TryGetValue(typeName, out var cached))
            {
                return cached;
            }
        }

        var parsed = SyntaxFactory.ParseTypeName(typeName);

        lock (CacheLock)
        {
            TypeSyntaxCache[typeName] = parsed;
        }

        return parsed;
    }

    /// <summary>
    /// Removes invalid characters from a file name to ensure it is safe for use in the file system.
    /// </summary>
    /// <param name="fileName">The file name to sanitize.</param>
    /// <returns>A sanitized file name with illegal characters removed.</returns>
    /// <exception cref="ArgumentException">Thrown when the file name is null or empty.</exception>
    public static string RemoveIllegalFileNameCharacters(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentException("File name cannot be null or empty", nameof(fileName));

        var builder = new StringBuilder(fileName.Length);
        for (var i = 0; i < fileName.Length; i++)
        {
            var ch = fileName[i];
            if (!InvalidFileNameCharacters.Contains(ch))
            {
                builder.Append(ch);
            }
        }

        return builder.ToString();
    }
}

[JsonSerializable(typeof(IOpenApiSchema))]
internal partial class CodeGeneratorSourceGenerationContext : JsonSerializerContext
{
}
