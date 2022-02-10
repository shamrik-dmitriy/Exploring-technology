using System;

namespace SingletoneObjectsAndScopedServices.Classes
{
    public class Timer : ITimer
    {
        public Timer()
        {
            Time = DateTime.Now.ToString("hh:mm:ss");
        }

        public string Time { get; }
    }
}