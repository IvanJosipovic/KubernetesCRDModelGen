using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace KubernetesCRDModelGen.Enrichment.Schema
{
    public static class SchemaEnricherServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultSchemaEnrichers(this IServiceCollection services) =>
            services
                .AddOpenApiSyntaxNodeEnricher<RequiredPropertyEnricher>()
                .AddOpenApiSyntaxNodeEnricher<DocumentationPropertyEnricher>()
                .AddOpenApiSyntaxNodeEnricher<BaseTypeEnricher>()
                .AddSchemaEnrichersCore();

        public static IServiceCollection AddSchemaEnrichersCore(this IServiceCollection services)
        {
            services.TryAddSingleton<ISchemaBaseTypeRegistry, SchemaBaseTypeRegistry>();

            return services;
        }
    }
}
