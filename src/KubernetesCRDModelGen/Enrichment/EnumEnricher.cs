using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Yardarm.Enrichment;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.Enrichment;

public class EnumEnricher : IOpenApiSyntaxNodeEnricher<PropertyDeclarationSyntax, OpenApiSchema>
{
    static NameSyntax Attribute { get; } = QualifiedName(QualifiedName(IdentifierName("KubernetesCRDModelGen"), IdentifierName("Models")), IdentifierName("EnumAttribute"));

    public PropertyDeclarationSyntax Enrich(PropertyDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.Element.Enum.Count > 0 || context.Element.Items?.Enum.Count > 0) {

            var options = new List<ExpressionSyntax>();

            foreach (var item in context.Element.Enum.Count > 0 ? context.Element.Enum : context.Element.Items.Enum) {
                options.Add(LiteralExpression(
                    SyntaxKind.StringLiteralExpression,
                    Literal(((OpenApiPrimitive<string>)item).Value)
                ));
            }

            // Create the attribute argument syntax for the string array
            var optionsArray = ArrayCreationExpression(
                ArrayType(
                    ParseTypeName("string"))
                .WithRankSpecifiers(
                    SingletonList(
                        ArrayRankSpecifier(
                            SingletonSeparatedList<ExpressionSyntax>(
                                LiteralExpression(
                                    SyntaxKind.NumericLiteralExpression,
                                    Literal(context.Element.Enum.Count > 0 ? context.Element.Enum.Count : context.Element.Items.Enum.Count)))))))
                .WithInitializer(
                    InitializerExpression(
                        SyntaxKind.ArrayInitializerExpression,
                        SeparatedList(options)));

            return target.AddAttributeLists(AttributeList().AddAttributes(
                        SyntaxFactory.Attribute(Attribute,
                                AttributeArgumentList(
                                    SingletonSeparatedList(
                                        AttributeArgument(optionsArray)))
                       ))
                        .WithTrailingTrivia(ElasticCarriageReturnLineFeed));
        }

        return target;
    }
}
