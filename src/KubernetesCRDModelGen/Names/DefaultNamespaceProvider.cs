using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using KubernetesCRDModelGen.Names.Internal;
using KubernetesCRDModelGen.Spec;

namespace KubernetesCRDModelGen.Names
{
    public class DefaultNamespaceProvider : INamespaceProvider
    {
        private readonly IRootNamespace _rootNamespace;
        private readonly IResponsesNamespace _responsesNamespace;
        private readonly IRequestsNamespace _requestsNamespace;
        private readonly IAuthenticationNamespace _authenticationNamespace;
        private readonly IApiNamespace _apiNamespace;

        private readonly NameSyntax _headersNamespace;
        private readonly NameSyntax _modelsNamespace;
        private readonly NameSyntax _parametersNamespace;

        public DefaultNamespaceProvider(IRootNamespace rootNamespace, IResponsesNamespace responsesNamespace,
            IAuthenticationNamespace authenticationNamespace, IRequestsNamespace requestsNamespace,
            IApiNamespace apiNamespace)
        {
            ArgumentNullException.ThrowIfNull(rootNamespace);
            ArgumentNullException.ThrowIfNull(responsesNamespace);
            ArgumentNullException.ThrowIfNull(authenticationNamespace);
            ArgumentNullException.ThrowIfNull(requestsNamespace);
            ArgumentNullException.ThrowIfNull(apiNamespace);

            _rootNamespace = rootNamespace;
            _responsesNamespace = responsesNamespace;
            _authenticationNamespace = authenticationNamespace;
            _requestsNamespace = requestsNamespace;
            _apiNamespace = apiNamespace;

            _headersNamespace = SyntaxFactory.QualifiedName(_responsesNamespace.Name, SyntaxFactory.IdentifierName("Headers"));
            _modelsNamespace = SyntaxFactory.QualifiedName(rootNamespace.Name, SyntaxFactory.IdentifierName("Models"));
            _parametersNamespace = SyntaxFactory.QualifiedName(_requestsNamespace.Name, SyntaxFactory.IdentifierName("Parameters"));
        }

        public NameSyntax GetNamespace(ILocatedOpenApiElement element) =>
            element switch
            {
                ILocatedOpenApiElement<OpenApiHeader> header => GetHeaderNamespace(header),
                ILocatedOpenApiElement<OpenApiMediaType> mediaType => GetMediaTypeNamespace(mediaType),
                ILocatedOpenApiElement<OpenApiOperation> operation => GetOperationNamespace(operation),
                ILocatedOpenApiElement<OpenApiParameter> parameter => GetParameterNamespace(parameter),
                ILocatedOpenApiElement<OpenApiUnknownResponse> response => GetUnknownResponseNamespace(response),
                ILocatedOpenApiElement<OpenApiResponse> response => GetResponseNamespace(response),
                ILocatedOpenApiElement<OpenApiResponses> responses => GetResponsesNamespace(responses),
                ILocatedOpenApiElement<OpenApiSchema> schema => GetSchemaNamespace(schema),
                ILocatedOpenApiElement<OpenApiSecurityScheme> securityScheme => GetSecuritySchemeNamespace(securityScheme),
                ILocatedOpenApiElement<OpenApiTag> tag => GetTagNamespace(tag),
                _ => throw new InvalidOperationException($"Element type {element.Element.GetType()} doesn't have a namespace.")
            };

        protected virtual NameSyntax GetHeaderNamespace(ILocatedOpenApiElement<OpenApiHeader> header) =>
            _headersNamespace;

        protected virtual NameSyntax GetMediaTypeNamespace(ILocatedOpenApiElement<OpenApiMediaType> mediaType) =>
            _requestsNamespace.Name;

        protected virtual NameSyntax GetOperationNamespace(ILocatedOpenApiElement<OpenApiOperation> operation) =>
            _requestsNamespace.Name;

        protected virtual NameSyntax GetParameterNamespace(ILocatedOpenApiElement<OpenApiParameter> operation) =>
            _parametersNamespace;

        protected virtual NameSyntax GetResponseNamespace(ILocatedOpenApiElement<OpenApiResponse> response) =>
            _responsesNamespace.Name;

        protected virtual NameSyntax GetResponsesNamespace(ILocatedOpenApiElement<OpenApiResponses> responses) =>
            _responsesNamespace.Name;

        protected virtual NameSyntax GetSchemaNamespace(ILocatedOpenApiElement<OpenApiSchema> schema)
        {
            if (schema.Element.Properties.TryGetValue("KubeGroup", out var openApiSchema))
            {
                return SyntaxFactory.QualifiedName(_rootNamespace.Name, SyntaxFactory.IdentifierName((openApiSchema.Default as OpenApiString).Value));
            }
            return _modelsNamespace;
        }

        protected virtual NameSyntax GetSecuritySchemeNamespace(ILocatedOpenApiElement<OpenApiSecurityScheme> schema) =>
            _authenticationNamespace.Name;

        protected virtual NameSyntax GetTagNamespace(ILocatedOpenApiElement<OpenApiTag> tag) =>
            _apiNamespace.Name;

        protected virtual NameSyntax GetUnknownResponseNamespace(ILocatedOpenApiElement<OpenApiUnknownResponse> responses) =>
            _responsesNamespace.Name;
    }
}
