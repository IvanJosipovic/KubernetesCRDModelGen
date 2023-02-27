using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using Yardarm.Enrichment;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.Enrichment;

public class KubernetesMetadataEnricher : IOpenApiSyntaxNodeEnricher<PropertyDeclarationSyntax, OpenApiSchema>
{
    public PropertyDeclarationSyntax Enrich(PropertyDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent?.Parent == null && context.LocatedElement.Key == "metadata") {
            NameSyntax typeName = QualifiedName(
                ParseName("k8s.Models"),
                IdentifierName("V1ObjectMeta"));

            TypeSyntax typeSyntax = ParseTypeName(typeName.ToString());

            return target.WithType(typeSyntax);
        }

        return target;
    }
}
