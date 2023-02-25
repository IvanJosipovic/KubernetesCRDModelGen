using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
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
/// Adds Base classes to object schemas, but runs after the <see cref="BaseTypeEnricher"/>.
/// </summary>
public class KubernetesClassBaseEnricher : IOpenApiSyntaxNodeEnricher<ClassDeclarationSyntax, OpenApiSchema>
{
    readonly GenerationContext _context;

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

    public KubernetesClassBaseEnricher(GenerationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public ClassDeclarationSyntax Enrich(ClassDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent != null)
        {
            return target;
        }

        // Add IKubernetesObject
        target = target.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.QualifiedName(SyntaxFactory.ParseName("k8s"), SyntaxFactory.IdentifierName("IKubernetesObject"))));

        // Remove duplicate Metadata Model
        var classes = target.Members.Where(x => x is ClassDeclarationSyntax clss && clss.Identifier.ValueText == "MetadataModel").First();

        target = target.RemoveNode(classes, SyntaxRemoveOptions.KeepNoTrivia);

        return target;
    }
}
