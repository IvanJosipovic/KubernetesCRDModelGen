using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using Yardarm;
using Yardarm.Enrichment;
using Yardarm.Enrichment.Schema;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.Enrichment;

/// <summary>
/// Adds Base classes to the root object schemas, but runs after the <see cref="BaseTypeEnricher"/>.
/// </summary>
public class KubernetesClassBaseEnricher : IOpenApiSyntaxNodeEnricher<ClassDeclarationSyntax, OpenApiSchema>
{
    readonly GenerationContext _context;

    static readonly SimpleBaseTypeSyntax kubeObject = SimpleBaseType(QualifiedName(ParseName("k8s"), IdentifierName("IKubernetesObject")));

    static readonly SimpleBaseTypeSyntax genericKubeObject = SimpleBaseType(
        QualifiedName(ParseName("k8s"),GenericName(Identifier("IKubernetesObject"))
            .WithTypeArgumentList(
                TypeArgumentList(
                    SingletonSeparatedList<TypeSyntax>(
                        QualifiedName(
                            ParseName("k8s.Models"),
                            IdentifierName("V1ObjectMeta")
                        )
                    )
                )
            )
        )
    );

    public Type[] ExecuteAfter { get; } =
    {
        typeof(BaseTypeEnricher)
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
        target = target.AddBaseListTypes(kubeObject);

        // Remove duplicate Metadata Model that was generated
        var classes = target.Members.First(x => x is ClassDeclarationSyntax clss && clss.Identifier.ValueText == "MetadataModel");

        target = target.RemoveNode(classes, SyntaxRemoveOptions.KeepNoTrivia);

        // Add IKubernetesObject<V1ObjectMeta>
        target = target.AddBaseListTypes(genericKubeObject);

        // Add ISpec<T>
        var specModel = target.Members.FirstOrDefault(x => x is ClassDeclarationSyntax clss && clss.Identifier.ValueText == "SpecModel") as ClassDeclarationSyntax;

        if (specModel != null) {
            var type = SimpleBaseType(
                            QualifiedName(ParseName("k8s"), GenericName(Identifier("ISpec"))
                                .WithTypeArgumentList(
                                    TypeArgumentList(
                                        SingletonSeparatedList<TypeSyntax>(
                                            QualifiedName(
                                                IdentifierName(((ClassDeclarationSyntax)specModel.Identifier.Parent.Parent).Identifier),
                                                IdentifierName(specModel.Identifier.ValueText)
                                            )
                                        )
                                    )
                                )
                            )
                        );

            target = target.AddBaseListTypes(type);
        }

        return target;
    }
}
