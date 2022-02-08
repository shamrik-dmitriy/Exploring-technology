using Microsoft.Extensions.DependencyInjection;

namespace Shamrik.DI.ServiceExtension.Services
{
    public static class TimeServiceExtension
    {
        public static void AddTimeService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<TimeService>();
        }
    }
}