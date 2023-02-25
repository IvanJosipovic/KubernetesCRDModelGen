using KubernetesCRDModelGen.Enrichment;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using Yardarm;
using Yardarm.Enrichment;

namespace KubernetesCRDModelGen;

public class KubernetesExtension : YardarmExtension {
    public override IServiceCollection ConfigureServices(IServiceCollection services) {
        services
            .AddOpenApiSyntaxNodeEnricher<KubernetesClassAttributeEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesClassFieldEnricher>()
            .AddOpenApiSyntaxNodeEnricher<KubernetesClassBaseEnricher>()
            .AddOpenApiSyntaxNodeEnricher<MetadataEnricher>()
        ;

        return services;
    }
}
