using KubernetesCRDModelGen;
using Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker.Worker>();
        services.AddSingleton<ICRDGenerator, CRDGenerator>();
    })
    .Build();

await host.RunAsync();
