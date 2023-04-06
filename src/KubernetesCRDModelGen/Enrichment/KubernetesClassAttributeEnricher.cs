using KubernetesCRDModelGen.Enrichment.Schema;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.Enrichment;

/// <summary>
/// Adds KubernetesEntityAttribute to the root object schemas, but runs after the <see cref="BaseTypeEnricher"/>.
/// </summary>
public class KubernetesClassAttributeEnricher : IOpenApiSyntaxNodeEnricher<ClassDeclarationSyntax, OpenApiSchema>
{
    private readonly GenerationContext _context;

    static NameSyntax Attribute { get; } = QualifiedName(QualifiedName(IdentifierName("k8s"),IdentifierName("Models")),IdentifierName("KubernetesEntityAttribute"));

    public Type[] ExecuteAfter { get; } =
    {
        typeof(BaseTypeEnricher)
    };

    public KubernetesClassAttributeEnricher(GenerationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public ClassDeclarationSyntax Enrich(ClassDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent != null)
        {
            return target;
        }

        return target.AddAttributeLists(AttributeList().AddAttributes(
             SyntaxFactory.Attribute(Attribute,
                AttributeArgumentList(
                    SeparatedList<AttributeArgumentSyntax>(
                    new SyntaxNodeOrToken[]{
                        AttributeArgument(
                            NameEquals(IdentifierName("ApiVersion")),
                            null,
                            LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                Literal((context.LocatedElement.Element.Properties["KubeApiVersion"].Default as OpenApiString).Value)
                            )
                        ),
                        Token(SyntaxKind.CommaToken),
                        AttributeArgument(
                            NameEquals(IdentifierName("Group")),
                            null,
                            LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                Literal((context.LocatedElement.Element.Properties["KubeGroup"].Default as OpenApiString).Value)
                            )
                        ),
                        Token(SyntaxKind.CommaToken),
                        AttributeArgument(
                            NameEquals(IdentifierName("Kind")),
                            null,
                            LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                Literal((context.LocatedElement.Element.Properties["KubeKind"].Default as OpenApiString).Value)
                            )
                        ),
                        Token(SyntaxKind.CommaToken),
                        AttributeArgument(
                            NameEquals(IdentifierName("PluralName")),
                            null,
                            LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                Literal((context.LocatedElement.Element.Properties["KubePluralName"].Default as OpenApiString).Value)
                            )
                        )
                    }
                    )
                )
            ))
             .WithTrailingTrivia(ElasticCarriageReturnLineFeed));
    }
}
