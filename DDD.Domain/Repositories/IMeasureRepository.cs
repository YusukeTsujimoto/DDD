using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
        IReadOnlyList<MeasureEntity> GetData();
    }
}
