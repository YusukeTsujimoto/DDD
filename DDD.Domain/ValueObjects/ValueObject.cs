namespace Ddd.Domain.ValueObjects
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            return obj is T value && EqualsCore(value);
        }

        public static bool operator ==(ValueObject<T> left, ValueObject<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValueObject<T> left, ValueObject<T> right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected abstract bool EqualsCore(T value);
    }
}
