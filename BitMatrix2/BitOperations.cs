namespace BitMatrix2
{
    using System;
    using System.Collections;
    using System.Numerics;

    public partial class BitMatrix
    {
        public BitMatrix And(BitMatrix other)
        {
            if (other == null) 
                throw new ArgumentNullException();
            if (NumberOfColumns != other.NumberOfColumns || NumberOfRows != other.NumberOfRows) 
                throw new ArgumentException();

            for (int i = 0; i < data.Length; i++)
                data[i] &= other.data[i];

            return this;
        }

        public BitMatrix Or(BitMatrix other)
        {
            if (other == null)
                throw new ArgumentNullException();
            if (NumberOfColumns != other.NumberOfColumns || NumberOfRows != other.NumberOfRows)
                throw new ArgumentException();

            for (int i = 0; i < data.Length; i++)
                data[i] |= other.data[i];

            return this;
        }

        public BitMatrix Xor(BitMatrix other)
        {
            if (other == null)
                throw new ArgumentNullException();
            if (NumberOfColumns != other.NumberOfColumns || NumberOfRows != other.NumberOfRows)
                throw new ArgumentException();

            for (int i = 0; i < data.Length; i++)
                data[i] ^= other.data[i];

            return this;
        }

        public BitMatrix Not()
        {
            if (this == null)
                throw new ArgumentNullException();
            for (int i = 0; i < data.Length; i++)
                data[i] = !data[i];

            return this;
        }

        public static BitMatrix operator &(BitMatrix left, BitMatrix right)
        {
            if (left == null || right ==  null)
                throw new ArgumentNullException();
            if (left.NumberOfColumns != right.NumberOfColumns || left.NumberOfRows != right.NumberOfRows)
                throw new ArgumentException();
            BitMatrix B = new BitMatrix(left.NumberOfRows, left.NumberOfColumns);
            for (int i = 0; i < left.data.Length; i++)
                B.data[i] = (left.data[i] &= right.data[i]);
            return B; 
        }


        public static BitMatrix operator |(BitMatrix left, BitMatrix right)
        {
            if (left == null || right == null)
                throw new ArgumentNullException();
            if (left.NumberOfColumns != right.NumberOfColumns || left.NumberOfRows != right.NumberOfRows)
                throw new ArgumentException();
            BitMatrix B = new BitMatrix(left.NumberOfRows, left.NumberOfColumns);
            for (int i = 0; i < left.data.Length; i++)
                B.data[i] = (left.data[i] |= right.data[i]);
            return B;
        }


        public static BitMatrix operator ^(BitMatrix left, BitMatrix right)
        {
            if (left == null || right == null)
                throw new ArgumentNullException();
            if (left.NumberOfColumns != right.NumberOfColumns || left.NumberOfRows != right.NumberOfRows)
                throw new ArgumentException();
            BitMatrix tmp = (BitMatrix)left.Clone();
            BitMatrix B = new BitMatrix(left.NumberOfRows, left.NumberOfColumns);
            for (int i = 0; i < left.data.Length; i++)
                B.data[i] = (tmp.data[i] ^= right.data[i]);
            return B;
        }
    }
}
//1 0 1
//1 1 0

//1 1 0
//1 1 0