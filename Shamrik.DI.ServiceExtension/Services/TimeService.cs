using System;

namespace Shamrik.DI.ServiceExtension.Services
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToString("h:mm:ss tt zz");
    }
}