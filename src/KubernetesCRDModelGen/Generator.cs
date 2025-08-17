using Humanizer;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml;
using System.Xml.Linq;

namespace KubernetesCRDModelGen;

/// <inheritdoc/>
public class Generator : IGenerator
{
    public readonly ILogger<Generator> logger;

    public const string ModelNamespace = "KubernetesCRDModelGen.Models";

    private readonly MetadataReference[] _metadataReferences;

    private const string KubePreserveUnknownFields = "x-kubernetes-preserve-unknown-fields";

    private const string KubeIntOrString = "x-kubernetes-int-or-string";

    private bool EnumSupport = false;

    private readonly CSharpCompilationOptions _options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
        .WithConcurrentBuild(true)
        .WithDeterministic(true)
        .WithNullableContextOptions(NullableContextOptions.Enable)
        .WithOptimizationLevel(OptimizationLevel.Release)
        .WithOverflowChecks(false)
        .WithPlatform(Platform.AnyCpu)
        .WithSpecificDiagnosticOptions(
        [
            // Don't warn for binding redirects
            new("CS1701", ReportDiagnostic.Suppress),
            new("CS1702", ReportDiagnostic.Suppress)
        ]);

    /// <summary>
    /// Initializes a new instance of the <see cref="Generator"/> class.
    /// </summary>
    /// <param name="logger">The logger to use for logging messages.</param>
    public Generator(ILogger<Generator> logger)
    {
        this.logger = logger;

        _metadataReferences ??= GetReferences();
    }

    /// <inheritdoc/>
    public (Assembly?, XmlDocument?) GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        try
        {
            var code = GenerateCompilationUnit(crd, @namespace);

            var compilation = CSharpCompilation.Create(
                crd.Metadata.Name,
                syntaxTrees: [code.SyntaxTree],
                references: _metadataReferences,
                options: _options);

            using var peStream = new MemoryStream();
            using var xmlDocumentationStream = new MemoryStream();

            var result = compilation.Emit(peStream, xmlDocumentationStream: xmlDocumentationStream);

            if (!result.Success)
            {
                var failures = result.Diagnostics.Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error);

                foreach (var diagnostic in failures)
                {
                    logger.LogError("Error creating Assembly: {id}: {message}", diagnostic.Id, diagnostic.GetMessage());
                }
            }
            else
            {
                peStream.Seek(0, SeekOrigin.Begin);
                var assembly = Assembly.Load(peStream.ToArray());

                xmlDocumentationStream.Seek(0, SeekOrigin.Begin);
                var xml = new XmlDocument();
                xml.Load(xmlDocumentationStream);

                return (assembly, xml);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error creating Assembly");
        }

