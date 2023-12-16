using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwentyThree;
using TwentyThree.Days;

Host.CreateDefaultBuilder(args)
    .ConfigureServices(
        services =>
            services
                .AddSingleton<IWorker, Worker>()
                .AddSingleton<IDay, DayOne>())
                    .Build()
                        .Services.GetService<IWorker>().Run();