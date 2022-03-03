using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Shamrik.Configuration.Base
{
    public class Startup
    {
        // Ручное задание конфигурации
       /* public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>()
                {
                    {"firstname","tom"},
                    {"age","12"}
                });

            AppConfiguration = builder.Build();
        }
*/
        // Чтение уже загруженной конфигурации
        public Startup(IConfiguration configuration)
        {
            AppConfiguration = configuration;
        }

        public IConfiguration AppConfiguration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Переопределим настройки
            app.Run(async (context) =>
            {
                var str = new StringBuilder();
                // Ранее заданные настройки конфигурации
                foreach (var provider in ((IConfigurationRoot)AppConfiguration).Providers)
                {
                    str.Append(provider + Environment.NewLine);

                }
                await context.Response.WriteAsync(str.ToString());
                // Ручное задание конфигурации
               /* await context.Response.WriteAsync($"Old conf: {AppConfiguration["firstname"]}{Environment.NewLine}");
                AppConfiguration["firstName"] = "Alice";
                await context.Response.WriteAsync($"New conf: {AppConfiguration["firstname"]}");*/
            });
        }
    }
}