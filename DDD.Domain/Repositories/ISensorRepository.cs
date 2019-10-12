using Ddd.Domain.ValueObjects;

namespace Ddd.Domain.Repositories
{
    public interface ISensorRepository
    {
        MeasureValue GetData();
    }
}
