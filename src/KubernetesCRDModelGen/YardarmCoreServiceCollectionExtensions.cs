using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using KubernetesCRDModelGen;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using KubernetesCRDModelGen.Enrichment;
using KubernetesCRDModelGen.Generation;
using KubernetesCRDModelGen.Generation.Schema;
using KubernetesCRDModelGen.Names;
using KubernetesCRDModelGen.Spec;
using KubernetesCRDModelGen.Spec.Internal;
using KubernetesCRDModelGen.Packaging.Internal;
using KubernetesCRDModelGen.Packaging;
using KubernetesCRDModelGen.Generation.Internal;
using KubernetesCRDModelGen.Names.Internal;

namespace KubernetesCRDModelGen
{
    public static class YardarmCoreServiceCollectionExtensions
    {
        public static IServiceCollection AddYardarm(this IServiceCollection services, YardarmGenerationSettings settings, OpenApiDocument document)
        {
            services.AddDefaultEnrichers();

            services.AddTransient<IReferenceGenerator, NuGetReferenceGenerator>();

            // Generators
            services
                .AddTransient<ISyntaxTreeGenerator, AssemblyInfoGenerator>()
                .AddTransient<ISyntaxTreeGenerator, ClientGenerator>()
                .AddTransient<ISyntaxTreeGenerator, SchemaGenerator>()
                .AddTransient<IDependencyGenerator, StandardDependencyGenerator>();

            services.TryAddSingleton<ITypeGeneratorRegistry, TypeGeneratorRegistry>();
            services.TryAdd(new ServiceDescriptor(typeof(ITypeGeneratorRegistry<,>), typeof(TypeGeneratorRegistry<,>), ServiceLifetime.Singleton));
            services.TryAdd(new ServiceDescriptor(typeof(ITypeGeneratorRegistry<>), typeof(PrimaryGeneratorCategory.TypeGeneratorRegistryWrapper<>), ServiceLifetime.Singleton));
            services.TryAdd(new ServiceDescriptor(typeof(ITypeGeneratorFactory<,>), typeof(NoopTypeGeneratorFactory<,>), ServiceLifetime.Singleton));
            services.TryAddTypeGeneratorFactory<OpenApiSchema, DefaultSchemaGeneratorFactory>();

            services.TryAddSingleton<IPackageSpecGenerator, DefaultPackageSpecGenerator>();
            services.TryAddSingleton(serviceProvider => serviceProvider.GetRequiredService<IPackageSpecGenerator>().Generate());

            // Names
            //services.TryAddSingleton<CamelCaseNameFormatter>();
            services.TryAddSingleton<PascalCaseNameFormatter>();
            services.TryAddSingleton<INameFormatterSelector, NameFormatterSelector>();
            services.TryAddSingleton<INamespaceProvider, DefaultNamespaceProvider>();
            services.TryAddSingleton<INameConverterRegistry>(_ => NameConverterRegistry.CreateDefaultRegistry());
            //services.TryAddSingleton<IHttpResponseCodeNameProvider, HttpResponseCodeNameProvider>();
            services.TryAddSingleton<IRootNamespace, RootNamespace>();
            services.TryAddSingleton<IApiNamespace, ApiNamespace>();
            services.TryAddSingleton<IAuthenticationNamespace, AuthenticationNamespace>();
            services.TryAddSingleton<IRequestsNamespace, RequestsNamespace>();
            services.TryAddSingleton<IResponsesNamespace, ResponsesNamespace>();
            services.TryAddSingleton<ISerializationNamespace, SerializationNamespace>()
            ;

            // Other
            services
                .AddLogging()
                .AddTransient<NuGetRestoreProcessor>()
                .AddSingleton(settings)
                .AddTransient<NuGetPacker>();

            services
                .AddSingleton<GenerationContext>()
                .AddTransient<YardarmContext>(serviceProvider => serviceProvider.GetRequiredService<GenerationContext>())
                .AddSingleton(document);

            services.TryAddSingleton<IOpenApiElementRegistry, OpenApiElementRegistry>();

            return services;
        }

        //public static IServiceCollection AddSerializerDescriptor(this IServiceCollection services,
        //    SerializerDescriptor descriptor) =>
        //    services.AddSingleton(descriptor ?? throw new ArgumentNullException(nameof(descriptor)));

        //public static IServiceCollection AddSerializerDescriptor(this IServiceCollection services,
        //    Func<IServiceProvider, SerializerDescriptor> descriptorFactory) =>
        //    services.AddSingleton(descriptorFactory ?? throw new ArgumentNullException(nameof(descriptorFactory)));

        public static void TryAddTypeGeneratorFactory<TElement, TGenerator>(this IServiceCollection services)
            where TElement : IOpenApiElement
            where TGenerator : class, ITypeGeneratorFactory<TElement, PrimaryGeneratorCategory> =>
            services.TryAddTypeGeneratorFactory<TElement, PrimaryGeneratorCategory, TGenerator>();

        public static void TryAddTypeGeneratorFactory<TElement, TGeneratorCategory, TGenerator>(this IServiceCollection services)
            where TElement : IOpenApiElement
            where TGenerator : class, ITypeGeneratorFactory<TElement, TGeneratorCategory> =>
            services.TryAddSingleton<ITypeGeneratorFactory<TElement, TGeneratorCategory>, TGenerator>();
    }
}
