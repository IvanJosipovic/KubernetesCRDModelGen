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
    public class BooleanSchemaGenerator : ITypeGenerator
    {
        public static BooleanSchemaGenerator Instance { get; } = new BooleanSchemaGenerator();

        public ITypeGenerator? Parent => null;

        public YardarmTypeInfo TypeInfo { get; } = new YardarmTypeInfo(
            SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.BoolKeyword)),
            NameKind.Struct,
            isGenerated: false);

        public SyntaxTree? GenerateSyntaxTree() => null;

        public IEnumerable<MemberDeclarationSyntax> Generate() =>
            Enumerable.Empty<MemberDeclarationSyntax>();

        public QualifiedNameSyntax? GetChildName<TChild>(ILocatedOpenApiElement<TChild> child, NameKind nameKind)
            where TChild : IOpenApiElement =>
            null;
    }
}
