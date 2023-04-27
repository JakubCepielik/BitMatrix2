namespace BitMatrix2
{

    using System;
    using System.Collections;
    using System.Collections.Generic;

    public partial class BitMatrix : IEquatable<BitMatrix>
    {
        public bool Equals(BitMatrix other)
        {
            if ((object)other == null) return false;
            if (this.NumberOfColumns == other.NumberOfColumns && this.NumberOfRows == other.NumberOfRows && this.data.Length == other.data.Length)
            {
                for(int i=0; i<this.data.Length; i++)
                {
                    if (this.data[i] != other.data[i]) return false;
                }
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is BitMatrix) return Equals((BitMatrix)obj);
            else return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(data, NumberOfRows, NumberOfColumns);
        }

        public static bool operator ==(BitMatrix left, BitMatrix right)
        {
            return EqualityComparer<BitMatrix>.Default.Equals(left, right);
        }

        public static bool operator !=(BitMatrix left, BitMatrix right)
        {
            return !(left == right);
        }
    }
}