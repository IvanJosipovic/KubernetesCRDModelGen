﻿using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Nodes;
using System.Xml;
using Humanizer;
using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace KubernetesCRDModelGen;

public class Generator : IGenerator
{
    public const string ModelNamespace = "KubernetesCRDModelGen.Models";

    private readonly MetadataReference[] _metadataReferences;

    private const string KubePreserveUnkownFields = "x-kubernetes-preserve-unknown-fields";

    private const string KubeIntOrString = "x-kubernetes-int-or-string";

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

    public Generator()
    {
        _metadataReferences ??= GetReferences();
    }

    private CompilationUnitSyntax GenerateCompilationUnit(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var version = crd.Spec.Versions.First(x => x.Served && x.Storage);

        var schema = version.Schema.OpenAPIV3Schema;

        var doc = new OpenApiStringReader().ReadFragment<OpenApiSchema>(KubernetesJson.Serialize(version.Schema.OpenAPIV3Schema), OpenApiSpecVersion.OpenApi3_0, out var diag);

        if (diag?.Errors.Count > 0)
        {
            Console.WriteLine("Error: " + diag.Errors.Select(x => x.Message));
        }

        var namespaceDeclaration = SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName(CleanIdentifier(@namespace + "." + crd.Spec.Group, true))).NormalizeWhitespace();

        namespaceDeclaration = namespaceDeclaration.AddMembers(GenerateClass(doc, crd.Spec.Names.Kind, version.Name, crd.Spec.Names.Kind, crd.Spec.Group, crd.Spec.Names.Plural));

        var compilationUnit = SyntaxFactory.CompilationUnit().WithUsings(GenerateUsings());

        return compilationUnit.AddMembers(namespaceDeclaration);
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

