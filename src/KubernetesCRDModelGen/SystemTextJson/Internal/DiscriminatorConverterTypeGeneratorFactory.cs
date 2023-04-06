using System;
using Microsoft.OpenApi.Models;
using KubernetesCRDModelGen.Generation;
using KubernetesCRDModelGen.Names;
using KubernetesCRDModelGen.Spec;

namespace KubernetesCRDModelGen.SystemTextJson.Internal
{
    internal class DiscriminatorConverterTypeGeneratorFactory : ITypeGeneratorFactory<OpenApiSchema, SystemTextJsonGeneratorCategory>
    {
        private readonly GenerationContext _context;
        private readonly IJsonSerializationNamespace _jsonSerializationNamespace;
        private readonly IRootNamespace _rootNamespace;

        public DiscriminatorConverterTypeGeneratorFactory(GenerationContext context, IJsonSerializationNamespace jsonSerializationNamespace,
            IRootNamespace rootNamespace)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _jsonSerializationNamespace = jsonSerializationNamespace ?? throw new ArgumentNullException(nameof(jsonSerializationNamespace));
            _rootNamespace = rootNamespace ?? throw new ArgumentNullException(nameof(rootNamespace));
        }

        public ITypeGenerator Create(ILocatedOpenApiElement<OpenApiSchema> element, ITypeGenerator? parent) =>
            new DiscriminatorConverterTypeGenerator(element, _context, parent, _jsonSerializationNamespace, _rootNamespace);
    }
}
