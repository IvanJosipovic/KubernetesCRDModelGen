using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Yardarm;
using Yardarm.Enrichment;
using Yardarm.Enrichment.Schema;
using Yardarm.Generation;
using Yardarm.Helpers;
using Yardarm.Names;
using Yardarm.Spec;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.Enrichment;
/// <summary>
/// Adds KubernetesEntityEnricher to object schemas, but runs after the <see cref="BaseTypeEnricher"/>.
/// </summary>
public class KubernetesClassAttributeEnricher : IOpenApiSyntaxNodeEnricher<ClassDeclarationSyntax, OpenApiSchema>
{
    private readonly GenerationContext _context;

    //k8s.Models.KubernetesEntityAttribute
    public static NameSyntax Attribute { get; } = QualifiedName(
    QualifiedName(
            IdentifierName("k8s"),
        IdentifierName("Models")),
    IdentifierName("KubernetesEntityAttribute"));

    public Type[] ExecuteAfter { get; } =
    {
        typeof(BaseTypeEnricher)
    };

    string[] Fields = new string[]
    {
            "KubeApiVersion",
            "KubeGroup",
            "KubeKind",
            "KubePluralName"
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
                SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                    new SyntaxNodeOrToken[]{
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("ApiVersion")),
                            null,
                            SyntaxFactory.LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                SyntaxFactory.Literal((context.LocatedElement.Element.Properties["KubeApiVersion"].Default as OpenApiString).Value)
                            )
                        ),
                        SyntaxFactory.Token(SyntaxKind.CommaToken),
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("Group")),
                            null,
                            SyntaxFactory.LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                SyntaxFactory.Literal((context.LocatedElement.Element.Properties["KubeGroup"].Default as OpenApiString).Value)
                            )
                        ),
                        SyntaxFactory.Token(SyntaxKind.CommaToken),
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("Kind")),
                            null,
                            SyntaxFactory.LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                SyntaxFactory.Literal((context.LocatedElement.Element.Properties["KubeKind"].Default as OpenApiString).Value)
                            )
                        ),
                        SyntaxFactory.Token(SyntaxKind.CommaToken),
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.NameEquals(SyntaxFactory.IdentifierName("PluralName")),
                            null,
                            SyntaxFactory.LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                SyntaxFactory.Literal((context.LocatedElement.Element.Properties["KubePluralName"].Default as OpenApiString).Value)
                            )
                        )
                    }
                    )
                )
            ))
             .WithTrailingTrivia(ElasticCarriageReturnLineFeed));
    }
}
