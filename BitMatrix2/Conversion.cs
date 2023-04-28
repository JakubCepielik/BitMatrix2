namespace BitMatrix2
{
    using System;
    using System.Collections;
    using System.Numerics;

    public partial class BitMatrix
    {
        public static explicit operator BitMatrix(int[,] matrix)
        {
            if (matrix.Length == 0)
                throw new ArgumentOutOfRangeException();
            if (matrix == null)
                throw new NullReferenceException();
            int[] matrix2 = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            int i = 0;
            foreach (var item in matrix)
            {
                matrix2[i] = item;
                i++;
            }
            return new BitMatrix(matrix.GetLength(0), matrix.GetLength(1), matrix2);
        }

        public static implicit operator int[,](BitMatrix matrix)
        {
            int[,] result = new int[matrix.NumberOfRows, matrix.NumberOfColumns];
            for (int i = 0; i < matrix.NumberOfRows; i++)
            {
                for (int j = 0; j < matrix.NumberOfColumns; j++)
                {
                    result[i, j] = (int)matrix[i, j];
                }
            }
            return result;
        }

        public static explicit operator BitMatrix(bool[,] matrix)
        {
            if (matrix.Length == 0)
                throw new ArgumentOutOfRangeException();
            if (matrix == null)
                throw new NullReferenceException();
            int[] matrix2 = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            int i = 0;
            foreach (var item in matrix)
            {
                matrix2[i] = BoolToBit(item);
                i++;
            }
            return new BitMatrix(matrix.GetLength(0), matrix.GetLength(1), matrix2);
        }

        public static implicit operator bool[,](BitMatrix matrix)
        {
            bool[,] result = new bool[matrix.NumberOfRows, matrix.NumberOfColumns];
            for (int i = 0; i < matrix.NumberOfRows; i++)
            {
                for (int j = 0; j < matrix.NumberOfColumns; j++)
                {
                    result[i, j] = BitToBool(matrix[i, j]);
                }
            }
            return result;
        }


        public static explicit operator BitArray(BitMatrix matrix)
        {
            BitArray matrix2 = new BitArray(matrix.NumberOfRows * matrix.NumberOfColumns);
            int i = 0;
            foreach (var item in matrix)
            {
                matrix2[i] = BitToBool(item);
                i++;
            }
            return matrix2;
        }
}