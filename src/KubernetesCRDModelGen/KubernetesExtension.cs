using KubernetesCRDModelGen.Enrichment;
using Microsoft.Extensions.DependencyInjection;

namespace KubernetesCRDModelGen;

public class KubernetesExtension : YardarmExtension {
    public override IServiceCollection ConfigureServices(IServiceCollection services) {
        services
            .AddOpenApiSyntaxNodeEnricher<KubernetesClassAttributeEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesClassFieldEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesClassBaseEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesMetadataEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesEnumEnricher>()
        ;

        return services;
    }
}
