using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection;

namespace KubernetesCRDModelGen.Base;

internal sealed class RoslynCodeModelRenderer
{
    private static readonly string CurrentVersion = typeof(RoslynCodeModelRenderer).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? string.Empty;

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
        SyntaxFactory.Attribute(SyntaxFactory.ParseName("global::System.CodeDom.Compiler.GeneratedCode"))
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
                        SyntaxFactory.AttributeArgument(SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("Group")), null, SyntaxFactory.IdentifierName("KubeGroup")),
                        SyntaxFactory.AttributeArgument(SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("Kind")), null, SyntaxFactory.IdentifierName("KubeKind")),
                        SyntaxFactory.AttributeArgument(SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("ApiVersion")), null, SyntaxFactory.IdentifierName("KubeApiVersion")),
                        SyntaxFactory.AttributeArgument(SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("PluralName")), null, SyntaxFactory.IdentifierName("KubePluralName"))))
    ]);

    private static readonly NameSyntax JsonConverterAttributeName = SyntaxFactory.IdentifierName("JsonConverter");
    private static readonly NameSyntax JsonExtensionDataAttributeName = SyntaxFactory.IdentifierName("JsonExtensionData");
    private static readonly NameSyntax EnumMemberAttributeName = SyntaxFactory.IdentifierName("EnumMember");
    private static readonly NameSyntax JsonStringEnumMemberNameAttributeName = SyntaxFactory.IdentifierName("JsonStringEnumMemberName");
    private static readonly NameSyntax JsonStringEnumConverterName = SyntaxFactory.IdentifierName("JsonStringEnumConverter");
    private static readonly AccessorListSyntax AutoPropertyAccessorList = SyntaxFactory.AccessorList(
        SyntaxFactory.List(
            [
                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
            ]));

    public CompilationUnitSyntax RenderCompilationUnit(GeneratedCompilationUnitModel model)
        => RenderCompilationUnit(model.NamespaceName, model.Group, RenderTypes(model.Types));

    public CompilationUnitSyntax RenderCompilationUnit(string @namespace, string group, IReadOnlyList<MemberDeclarationSyntax> members)
    {
        var namespaceDeclaration = SyntaxFactory.FileScopedNamespaceDeclaration(
                SyntaxFactory.ParseName(CodeGenerationUtilities.CleanIdentifier(@namespace + "." + group, true)!))
            .AddMembers([.. members]);

        return SyntaxFactory.CompilationUnit()
            .WithUsings(Usings)
            .WithLeadingTrivia(
                SyntaxFactory.TriviaList(
                    SyntaxFactory.Trivia(SyntaxFactory.NullableDirectiveTrivia(SyntaxFactory.Token(SyntaxKind.EnableKeyword), true))))
            .AddMembers(namespaceDeclaration);
    }

    public BaseTypeDeclarationSyntax[] RenderTypes(IReadOnlyList<GeneratedTypeModel> types)
        => [.. types.Select(RenderType)];

    private BaseTypeDeclarationSyntax RenderType(GeneratedTypeModel model)
        => model switch
        {
            GeneratedClassModel classModel => RenderClass(classModel),
            GeneratedEnumModel enumModel => RenderEnum(enumModel),
            _ => throw new InvalidOperationException($"Unsupported generated type model: {model.GetType().Name}")
        };

    private BaseTypeDeclarationSyntax RenderClass(GeneratedClassModel model)
    {
        var declaration = SyntaxFactory.ClassDeclaration(model.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
            .AddAttributeLists(GeneratedCodeAttributeList)
            .AddAttributeLists(ExcludeFromCodeCoverageAttributeList)
            .WithLeadingTrivia(CodeGenerationUtilities.CreateSummaryTrivia(model.Summary));

        if (model.IsKubernetesEntity)
        {
            declaration = declaration.AddAttributeLists(KubernetesEntityAttributeList);
        }

        foreach (var baseType in model.BaseTypes)
        {
            declaration = declaration.AddBaseListTypes(
                SyntaxFactory.SimpleBaseType(RenderTypeSyntax(baseType)));
        }

        if (model.Fields.Count > 0)
        {
            declaration = declaration.AddMembers([.. model.Fields.Select(RenderField)]);
        }

        if (model.Properties.Count > 0)
        {
            declaration = declaration.AddMembers([.. model.Properties.Select(RenderProperty)]);
        }

        return declaration;
    }

    private BaseTypeDeclarationSyntax RenderEnum(GeneratedEnumModel model)
    {
        var declaration = SyntaxFactory.EnumDeclaration(model.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddAttributeLists(GeneratedCodeAttributeList)
            .AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(
                SyntaxFactory.Attribute(JsonConverterAttributeName)
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.TypeOfExpression(
                                        SyntaxFactory.GenericName(
                                            ((IdentifierNameSyntax)JsonStringEnumConverterName).Identifier,
                                            SyntaxFactory.TypeArgumentList(
                                                SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                                                    SyntaxFactory.IdentifierName(model.Name)))))))))))
            .WithLeadingTrivia(CodeGenerationUtilities.CreateSummaryTrivia(model.Summary));

        if (model.Members.Count > 0)
        {
            declaration = declaration.AddMembers([.. model.Members.Select(RenderEnumMember)]);
        }

        return declaration;
    }

    private static FieldDeclarationSyntax RenderField(GeneratedFieldModel model)
        => SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(RenderTypeSyntax(model.Type))
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator(model.Name)
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(model.Value)))))))
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

    private PropertyDeclarationSyntax RenderProperty(GeneratedPropertyModel model)
    {
        if (model.IsExtensionData)
        {
            return SyntaxFactory.PropertyDeclaration(
                    SyntaxFactory.NullableType(RenderTypeSyntax(model.Type)),
                    SyntaxFactory.Identifier(model.Name))
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithAccessorList(AutoPropertyAccessorList)
                .WithAttributeLists(
                    SyntaxFactory.SingletonList(
                        SyntaxFactory.AttributeList(
                            SyntaxFactory.SingletonSeparatedList(SyntaxFactory.Attribute(JsonExtensionDataAttributeName)))))
                .WithLeadingTrivia(CodeGenerationUtilities.CreateSummaryTrivia(model.Summary));
        }

        PropertyDeclarationSyntax declaration = SyntaxFactory.PropertyDeclaration(
                model.IsNullable
                    ? SyntaxFactory.NullableType(RenderTypeSyntax(model.Type))
                    : RenderTypeSyntax(model.Type),
                model.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithAccessorList(AutoPropertyAccessorList)
            .AddAttributeLists(
                SyntaxFactory.AttributeList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("JsonPropertyName"))
                            .WithArgumentList(
                                SyntaxFactory.AttributeArgumentList(
                                    SyntaxFactory.SingletonSeparatedList(
                                        SyntaxFactory.AttributeArgument(
                                            SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(model.JsonName)))))))))
            .WithLeadingTrivia(CodeGenerationUtilities.CreateSummaryTrivia(model.Summary));

        if (model.IsRequired && model.DefaultValue == null)
        {
            declaration = declaration.AddModifiers(SyntaxFactory.Token(SyntaxKind.RequiredKeyword));
        }

        if (!string.IsNullOrEmpty(model.DefaultValue))
        {
            declaration = declaration.WithInitializer(
                    SyntaxFactory.EqualsValueClause(
                        SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(model.DefaultValue!))))
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
        }

        return declaration;
    }

    private static EnumMemberDeclarationSyntax RenderEnumMember(GeneratedEnumMemberModel model)
        => SyntaxFactory.EnumMemberDeclaration(SyntaxFactory.Identifier(model.Name))
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
                                                    SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(model.Value)))))),
                                SyntaxFactory.Attribute(JsonStringEnumMemberNameAttributeName)
                                    .WithArgumentList(
                                        SyntaxFactory.AttributeArgumentList(
                                            SyntaxFactory.SingletonSeparatedList(
                                                SyntaxFactory.AttributeArgument(
                                                    SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(model.Value))))))
                            ]))))
            .WithLeadingTrivia(CodeGenerationUtilities.CreateSummaryTrivia(model.Summary));

    private static TypeSyntax RenderTypeSyntax(GeneratedTypeReference type)
        => type switch
        {
            GeneratedNamedTypeReference namedType => RenderNamedTypeSyntax(namedType.Name),
            GeneratedGenericTypeReference genericType => RenderGenericTypeSyntax(genericType),
            GeneratedNullableTypeReference nullableType => SyntaxFactory.NullableType(RenderTypeSyntax(nullableType.InnerType)),
            _ => throw new InvalidOperationException($"Unsupported generated type reference: {type.GetType().Name}")
        };

    private static TypeSyntax RenderGenericTypeSyntax(GeneratedGenericTypeReference genericType)
    {
        var baseName = RenderNameSyntax(genericType.Name);
        var typeArgumentList = SyntaxFactory.TypeArgumentList(
            SyntaxFactory.SeparatedList(genericType.TypeArguments.Select(RenderTypeSyntax)));

        if (baseName is QualifiedNameSyntax qualifiedName)
        {
            return qualifiedName.WithRight(
                SyntaxFactory.GenericName(qualifiedName.Right.Identifier, typeArgumentList));
        }

        if (baseName is AliasQualifiedNameSyntax aliasQualifiedName)
        {
            return aliasQualifiedName.WithName(
                SyntaxFactory.GenericName(aliasQualifiedName.Name.Identifier, typeArgumentList));
        }

        return SyntaxFactory.GenericName(((IdentifierNameSyntax)baseName).Identifier, typeArgumentList);
    }

    private static TypeSyntax RenderNamedTypeSyntax(string name)
        => name switch
        {
            "bool" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.BoolKeyword)),
            "double" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.DoubleKeyword)),
            "int" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)),
            "long" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.LongKeyword)),
            "object" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ObjectKeyword)),
            "string" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword)),
            _ => RenderNameSyntax(name) as TypeSyntax
                ?? throw new InvalidOperationException($"Unable to render type syntax for '{name}'.")
        };

    private static NameSyntax RenderNameSyntax(string name)
    {
        var segments = name.Split('.');
        NameSyntax? current = null;

        for (var i = 0; i < segments.Length; i++)
        {
            var segment = segments[i];
            var identifier = SyntaxFactory.Identifier(segment);
            current = current is null
                ? SyntaxFactory.IdentifierName(identifier)
                : SyntaxFactory.QualifiedName(current, SyntaxFactory.IdentifierName(identifier));
        }

        return current ?? SyntaxFactory.IdentifierName(name);
    }
}
