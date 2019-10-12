using System.Collections.Generic;
using Ddd.Domain.Entities;
using Ddd.Domain.Repositories;

namespace Ddd.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        private static List<MeasureEntity> _entities;

        static MeasureFake()
        {
            _entities = new List<MeasureEntity>
            {
                new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f),
                new MeasureEntity("guidB", "2017/01/01 14:00:00".ToDate(), 2.23456f),
            };
        }

        public IReadOnlyList<MeasureEntity> GetData()
        {
            return _entities;
        }

        public MeasureEntity GetLatest()
        {
            return new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f);
        }

        public void Save(MeasureEntity entity)
        {
            var index = _entities.FindIndex(x => x.MeasureId == entity.MeasureId);
            if (index >= 0)
            {
                _entities[index] = entity;
                return;
            }
            _entities.Add(entity);
        }
    }
}
