using Microsoft.Extensions.DependencyInjection;

namespace KubernetesCRDModelGen
{
    public abstract class YardarmExtension
    {
        public abstract IServiceCollection ConfigureServices(IServiceCollection services);
    }
}
