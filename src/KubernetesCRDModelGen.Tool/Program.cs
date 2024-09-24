using KubernetesCRDModelGen;

namespace Worker;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        builder.Logging.SetMinimumLevel(LogLevel.Debug);
        builder.Logging.AddFilter("Default", LogLevel.Debug);
        builder.Logging.AddFilter("Microsoft", LogLevel.Warning);
        builder.Logging.AddFilter("Microsoft.Hosting.Lifetime", LogLevel.Warning);

        builder.Services.AddHostedService<Worker>();
        builder.Services.AddSingleton<IGenerator, Generator>();

        var host = builder.Build();
        host.Run();
    }
}