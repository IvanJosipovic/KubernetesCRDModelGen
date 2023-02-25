using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Interfaces;
using Yardarm.Names;
using Yardarm.Spec;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Yardarm.Generation.Schema
{
    public class JsonNodeGenerator : ITypeGenerator
    {
        public static JsonNodeGenerator Instance { get; } = new JsonNodeGenerator();

        public ITypeGenerator? Parent => null;

        public YardarmTypeInfo TypeInfo { get; } = new YardarmTypeInfo(
            SimpleBaseType(QualifiedName(ParseName("System.Text.Json.Nodes"), IdentifierName("JsonNode"))).Type,
            NameKind.Struct,
            isGenerated: false);

        public SyntaxTree? GenerateSyntaxTree() => null;

        public IEnumerable<MemberDeclarationSyntax> Generate() => Enumerable.Empty<MemberDeclarationSyntax>();

        public QualifiedNameSyntax? GetChildName<TChild>(ILocatedOpenApiElement<TChild> child, NameKind nameKind)
            where TChild : IOpenApiElement =>
            null;
    }
}
