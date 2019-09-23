using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public class MeasureEntity
    {
        public MeasureEntity(string measureId, DateTime measureDate, float measureValue)
        {
            MeasureId = measureId ?? throw new ArgumentNullException(nameof(measureId));
            MeasureDate = new MeasureDate(measureDate);
            MeasureValue = new MeasureValue(measureValue);
        }

        public string MeasureId { get; }
        public MeasureDate MeasureDate { get; }
        public MeasureValue MeasureValue { get; }
    }
}
