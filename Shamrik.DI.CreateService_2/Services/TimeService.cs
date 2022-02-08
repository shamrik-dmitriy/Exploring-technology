using System;

namespace Shamrik.DI.CreateService_2.Services
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToString("h:mm:ss tt zz");
    }
}