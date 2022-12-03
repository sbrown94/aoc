﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwentyTwo;
using TwentyTwo.Days;

Host.CreateDefaultBuilder(args)
    .ConfigureServices(
        services =>
            services
                .AddSingleton<IWorker, Worker>()
                .AddSingleton<IDay, DayThree>())
                    .Build()
                        .Services.GetService<IWorker>().Run();