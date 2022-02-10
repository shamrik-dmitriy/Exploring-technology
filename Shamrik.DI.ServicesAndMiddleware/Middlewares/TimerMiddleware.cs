using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shamrik.DI.ServicesAndMiddleware.Services;

namespace Shamrik.DI.ServicesAndMiddleware.Middlewares
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;

        private TimeService _timeService;

        public TimerMiddleware(RequestDelegate next, TimeService timeService)
        {
            _next = next;
            _timeService = timeService;
        }

        public async Task InvokeAsync1(HttpContext context)
        {
            if (context.Request.Path.Value.ToLower() == "/time")
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync($"Текущее время {_timeService.Time}");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.Value.ToLower() == "/time")
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                var timeService = context.RequestServices.GetService<TimeService>();
                await context.Response.WriteAsync($"Текущее время {timeService?.Time}");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
        
        public async Task InvokeAsync3(HttpContext context, TimeService timeService)
        {
            if (context.Request.Path.Value.ToLower() == "/time")
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync($"Текущее время {timeService?.Time}");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}