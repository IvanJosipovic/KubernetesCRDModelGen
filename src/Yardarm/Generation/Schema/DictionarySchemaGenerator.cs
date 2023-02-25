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
    public class DictionarySchemaGenerator : ITypeGenerator
    {
        public static DictionarySchemaGenerator Instance { get; } = new DictionarySchemaGenerator();

        public ITypeGenerator? Parent => null;

        public YardarmTypeInfo TypeInfo { get; } = new YardarmTypeInfo(
            SimpleBaseType(
                QualifiedName(ParseName("System.Collections.Generic"), GenericName(Identifier("IDictionary"))
                    .WithTypeArgumentList(
                        TypeArgumentList(
                            SeparatedList(new List<TypeSyntax>{
                                ParseTypeName("string"),
                                PredefinedType(Token(SyntaxKind.ObjectKeyword))
                            })
                        )
                    )
                )
            ).Type,
            NameKind.Struct,
            isGenerated: false);

        public SyntaxTree? GenerateSyntaxTree() => null;

        public IEnumerable<MemberDeclarationSyntax> Generate() => Enumerable.Empty<MemberDeclarationSyntax>();

        public QualifiedNameSyntax? GetChildName<TChild>(ILocatedOpenApiElement<TChild> child, NameKind nameKind)
            where TChild : IOpenApiElement =>
            null;
    }
}
