using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Shamrik.DI.Lifetime.Services;

namespace Shamrik.DI.Lifetime.Middlewares
{
    public class CounterMiddleware
    {
        private readonly RequestDelegate _next;

        private int CounterRequests = 0;

        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService service, ICounter counter2)
        {
            CounterRequests++;
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync(
                $"Запрос {CounterRequests}; Counter: {counter.Value}; Counter2: {counter2.Value}; Service: {service.Counter.Value}");
        }
    }
}