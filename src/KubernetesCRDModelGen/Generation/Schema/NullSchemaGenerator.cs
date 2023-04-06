using System.Collections.Generic;
using System.Linq;
using KubernetesCRDModelGen.Names;
using KubernetesCRDModelGen.Spec;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Interfaces;

namespace KubernetesCRDModelGen.Generation.Schema
{
    public class NullSchemaGenerator : ITypeGenerator
    {
        public static NullSchemaGenerator Instance { get; } = new NullSchemaGenerator();

        public ITypeGenerator? Parent => null;

        private NullSchemaGenerator()
        {
        }

        public YardarmTypeInfo TypeInfo { get; } = new YardarmTypeInfo(
            SyntaxFactory.IdentifierName("dynamic"),
            isGenerated: false);

        public SyntaxTree? GenerateSyntaxTree() => null;

        public IEnumerable<MemberDeclarationSyntax> Generate() =>
            Enumerable.Empty<MemberDeclarationSyntax>();

        public QualifiedNameSyntax? GetChildName<TChild>(ILocatedOpenApiElement<TChild> child, NameKind nameKind)
            where TChild : IOpenApiElement =>
            null;
    }
}
