using KubernetesCRDModelGen.Enrichment;
using Microsoft.Extensions.DependencyInjection;
using Yardarm;
using Yardarm.Enrichment;

namespace KubernetesCRDModelGen;

public class KubernetesExtension : YardarmExtension {
    public override IServiceCollection ConfigureServices(IServiceCollection services) {
        services
            .AddOpenApiSyntaxNodeEnricher<KubernetesEntityEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesFieldEnricher>()
        ;

        return services;
    }
}
