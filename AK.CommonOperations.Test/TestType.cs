using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.CommonOperations.Test
{
    public class TestType : IEquatable<TestType>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string NullProperty { get; set; }

        public DateTime DateTimeProperty { get; set; }

        public Guid GuidProperty { get; set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(TestType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Id == Id && Equals(other.Name, Name) && Equals(other.NullProperty, NullProperty) && other.DateTimeProperty.Equals(DateTimeProperty) && other.GuidProperty.Equals(GuidProperty);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TestType)) return false;
            return Equals((TestType)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = Id;
                result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                result = (result * 397) ^ (NullProperty != null ? NullProperty.GetHashCode() : 0);
                result = (result * 397) ^ DateTimeProperty.GetHashCode();
                result = (result * 397) ^ GuidProperty.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(TestType left, TestType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TestType left, TestType right)
        {
            return !Equals(left, right);
        }
    }
}
