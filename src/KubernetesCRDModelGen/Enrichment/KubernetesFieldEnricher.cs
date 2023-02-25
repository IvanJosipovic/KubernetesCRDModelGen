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
/// Adds  object schemas, but runs after the <see cref="BaseTypeEnricher"/>.
/// </summary>
public class KubernetesFieldEnricher : IOpenApiSyntaxNodeEnricher<ClassDeclarationSyntax, OpenApiSchema>
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

    public KubernetesFieldEnricher(GenerationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public ClassDeclarationSyntax Enrich(ClassDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent == null)
        {
            var props = target.Members.Where(x => x is PropertyDeclarationSyntax p &&  Fields.Contains(p.Identifier.ValueText));
            target = target.RemoveNodes(props, SyntaxRemoveOptions.KeepNoTrivia);

            foreach (var field in Fields) {
                target = target.AddMembers(new[] { GetField(field, (context.LocatedElement.Element.Properties[field].Default as OpenApiString).Value ) });
            }
        }

        return target;
    }

    private FieldDeclarationSyntax GetField(string name, string value) {
        // Define the field
        FieldDeclarationSyntax fieldDeclaration = SyntaxFactory.FieldDeclaration(
                SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName("string"))
                    .AddVariables(SyntaxFactory.VariableDeclarator(name)
                        .WithInitializer(SyntaxFactory.EqualsValueClause(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(value))))
            ))
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.ConstKeyword));

        return fieldDeclaration;

    }
}
