using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwentyTwo;
using TwentyTwo.Days;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(
    services =>
        services
        .AddSingleton<IWorker, Worker>()
        .AddSingleton<IDay, DayOne>());

using var host = builder.Build();

host.Services.GetService<IWorker>().Run();