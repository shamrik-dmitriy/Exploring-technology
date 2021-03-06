using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shamrik.DI.TransmittingDependencies.ApplicationServices.Services;

namespace Shamrik.DI.TransmittingDependencies.ApplicationServices
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageSender, SmsMessageSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async context =>
            {
                IMessageSender messageSender = app.ApplicationServices.GetService<IMessageSender>();
                context.Response.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync(messageSender.Send());
            });
        }
    }
}