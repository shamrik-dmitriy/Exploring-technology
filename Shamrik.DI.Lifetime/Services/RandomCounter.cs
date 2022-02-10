using System;

namespace Shamrik.DI.Lifetime.Services
{
    public class RandomCounter : ICounter
    {
        private static Random Random = new Random();

        private int _value;

        public RandomCounter()
        {
            _value = Random.Next(0, 1000000000);
        }

        public int Value => _value;
    }
}