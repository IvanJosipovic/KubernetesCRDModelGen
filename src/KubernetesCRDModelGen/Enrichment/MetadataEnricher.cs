using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using Yardarm.Enrichment;

namespace KubernetesCRDModelGen.Enrichment;

public class MetadataEnricher : IOpenApiSyntaxNodeEnricher<PropertyDeclarationSyntax, OpenApiSchema>
{
    public PropertyDeclarationSyntax Enrich(PropertyDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent?.Parent == null && context.LocatedElement.Key == "metadata") {
            NameSyntax typeName = SyntaxFactory.QualifiedName(
                SyntaxFactory.ParseName("k8s.Models"),
                SyntaxFactory.IdentifierName("V1ObjectMeta"));

            TypeSyntax typeSyntax = SyntaxFactory.ParseTypeName(typeName.ToString());

            return target.WithType(typeSyntax);
        }

        return target;
    }
}
