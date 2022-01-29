using Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker.Worker>();
    })
    .Build();

await host.RunAsync();