        return (null, null);
    }

    /// <inheritdoc/>
    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var code = GenerateCompilationUnit(crd, @namespace);

        return code.NormalizeWhitespace().ToFullString();
    }

    /// <inheritdoc/>
    public void SetEnumSupport(bool enabled)
    {
        EnumSupport = enabled;
    }

    private CompilationUnitSyntax GenerateCompilationUnit(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var version = crd.Spec.Versions.First(x => x.Served && x.Storage);

        var schema = version.Schema.OpenAPIV3Schema;

        var reader = new OpenApiJsonReader();

        var node = JsonSerializer.SerializeToNode(version.Schema.OpenAPIV3Schema);

        var doc = reader.ReadFragment<OpenApiSchema>(node, OpenApiSpecVersion.OpenApi3_0, new OpenApiDocument(), out var diag);

        if (diag != null && diag.Errors.Count > 0)
        {
            logger.LogError("Error: {err}", diag.Errors.Select(x => x.Message));
        }

        var namespaceDeclaration = SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName(CleanIdentifier(@namespace + "." + crd.Spec.Group, true))).NormalizeWhitespace();

        namespaceDeclaration = namespaceDeclaration.AddMembers(GenerateClass(doc, crd.Spec.Names.Kind, version.Name, crd.Spec.Names.Kind, crd.Spec.Group, crd.Spec.Names.Plural, crd.Spec.Names.ListKind ?? crd.Spec.Names.Kind + "List"));

        var nullableTrivia = SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.EnableKeyword), true);

        var compilationUnit = SyntaxFactory.CompilationUnit()
            .WithUsings(GenerateUsings())
            .AddMembers(namespaceDeclaration);

        return compilationUnit;
    }

    private static SyntaxList<UsingDirectiveSyntax> GenerateUsings()
    {
        return SyntaxFactory.List([
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("k8s")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("k8s.Models")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Runtime.Serialization")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.Json")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.Json.Nodes")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.Json.Serialization")),
        ]);
    }

    private BaseTypeDeclarationSyntax[] GenerateClass(IOpenApiSchema schema, string name, string? version = null, string? kind = null, string? group = null, string? plural = null, string? listKind = null)
    {
        bool isRoot = version != null && kind != null && group != null && plural != null && listKind != null;

        var types = new List<BaseTypeDeclarationSyntax>();

        var @class = SyntaxFactory.ClassDeclaration(CleanIdentifier((isRoot ? version : string.Empty) + " " + name))
                        .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
                        .AddAttributeLists(SyntaxFactory.AttributeList()
                            .AddAttributes(
                            [
                                SyntaxFactory.Attribute(
                                    SyntaxFactory.ParseName("global::System.CodeDom.Compiler.GeneratedCode"))
                                    .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList(new[]
                                    {
                                        SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("KubernetesCRDModelGen.Tool"))),
                                        SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("1.0.0.0")))
                                    }))),
                                SyntaxFactory.Attribute(SyntaxFactory.ParseName("global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage"))
                            ])
                        )
                        .WithLeadingTrivia(
                            SyntaxFactory.TriviaList(
                                SyntaxFactory.Trivia(SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.EnableKeyword), true)),
                                SyntaxFactory.Comment($"/// <summary>{XmlString(schema.Description?.Replace("\n", " ").Replace("\r", " ") ?? "")}</summary>"),
                                SyntaxFactory.CarriageReturnLineFeed))
                        .WithTrailingTrivia(SyntaxFactory.Trivia(SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.DisableKeyword), true)));



        if (isRoot)
        {
            // Base Classes
            @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("IKubernetesObject<V1ObjectMeta>")));

            var @classList = SyntaxFactory.ClassDeclaration(CleanIdentifier(version + listKind))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
                .AddAttributeLists(SyntaxFactory.AttributeList()
                    .AddAttributes(
                    [
                        SyntaxFactory.Attribute(
                                    SyntaxFactory.ParseName("global::System.CodeDom.Compiler.GeneratedCode"))
                                    .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList(new[]
                                    {
                                        SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("KubernetesCRDModelGen.Tool"))),
                                        SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("1.0.0.0")))
                                    }))),
                                SyntaxFactory.Attribute(SyntaxFactory.ParseName("global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage"))
                    ])
                )
                .WithLeadingTrivia(
                    SyntaxFactory.TriviaList(
                        SyntaxFactory.Trivia(SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.EnableKeyword), true)),
                        SyntaxFactory.Comment($"/// <summary>{XmlString(schema.Description?.Replace("\n", " ").Replace("\r", " ") ?? "")}</summary>"),
                        SyntaxFactory.CarriageReturnLineFeed))
                .WithTrailingTrivia(SyntaxFactory.Trivia(SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.DisableKeyword), true)));

            @classList = @classList.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("IKubernetesObject<V1ListMeta>")));

            @classList = @classList.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName($"IItems<{CleanIdentifier(version + " " + name)}>")));

            // Create an attribute syntax for the KubernetesEntity attribute
            var kubernetesEntityAttribute = SyntaxFactory.Attribute(
                SyntaxFactory.ParseName("KubernetesEntity"))
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
                            SyntaxFactory.IdentifierName("KubePluralName"))));

            @class = @class.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(kubernetesEntityAttribute));
            @classList = @classList.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(kubernetesEntityAttribute));

            // Create the field declarations for the KubernetesEntity attribute
            var kubeApiVersion = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(
                        SyntaxFactory.ParseTypeName("string"))
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
                        SyntaxFactory.ParseTypeName("string"))
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
                        SyntaxFactory.ParseTypeName("string"))
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
                        SyntaxFactory.ParseTypeName("string"))
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
                        SyntaxFactory.ParseTypeName("string"))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("KubePluralName")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(plural!)))))))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

            // Create a property declaration for ApiVersion
            var apiVersion = CreateProperty("string", "apiVersion");

            // Create a property declaration for Kind
            var kindProp = CreateProperty("string", "kind");

            // Create a property declaration for Metadata
            var metaProp = CreateProperty("V1ObjectMeta", "metadata");

            // Create a property declaration for List Metadata
            var metaListProp = CreateProperty("V1ListMeta", "metadata");

            // Create a property declaration for List Kind
            var kindListProp = CreateProperty($"IList<{CleanIdentifier(version + " " + name)}>", "items");

            @class = @class.AddMembers(kubeApiVersion, kubeKind, kubeGroup, kubePluralName, apiVersion, kindProp, metaProp);
            @classList = @classList.AddMembers(kubeApiVersion, kubeListKind, kubeGroup, kubePluralName, apiVersion, kindProp, metaListProp, kindListProp);
            types.Add(@classList);
        }

        if (schema.Extensions != null && schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var preserve) && preserve is JsonNodeExtension preserve1 && preserve1.Node.GetValueKind() == JsonValueKind.True)
        {            // Create property

            var property = SyntaxFactory.PropertyDeclaration(
                    SyntaxFactory.NullableType(
                        SyntaxFactory.ParseTypeName("IDictionary<string, JsonElement>")
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
                            new AccessorDeclarationSyntax[]
                            {
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                            }
                        )
                    )
                )
                .WithAttributeLists(
                    SyntaxFactory.SingletonList(
                        SyntaxFactory.AttributeList(
                            SyntaxFactory.SingletonSeparatedList(SyntaxFactory.Attribute(SyntaxFactory.ParseName("JsonExtensionData")))
                        )
                    )
                );

            @class = @class.AddMembers(property);
        }
        if (schema.Properties != null)
        {
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

                var type = GetOrGenerateType(property.Value, types, @class.Identifier.Text, property.Key);

                // Add ISpec base class
                if (isRoot && property.Key == "spec")
                {
                    @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName($"ISpec<{type}>")));
                }

                // Add IStatus base class
                if (isRoot && property.Key == "status")
                {
                    @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName($"IStatus<{type}>")));
                }

                var newProperty = CreateProperty(type, property.Key, property.Value.Description, schema.Required?.Contains(property.Key) == true && (property.Value.Type.HasValue && !property.Value.Type.Value.HasFlag(JsonSchemaType.Null)));

                //Check if class already contains a property with the same name
                var count = 1;
                while (@class.Members.Where(x => x.IsKind(SyntaxKind.PropertyDeclaration)).Any(x => ((PropertyDeclarationSyntax)x).Identifier.Text == newProperty.Identifier.Text))
                {
                    newProperty = CreateProperty(type, property.Key + count++, property.Value.Description, schema.Required?.Contains(property.Key) == true && (property.Value.Type.HasValue && !property.Value.Type.Value.HasFlag(JsonSchemaType.Null)));
                }

                @class = @class.AddMembers(newProperty);
            }
        }
        types.Add(@class);

        return [.. types];
    }

    private string GetOrGenerateType(IOpenApiSchema schema, List<BaseTypeDeclarationSyntax> types, string parentClassName, string propertyName)
    {
        if (schema.Extensions != null && schema.Extensions.TryGetValue(KubePreserveUnknownFields, out var value2) && value2 is JsonNodeExtension value3 && value3.Node.GetValueKind() == JsonValueKind.True)
        {
            return nameof(JsonNode);
        }
        else if (schema.Extensions != null && schema.Extensions.TryGetValue(KubeIntOrString, out var value) && value is JsonNodeExtension value1 && value1.Node.GetValueKind() == JsonValueKind.True)
        {
            return nameof(IntstrIntOrString);
        }

        switch (schema.Type)
        {
            case JsonSchemaType.Null | JsonSchemaType.Object:
            case JsonSchemaType.Object:
                if (schema.AdditionalProperties != null)
                {
                    return $"IDictionary<string, {GetOrGenerateType(schema.AdditionalProperties, types, parentClassName, propertyName)}>";
                }
                else
                {
                    var nestedClasses = GenerateClass(schema, CleanIdentifier(parentClassName + " " + propertyName));

                    foreach (var newClass in nestedClasses)
                    {
                        if (!types.Any(x => x.Identifier.Text == newClass.Identifier.Text))
                        {
                            types.AddRange(nestedClasses);
                        }
                    }

                    return nestedClasses[nestedClasses.Length - 1].Identifier.Text;
                }
            case JsonSchemaType.Null | JsonSchemaType.String:
            case JsonSchemaType.String:
                if (EnumSupport && schema.Enum != null && schema.Enum.Any())
                    return GenerateEnum(schema, types, parentClassName, propertyName);
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

                if (EnumSupport && schema.Enum != null && schema.Enum.Any())
                {
                    return $"IList<{GenerateEnum(schema, types, parentClassName, propertyName)}>";
                }

                return $"IList<{GetOrGenerateType(schema.Items, types, parentClassName, propertyName)}>";
            default:
                throw new Exception("Unsupported Type: " + JsonSerializer.Serialize(schema));
        }
    }

    private static string GenerateEnum(IOpenApiSchema schema, List<BaseTypeDeclarationSyntax> types, string parentClassName, string propertyName)
    {
        var enumDeclaration = SyntaxFactory.EnumDeclaration(CleanIdentifier(parentClassName + " " + propertyName) + "Enum")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddAttributeLists(SyntaxFactory.AttributeList()
                .AddAttributes(
                [
                    SyntaxFactory.Attribute(
                        SyntaxFactory.ParseName("global::System.CodeDom.Compiler.GeneratedCode"))
                        .WithArgumentList(SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList(new[]
                        {
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("KubernetesCRDModelGen.Tool"))),
                            SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("1.0.0.0")))
                        }))),
                ])
            )
            .WithLeadingTrivia(
                            SyntaxFactory.TriviaList(
                                SyntaxFactory.Comment($"/// <summary>{XmlString(schema.Description?.Replace("\n", " ").Replace("\r", " ") ?? "")}</summary>"),
                                SyntaxFactory.CarriageReturnLineFeed));

        for (var i = 0; i < schema.Enum.Count; i++)
        {
            var option = schema.Enum[i];

            if (option.GetValueKind() == JsonValueKind.String)
            {
                var value = option.GetValue<string>();
                var identifier = CleanIdentifier(value);

                if (string.IsNullOrEmpty(identifier))
                {
                    identifier = "Option" + i;
                }

                // Check if identifier already exists
                var c = 1;
                while (enumDeclaration.Members.Any(x => x.Identifier.Text == identifier))
                {
                    identifier = CleanIdentifier(value) + c++;
                }

                enumDeclaration = enumDeclaration.AddMembers(
                    SyntaxFactory.EnumMemberDeclaration(SyntaxFactory.Identifier(identifier))
                        .WithLeadingTrivia(
                            SyntaxFactory.TriviaList(
                                SyntaxFactory.Comment($"/// <summary>{XmlString(value.Replace("\n", " ").Replace("\r", " "))}</summary>"),
                                SyntaxFactory.CarriageReturnLineFeed))
                        .WithAttributeLists(
                            SyntaxFactory.SingletonList(
                                SyntaxFactory.AttributeList(
                                    SyntaxFactory.SeparatedList(
                                        [
                                            SyntaxFactory.Attribute(SyntaxFactory.ParseName("EnumMember"))
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
                                            SyntaxFactory.Attribute(SyntaxFactory.ParseName("JsonStringEnumMemberName"))
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
                );
            }
        }

        types.Add(enumDeclaration);

        return enumDeclaration.Identifier.Text;
    }

    private static PropertyDeclarationSyntax CreateProperty(string typeName, string propertyName, string comment = "", bool required = true)
    {
        var propDecleration = SyntaxFactory.PropertyDeclaration(required ? SyntaxFactory.ParseTypeName(typeName) : SyntaxFactory.NullableType(SyntaxFactory.ParseTypeName(typeName)), CleanIdentifier(propertyName))
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

        propDecleration = propDecleration.WithAccessorList(
            SyntaxFactory.AccessorList(
                SyntaxFactory.List(
                    new AccessorDeclarationSyntax[]{
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                    })));

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

        if (typeName.EndsWith("Enum"))
        {
            propDecleration = propDecleration.AddAttributeLists(
                SyntaxFactory.AttributeList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.Attribute(
                            SyntaxFactory.ParseName("JsonConverter"),
                            SyntaxFactory.AttributeArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.AttributeArgument(
                                        SyntaxFactory.TypeOfExpression(
                                            SyntaxFactory.ParseTypeName($"JsonStringEnumConverter<{CleanIdentifier(typeName)}>")
                                        )
                                    )
                                )
                            )
                        ))));
        }

        propDecleration = propDecleration.WithLeadingTrivia(
            SyntaxFactory.TriviaList(
                SyntaxFactory.Comment($"/// <summary>{XmlString(comment?.Replace("\n", " ").Replace("\r", " ") ?? "")}</summary>"),
                SyntaxFactory.CarriageReturnLineFeed));


        return propDecleration;
    }

    internal static string? CleanIdentifier(string name, bool @namespace = false)
    {
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

        var sb = new StringBuilder();
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
            var newResult = string.Empty;
            foreach (var chunk in result.Split('.'))
            {
                if (!string.IsNullOrEmpty(newResult))
                {
                    newResult += '.';
                }

                if (SyntaxFacts.GetKeywordKind(chunk) != SyntaxKind.None)
                {
                    newResult += '@' + chunk;
                }
                else
                {
                    newResult += chunk;
                }
            }

            return newResult;
        }

        return result;
    }

    private MetadataReference[] GetReferences()
    {
        var references = new List<MetadataReference>();

        var assembly = GetType().Assembly;

        var assemblies = assembly.GetManifestResourceNames().Where(x => x.StartsWith("runtime.") && x.EndsWith(".dll")).ToList();

        foreach (var item in assemblies)
        {
            using var stream = assembly.GetManifestResourceStream(item);
            var ass = MetadataReference.CreateFromStream(stream!);
            references.Add(ass);
        }

        return [.. references];
    }

    private static string XmlString(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        return new XElement("t", text).LastNode?.ToString() ?? "";
    }
}
