using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using KubernetesCRDModelGen.Spec;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace KubernetesCRDModelGen.Spec
{
    public static class LocatedOpenApiElementExtensions
    {
        //private static readonly ConditionalWeakTable<OpenApiResponses, OpenApiUnknownResponse> _unknownResponses =
        //    new ConditionalWeakTable<OpenApiResponses, OpenApiUnknownResponse>();

        private static readonly OpenApiSchema _defaultSchema = new OpenApiSchema();

        public static bool IsRoot(this ILocatedOpenApiElement element) => element.Parent is null;

        public static bool IsReference<T>(this ILocatedOpenApiElement<T> element)
            where T : IOpenApiReferenceable =>
            element.Element.Reference != null;

        public static ILocatedOpenApiElement<T> CreateRoot<T>(this T rootItem, string key)
            where T : IOpenApiElement =>
            LocatedOpenApiElement.CreateRoot(rootItem, key);

        public static IEnumerable<ILocatedOpenApiElement<T>> CreateRoot<T>(
            this IEnumerable<KeyValuePair<string, T>> rootItems)
            where T : IOpenApiElement =>
            rootItems.Select(p => p.Value.CreateRoot(p.Key));

        public static ILocatedOpenApiElement<T> CreateChild<T>(this ILocatedOpenApiElement element,
            T child, string key)
            where T : IOpenApiElement =>
            new LocatedOpenApiElement<T>(child, key, element);

        public static IEnumerable<ILocatedOpenApiElement> Parents(this ILocatedOpenApiElement element)
        {
            var current = element;
            while (current.Parent != null)
            {
                current = current.Parent;
                yield return current;
            }
        }

        public static ILocatedOpenApiElement<T> ResolveComponentReference<T>(this OpenApiDocument document,
            OpenApiReference reference)
            where T : IOpenApiElement =>
            ((T)document.ResolveReference(reference)).CreateRoot(reference.Id);

        #region GetAllSchemas

        // These methods collect all schemas directly owned by a given object (not a reference), including recursive
        // lookups within schemas.

        public static IEnumerable<ILocatedOpenApiElement<OpenApiSchema>> GetAllSchemas(this OpenApiDocument document) =>
            document.Components.Schemas.CreateRoot().SelectMany(p => p.GetAllSchemas());

        public static IEnumerable<ILocatedOpenApiElement<OpenApiSchema>> GetAllSchemas(
            this ILocatedOpenApiElement<OpenApiSchema> schema)
        {
            yield return schema;

            var itemSchema = schema.GetItemSchema();
            if (itemSchema is not null && !itemSchema.IsReference())
            {
                foreach (var childSchema in itemSchema.GetAllSchemas())
                {
                    yield return childSchema;
                }
            }

            foreach (var childSchema in schema.GetProperties()
                         .Where(p => !p.IsReference())
                         .SelectMany(p => p.GetAllSchemas()))
            {
                yield return childSchema;
            }
        }

        #endregion

        #region Schema

        public static ILocatedOpenApiElement<OpenApiSchema>? GetAdditionalProperties(
            this ILocatedOpenApiElement<OpenApiSchema> schema) =>
            schema.Element.AdditionalProperties != null
                ? schema.CreateChild(schema.Element.AdditionalProperties, "additionalProperties")
                : null;

        public static ILocatedOpenApiElement<OpenApiSchema> GetAdditionalPropertiesOrDefault(
            this ILocatedOpenApiElement<OpenApiSchema> schema) =>
            schema.GetAdditionalProperties() ?? schema.CreateChild(_defaultSchema, "additionalProperties");

        public static ILocatedOpenApiElement<OpenApiSchema>? GetItemSchema(
            this ILocatedOpenApiElement<OpenApiSchema> schema) =>
            schema.Element.Items != null
                ? schema.CreateChild(schema.Element.Items, "items")
                : null;

        public static ILocatedOpenApiElement<OpenApiSchema> GetItemSchemaOrDefault(
            this ILocatedOpenApiElement<OpenApiSchema> schema) =>
            schema.GetItemSchema() ?? schema.CreateChild(_defaultSchema, "items");

        public static IEnumerable<ILocatedOpenApiElement<OpenApiSchema>> GetProperties(
            this ILocatedOpenApiElement<OpenApiSchema> schema) =>
            schema.Element.Properties?
                .Select(p => schema.CreateChild(p.Value, p.Key))
            ?? Enumerable.Empty<ILocatedOpenApiElement<OpenApiSchema>>();

        public static ILocatedOpenApiElement<OpenApiSchema>? GetSchema(
            this ILocatedOpenApiElement<OpenApiHeader> header) =>
            header.Element.Schema != null
                ? header.CreateChild(header.Element.Schema, "schema")
                : null;

        public static ILocatedOpenApiElement<OpenApiSchema> GetSchemaOrDefault(
            this ILocatedOpenApiElement<OpenApiHeader> header) =>
            header.GetSchema() ?? header.CreateChild(_defaultSchema, "schema");

        public static ILocatedOpenApiElement<OpenApiSchema>? GetSchema(
            this ILocatedOpenApiElement<OpenApiMediaType> mediaType) =>
            mediaType.Element.Schema != null
                ? mediaType.CreateChild(mediaType.Element.Schema, "schema")
                : null;

        public static ILocatedOpenApiElement<OpenApiSchema> GetSchemaOrDefault(
            this ILocatedOpenApiElement<OpenApiMediaType> mediaType) =>
            mediaType.GetSchema() ?? mediaType.CreateChild(_defaultSchema, "schema");

        public static ILocatedOpenApiElement<OpenApiSchema>? GetSchema(
            this ILocatedOpenApiElement<OpenApiParameter> parameter) =>
            parameter.Element.Schema != null
                ? parameter.CreateChild(parameter.Element.Schema, "schema")
                : null;

        public static ILocatedOpenApiElement<OpenApiSchema> GetSchemaOrDefault(
            this ILocatedOpenApiElement<OpenApiParameter> parameter) =>
            parameter.GetSchema() ?? parameter.CreateChild(_defaultSchema, "schema");

        #endregion

    }
}
