using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SingletoneObjectsAndScopedServices.Services;

namespace SingletoneObjectsAndScopedServices.Middlewares
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;

        private TimeService _timeService;

        public TimerMiddleware(RequestDelegate next, TimeService service)
        {
            _next = next;
            _timeService = service;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            context.Response.WriteAsync($"Current time: {_timeService?.GetTime()}");
        }
    }
}