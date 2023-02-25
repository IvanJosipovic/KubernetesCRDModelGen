using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using Yardarm.Enrichment;
using Yardarm.Generation;
using Yardarm.Generation.MediaType;
using Yardarm.Helpers;
using Yardarm.Spec;
using Yardarm.SystemTextJson.Helpers;

namespace KubernetesCRDModelGen.Enrichment;

public class KubernetesFieldEnricher1 : IOpenApiSyntaxNodeEnricher<PropertyDeclarationSyntax, OpenApiSchema>
{
    string[] Fields = new string[]
    {
        "KubeApiVersion",
        "KubeGroup",
        "KubeKind",
        "KubePluralName"
    };

    public PropertyDeclarationSyntax Enrich(PropertyDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent?.Parent == null) {
            if (Fields.Contains(context.LocatedElement.Key)) {
                var value = (context.LocatedElement.Parent as LocatedOpenApiElement<OpenApiSchema>)?.Element.Properties[context.LocatedElement.Key].Default;

            }
        }

        return target;
    }
}
