using Ddd.Domain.Repositories;
using Ddd.Domain.ValueObjects;
using System;

namespace Ddd.Infrastructure.Fake
{
    internal sealed class SensorFake : ISensorRepository
    {
        private Random _random = new Random();

        public MeasureValue GetData()
        {
            return new MeasureValue(_random.Next(0, 3) + _random.NextDouble().ToSingle());
        }
    }
}
