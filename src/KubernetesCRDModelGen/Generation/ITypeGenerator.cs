using System.Collections.Generic;
using KubernetesCRDModelGen.Names;
using KubernetesCRDModelGen.Spec;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Interfaces;


namespace KubernetesCRDModelGen.Generation
{
    public interface ITypeGenerator : IYardarmTypeInfoProvider
    {
        ITypeGenerator? Parent { get; }

        SyntaxTree? GenerateSyntaxTree();

        IEnumerable<MemberDeclarationSyntax> Generate();

        QualifiedNameSyntax? GetChildName<TChild>(ILocatedOpenApiElement<TChild> child, NameKind nameKind)
            where TChild : IOpenApiElement;
    }
}
