using KubernetesCRDModelGen.Enrichment.Compilation;
using KubernetesCRDModelGen.Enrichment.Packaging;
using KubernetesCRDModelGen.Enrichment.Schema;
using Microsoft.Extensions.DependencyInjection;

namespace KubernetesCRDModelGen.Enrichment
{
    public static class EnricherServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultEnrichers(this IServiceCollection services) =>
            services
                .AddDefaultCompilationEnrichers()
                .AddDefaultPackagingEnrichers()
                //.AddDefaultAuthenticationEnrichers()
                .AddDefaultSchemaEnrichers()
                //.AddDefaultRequestEnrichers()
                //.AddDefaultResponseEnrichers()
                //.AddDefaultTagEnrichers()
                ;

        public static IServiceCollection AddCreateDefaultRegistryEnricher<T>(this IServiceCollection services)
            where T : class, ICreateDefaultRegistryEnricher =>
            services.AddTransient<ICreateDefaultRegistryEnricher, T>();

        public static IServiceCollection AddOpenApiSyntaxNodeEnricher<T>(this IServiceCollection services)
            where T : class, IOpenApiSyntaxNodeEnricher =>
            services.AddTransient<IOpenApiSyntaxNodeEnricher, T>();
    }
}
