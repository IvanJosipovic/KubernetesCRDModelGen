﻿using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Yardarm.Spec;

namespace Yardarm.Generation.Schema
{
    public class DefaultSchemaGeneratorFactory : ITypeGeneratorFactory<OpenApiSchema>
    {
        private readonly GenerationContext _context;

        public DefaultSchemaGeneratorFactory(GenerationContext context)
        {
            _context = context;
        }

        public virtual ITypeGenerator Create(ILocatedOpenApiElement<OpenApiSchema> element, ITypeGenerator? parent)
        {
            OpenApiSchema schema = element.Element;

            if (schema.AdditionalProperties != null && schema.AdditionalProperties.Type == "string") {
                return GetDictionaryGenerator(element);
            }

            if (schema.Extensions.TryGetValue("x-kubernetes-preserve-unknown-fields", out var value) && value is OpenApiBoolean boolValue && boolValue.Value) {
                return GetJsonNodeGenerator(element);
            }

            if (schema.Extensions.TryGetValue("x-kubernetes-int-or-string", out var value2) && value2 is OpenApiBoolean boolValue2 && boolValue2.Value) {
                return GetStringOrIntGenerator(element);
            }

            if (schema.AllOf.Count > 0)
            {
                return new AllOfSchemaGenerator(element, _context, parent);
            }

            if (schema.OneOf.Count > 0)
            {
                return new OneOfSchemaGenerator(element, _context, parent);
            }

            return schema.Type switch
            {
                "object" => GetObjectGenerator(element, parent),
                "string" => GetStringGenerator(element, parent),
                "number" => GetNumberGenerator(element, parent),
                "integer" => GetNumberGenerator(element, parent),
                "boolean" => GetBooleanGenerator(element),
                "array" => GetArrayGenerator(element, parent),
                _ => NullSchemaGenerator.Instance
            };
        }

        protected virtual ITypeGenerator GetArrayGenerator(ILocatedOpenApiElement<OpenApiSchema> element, ITypeGenerator? parent) => new ArraySchemaGenerator(element, _context, parent);

        protected virtual ITypeGenerator GetBooleanGenerator(ILocatedOpenApiElement<OpenApiSchema> element) => BooleanSchemaGenerator.Instance;

        protected virtual ITypeGenerator GetNumberGenerator(ILocatedOpenApiElement<OpenApiSchema> element, ITypeGenerator? parent) => new NumberSchemaGenerator(element, _context, parent);

        protected virtual ITypeGenerator GetObjectGenerator(ILocatedOpenApiElement<OpenApiSchema> element, ITypeGenerator? parent) => new ObjectSchemaGenerator(element, _context, parent);

        protected virtual ITypeGenerator GetStringGenerator(ILocatedOpenApiElement<OpenApiSchema> element, ITypeGenerator? parent) => new StringSchemaGenerator(element, _context, parent);

        protected virtual ITypeGenerator GetStringOrIntGenerator(ILocatedOpenApiElement<OpenApiSchema> element) => KubeStringOrIntSchemaGenerator.Instance;

        protected virtual ITypeGenerator GetDictionaryGenerator(ILocatedOpenApiElement<OpenApiSchema> element) => DictionarySchemaGenerator.Instance;
        protected virtual ITypeGenerator GetJsonNodeGenerator(ILocatedOpenApiElement<OpenApiSchema> element) => JsonNodeGenerator.Instance;

    }
}