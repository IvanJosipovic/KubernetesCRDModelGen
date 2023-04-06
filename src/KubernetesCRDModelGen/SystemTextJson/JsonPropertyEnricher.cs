using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using KubernetesCRDModelGen.Enrichment;
using KubernetesCRDModelGen.Generation;
using KubernetesCRDModelGen.Helpers;
using KubernetesCRDModelGen.SystemTextJson.Helpers;

namespace KubernetesCRDModelGen.SystemTextJson
{
    public class JsonPropertyEnricher : IOpenApiSyntaxNodeEnricher<PropertyDeclarationSyntax, OpenApiSchema>
    {
        public PropertyDeclarationSyntax Enrich(PropertyDeclarationSyntax target,
            OpenApiEnrichmentContext<OpenApiSchema> context)
        {
            //if (target.Parent is ClassDeclarationSyntax classDeclaration &&
            //    classDeclaration.GetGeneratorAnnotation() == typeof(RequestMediaTypeGenerator))
            //{
            //    // Don't enrich body properties on the request classes
            //    return target;
            //}

            return target.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(
                SyntaxFactory.Attribute(SystemTextJsonTypes.Serialization.JsonPropertyNameAttributeName).AddArgumentListArguments(
                    SyntaxFactory.AttributeArgument(SyntaxHelpers.StringLiteral(context.LocatedElement.Key))))
                .WithTrailingTrivia(SyntaxFactory.ElasticCarriageReturnLineFeed));
        }
    }
}
