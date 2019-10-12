using Ddd.Domain.Repositories;
using Ddd.Domain.ValueObjects;

namespace DDDTest.Tests
{
    internal sealed class SensorMock : ISensorRepository
    {
        public MeasureValue GetData()
        {
            return new MeasureValue(1.23456f);
        }
    }
}
