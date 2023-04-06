using System.Collections.Generic;
using KubernetesCRDModelGen.Spec;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;

namespace KubernetesCRDModelGen.Enrichment.Schema
{
    public interface ISchemaBaseTypeRegistry
    {
        void AddBaseType(ILocatedOpenApiElement<OpenApiSchema> schema, BaseTypeSyntax type);

        IEnumerable<BaseTypeSyntax> GetBaseTypes(ILocatedOpenApiElement<OpenApiSchema> schema);
    }
}
