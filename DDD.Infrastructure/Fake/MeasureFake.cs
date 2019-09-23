using System.Collections.Generic;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public IReadOnlyList<MeasureEntity> GetData()
        {
            throw new System.NotImplementedException();
        }

        public MeasureEntity GetLatest()
        {
            return new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f);
        }
    }
}
