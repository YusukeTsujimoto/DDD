using Ddd.Domain.Repositories;
using Ddd.Infrastructure.Fake;

namespace Ddd.Infrastructure
{
    public static class Factories
    {
        public static ISensorRepository CreateSensorRepository()
        {
            return new SensorFake();
        }

        public static IMeasureRepository CreateMeasureRepository()
        {
            return new MeasureFake();
        }
    }
}
