using KubernetesCRDModelGen.Enrichment.Schema;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.Enrichment;
/// <summary>
/// Adds Kube* string constant to the root object schemas, but runs after the <see cref="BaseTypeEnricher"/>.
/// </summary>
public class KubernetesClassFieldEnricher : IOpenApiSyntaxNodeEnricher<ClassDeclarationSyntax, OpenApiSchema>
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

    public KubernetesClassFieldEnricher(GenerationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public ClassDeclarationSyntax Enrich(ClassDeclarationSyntax target, OpenApiEnrichmentContext<OpenApiSchema> context)
    {
        if (context.LocatedElement.Parent != null)
        {
            return target;
        }

        var props = target.Members.Where(x => x is PropertyDeclarationSyntax p &&  Fields.Contains(p.Identifier.ValueText));
        target = target.RemoveNodes(props, SyntaxRemoveOptions.KeepNoTrivia);

        foreach (var field in Fields) {
            target = target.AddMembers(new[] { GetField(field, (context.LocatedElement.Element.Properties[field].Default as OpenApiString).Value ) });
        }

        return target;
    }

    private FieldDeclarationSyntax GetField(string name, string value) {
        return FieldDeclaration(
                VariableDeclaration(ParseTypeName("string"))
                    .AddVariables(VariableDeclarator(name)
                        .WithInitializer(EqualsValueClause(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(value))))
            ))
            .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.ConstKeyword));
    }
}
