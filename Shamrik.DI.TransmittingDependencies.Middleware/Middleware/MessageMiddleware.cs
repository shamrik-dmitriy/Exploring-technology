using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Shamrik.DI.TransmittingDependencies.Middleware.Services;

namespace Shamrik.DI.TransmittingDependencies.Middleware.Middleware
{
    public class MessageMiddleware
    {
        private readonly RequestDelegate _next;

        public MessageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IMessageSender sender)
        {
            context.Response.ContentType = "text/hmlt;charset=utf-8";
            await context.Response.WriteAsync(sender.Send());
        }
    }
}