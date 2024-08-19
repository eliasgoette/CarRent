namespace CarRent.Domain.Common
{
    public class ValueObject : IEquatable<ValueObject>
    {
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(ValueObject? other)
        {
            if(other == null) return false;

            return this == other;
        }

        public bool Equals(Entity other)
        {
            if (other == null) return false;

            if (other.GetType() != this.GetType()) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}