    private BaseTypeDeclarationSyntax[] GenerateClass(OpenApiSchema schema, string name, string? version = null, string? kind = null, string? group = null, string? plural = null)
    {
        bool isRoot = version != null && kind != null && group != null && plural != null;

        var types = new List<BaseTypeDeclarationSyntax>();

        var @class = SyntaxFactory.ClassDeclaration(CleanIdentifier((isRoot ? version : string.Empty) + " " + name))
                        .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword));

        if (isRoot)
        {
            // Base Classes
            @class = @class.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("IKubernetesObject<V1ObjectMeta>")));

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

            @class = @class.AddMembers(kubeApiVersion, kubeKind, kubeGroup, kubePluralName, apiVersion, kindProp, metaProp);
        }

        if (schema.Extensions.TryGetValue(KubePreserveUnkownFields, out var preserve) && preserve is OpenApiBoolean preserveBool && preserveBool.Value)
        {
            // Create property
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

            @class = @class.AddMembers(CreateProperty(type, property.Key, property.Value.Description, schema.Required.Contains(property.Key)));
        }

        types.Add(@class);

        return [.. types];
    }

    private string GetOrGenerateType(OpenApiSchema schema, List<BaseTypeDeclarationSyntax> classes, string parentClassName, string propertyName)
    {
        string type = string.Empty;

        if (schema.Extensions.TryGetValue(KubePreserveUnkownFields, out var value2) && value2 is OpenApiBoolean boolean2 && boolean2.Value)
        {
            type = nameof(JsonNode);
        }
        else if (schema.Extensions.TryGetValue(KubeIntOrString, out var value) && value is OpenApiBoolean boolean && boolean.Value)
        {
            type = nameof(IntstrIntOrString);
        }

        switch (schema.Type)
        {
            case "object":
                if (string.IsNullOrEmpty(type))
                {
                    if (schema.AdditionalProperties != null)
                    {
                        type = $"IDictionary<string, {GetOrGenerateType(schema.AdditionalProperties, classes, parentClassName, propertyName)}>";
                    }
                    else
                    {
                        var nestedClasses = GenerateClass(schema, CleanIdentifier(parentClassName + " " + propertyName));

                        foreach (var newClass in nestedClasses)
                        {
                            if (!classes.Any(x => x.Identifier.Text == newClass.Identifier.Text))
                            {
                                classes.AddRange(nestedClasses);
                            }
                        }

                        type = nestedClasses[nestedClasses.Length - 1].Identifier.Text;
                    }
                }

                break;
            case "string":

                if (schema.Enum.Any())
                {
                    type = GenerateEnum(schema.Enum, classes, parentClassName, propertyName);
                    break;
                }

                type = "string";
                break;
            case "number":
                type = "double";
                break;
            case "boolean":
                type = "bool";
                break;
            case "integer":
                if (schema.Format == "int64") type = "long"; else type = "int";
                break;
            case "array":

                if (schema.Enum.Any())
                {
                    type = $"IList<{GenerateEnum(schema.Enum, classes, parentClassName, propertyName)}>";
                    break;
                }

                type = $"IList<{GetOrGenerateType(schema.Items, classes, parentClassName, propertyName)}>";
                break;
        }

        if (string.IsNullOrEmpty(type))
        {
            throw new Exception("Unsupported Type: " + type);
        }

        return type;
    }

    private static string GenerateEnum(IList<IOpenApiAny> options, List<BaseTypeDeclarationSyntax> types, string parentClassName, string propertyName)
    {
        var enumDeclaration = SyntaxFactory.EnumDeclaration(CleanIdentifier(parentClassName + " " + propertyName) + "Enum")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

        for (var i = 0; i < options.Count; i++)
        {
            var option = options[i];

            if (option is OpenApiString openApiString)
            {
                var identifier = CleanIdentifier(openApiString.Value);

                if (string.IsNullOrEmpty(identifier))
                {
                    identifier = "Option" + i;
                }

                enumDeclaration = enumDeclaration.AddMembers(
                    SyntaxFactory.EnumMemberDeclaration(SyntaxFactory.Identifier(identifier))
                        .WithLeadingTrivia(
                            SyntaxFactory.TriviaList(
                                SyntaxFactory.Comment($"/// <summary>{openApiString.Value?.Replace("\n", " ").Replace("\r", " ")}</summary>"),
                                SyntaxFactory.CarriageReturnLineFeed))
                        .WithAttributeLists(
                            SyntaxFactory.SingletonList(
                                SyntaxFactory.AttributeList(
                                    SyntaxFactory.SingletonSeparatedList(
                                        SyntaxFactory.Attribute(SyntaxFactory.ParseName("EnumMember"))
                                            .WithArgumentList(
                                                SyntaxFactory.AttributeArgumentList(
                                                    SyntaxFactory.SingletonSeparatedList(
                                                        SyntaxFactory.AttributeArgument(
                                                            SyntaxFactory.NameEquals("Value"),
                                                            null,
                                                            SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(openApiString.Value))
                                                        )
                                                    )
                                                )
                                            )
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
                                            SyntaxFactory.ParseTypeName("JsonStringEnumMemberConverter")

                                        // Uncomment when STJ 9.0 is released
                                        //SyntaxFactory.ParseTypeName($"JsonStringEnumConverter<{CleanIdentifier(parentClassName + " " + propertyName) + "Enum"}>")
                                        )
                                    )
                                )
                            )
                        ))));
        }

        propDecleration = propDecleration.WithLeadingTrivia(
            SyntaxFactory.TriviaList(
                SyntaxFactory.Comment($"/// <summary>{comment?.Replace("\n", " ").Replace("\r", " ")}</summary>"),
                SyntaxFactory.CarriageReturnLineFeed));


        return propDecleration;
    }

    private static string? CleanIdentifier(string name, bool @namespace = false)
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

        return result;
    }

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
                    Console.WriteLine("Error creating Assembly: {0}: {1}", diagnostic.Id, diagnostic.GetMessage());
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
            Console.WriteLine("Error creating Assembly: {0}", ex);
        }

        return (null, null);
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

#if NETSTANDARD2_0
        references.AddRange(Basic.Reference.Assemblies.NetStandard20.References.All);
#else
        references.AddRange(Basic.Reference.Assemblies.Net80.References.All);
#endif
        return [.. references];
    }

    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var code = GenerateCompilationUnit(crd, @namespace);

        return code.NormalizeWhitespace().ToString();
    }
}
