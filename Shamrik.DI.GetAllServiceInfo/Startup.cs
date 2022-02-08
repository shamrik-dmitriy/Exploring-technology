using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Shamrik.DI.GetAllServiceInfo
{
    public class Startup
    {
        private IServiceCollection _serviceCollection;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _serviceCollection = services;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async context =>
            {
                var sb = new StringBuilder();
                sb.Append("<h1>Список всех сервисов пустого приложения</h1>");
                sb.Append("<table>");
                sb.Append("<tr><th>Type</th><th>LifeTime</th><th>Realization</th></tr>");
                foreach (var service in _serviceCollection)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td>{service.ServiceType.FullName}</td>");
                    sb.Append($"<td>{service.Lifetime}</td>");
                    sb.Append($"<td>{service.ImplementationType?.FullName}</td>");
                    sb.Append("</tr>");
                }

                sb.Append("</table>");
                context.Response.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync(sb.ToString());
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
            });
        }
    }
}