using Microsoft.Extensions.Options;

namespace KubernetesCRDModelGen.Sync;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddHostedService<Worker>();

        builder.Services.AddHttpClient(Options.DefaultName).AddStandardResilienceHandler();

        var host = builder.Build();
        host.Run();
    }
}