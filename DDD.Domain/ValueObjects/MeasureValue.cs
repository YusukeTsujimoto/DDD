using System;

namespace Ddd.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public static readonly string UnitName = "m/s";

        public MeasureValue(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public string DisplayValue => Math.Round(Value, 2) + UnitName;

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
