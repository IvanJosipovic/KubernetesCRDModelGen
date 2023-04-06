using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using KubernetesCRDModelGen.Enrichment;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace KubernetesCRDModelGen.SystemTextJson
{
    public class JsonCreateDefaultRegistryEnricher : ICreateDefaultRegistryEnricher
    {
        private readonly IJsonSerializationNamespace _jsonSerializationNamespace;

        public JsonCreateDefaultRegistryEnricher(IJsonSerializationNamespace jsonSerializationNamespace)
        {
            _jsonSerializationNamespace = jsonSerializationNamespace ??
                                          throw new ArgumentNullException(nameof(jsonSerializationNamespace));
        }

        public ExpressionSyntax Enrich(ExpressionSyntax target) =>
            InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                    target,
                    GenericName(
                        Identifier("Add"),
                        TypeArgumentList(SingletonSeparatedList<TypeSyntax>(_jsonSerializationNamespace.JsonTypeSerializer)))))
                .AddArgumentListArguments(
                    Argument(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                        _jsonSerializationNamespace.JsonTypeSerializer,
                        IdentifierName("SupportedMediaTypes"))));
    }
}
