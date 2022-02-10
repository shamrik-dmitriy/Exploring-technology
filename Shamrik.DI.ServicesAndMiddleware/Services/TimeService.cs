using System;

namespace Shamrik.DI.ServicesAndMiddleware.Services
{
    public class TimeService
    {
        public TimeService()
        {
            Time = DateTime.Now.ToString();
        }

        public string Time { get; }
    }
}