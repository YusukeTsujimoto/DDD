﻿using System.Collections.Generic;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
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
    }
}
