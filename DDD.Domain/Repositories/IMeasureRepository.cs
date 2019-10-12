using Ddd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ddd.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
        IReadOnlyList<MeasureEntity> GetData();
        void Save(MeasureEntity entity);
    }
}
