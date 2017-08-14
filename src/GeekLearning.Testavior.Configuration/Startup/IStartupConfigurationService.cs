﻿namespace GeekLearning.Testavior.Configuration.Startup
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using System;

    public interface IStartupConfigurationService
    {
        IServiceProvider ServiceProvider { get; }

        void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IConfigurationRoot configuration);

        void ConfigureEnvironment(IHostingEnvironment env);

        void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration);
    }
}
