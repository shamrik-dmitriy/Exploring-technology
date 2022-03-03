using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Shamrik.Configuration.FileProviders.Json
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("colorsettings.json")
                .AddJsonFile("overridecolorsettings.json");
            _configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var backgroundColor = _configuration["background-color"];
            var foregroundColor = _configuration["foreground-color"];
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<p style='background-color:{backgroundColor}; color:{foregroundColor};'>Hello! World!</p>");
                backgroundColor = _configuration["color:background-color:color"];
                foregroundColor = _configuration["color:foreground-color:color"];
                await context.Response.WriteAsync($"<p style='background-color:{backgroundColor}; color:{foregroundColor};'>Hello! World! 2!</p>");
            });
        }
    }
}