using KubernetesCRDModelGen.Packaging;
using Microsoft.Extensions.DependencyInjection;

namespace KubernetesCRDModelGen
{
    public class YardarmContext
    {
        public YardarmGenerationSettings Settings { get; }
        public IServiceProvider GenerationServices { get; }

        /// <summary>
        /// Details about the NuGet restore operation, once it is completed.
        /// </summary>
        public NuGetRestoreInfo? NuGetRestoreInfo { get; set; }

        public YardarmContext(IServiceProvider serviceProvider)
        {
            GenerationServices = serviceProvider;
            Settings = serviceProvider.GetRequiredService<YardarmGenerationSettings>();
        }
    }
}
