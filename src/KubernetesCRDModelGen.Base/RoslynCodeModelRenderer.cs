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
    private static readonly AccessorListSyntax AutoPropertyAccessorList = SyntaxFactory.AccessorList(
        SyntaxFactory.List(
            [
                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
            ]));

    public CompilationUnitSyntax RenderCompilationUnit(GeneratedCompilationUnitModel model)
        => RenderCompilationUnit(model.NamespaceName, model.Group, RenderTypes(model.Types));

    public CompilationUnitSyntax RenderCompilationUnit(string @namespace, string group, MemberDeclarationSyntax[] members)
    {
        var namespaceDeclaration = SyntaxFactory.FileScopedNamespaceDeclaration(
                SyntaxFactory.ParseName(CodeGenerationUtilities.CleanIdentifier(@namespace + "." + group, true)!))
            .AddMembers(members);

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
                SyntaxFactory.SimpleBaseType(CodeGenerationUtilities.GetTypeSyntax(baseType)));
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
                                    SyntaxFactory.TypeOfExpression(CodeGenerationUtilities.GetTypeSyntax($"JsonStringEnumConverter<{model.Name}>"))))))))
            .WithLeadingTrivia(CodeGenerationUtilities.CreateSummaryTrivia(model.Summary));

        if (model.Members.Count > 0)
        {
            declaration = declaration.AddMembers([.. model.Members.Select(RenderEnumMember)]);
        }

        return declaration;
    }

    private static FieldDeclarationSyntax RenderField(GeneratedFieldModel model)
        => SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(CodeGenerationUtilities.GetTypeSyntax(model.TypeName))
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
                    SyntaxFactory.NullableType(CodeGenerationUtilities.GetTypeSyntax(model.TypeName)),
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
                    ? SyntaxFactory.NullableType(CodeGenerationUtilities.GetTypeSyntax(model.TypeName))
                    : CodeGenerationUtilities.GetTypeSyntax(model.TypeName),
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
}
