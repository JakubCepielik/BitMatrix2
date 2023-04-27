using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMatrix2
{

    // prostokątna macierz bitów o wymiarach m x n
    public partial class BitMatrix
    {
        private BitArray data;
        public int NumberOfRows { get; }
        public int NumberOfColumns { get; }
        public bool IsReadOnly => false;

        // tworzy prostokątną macierz bitową wypełnioną `defaultValue`
        public BitMatrix(int numberOfRows, int numberOfColumns, int defaultValue = 0)
        {
            if (numberOfRows < 1 || numberOfColumns < 1)
                throw new ArgumentOutOfRangeException("Incorrect size of matrix");
            data = new BitArray(numberOfRows * numberOfColumns, BitToBool(defaultValue));
            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

        public static int BoolToBit(bool boolValue) => boolValue ? 1 : 0;
        public static bool BitToBool(int bit) => bit != 0;
        public override string ToString()
        {
            string wyswietl = "";
            for(int i = 0; i<NumberOfRows*NumberOfColumns; i++) 
            { 
                if((i+1)%NumberOfColumns == 0)
                {
                    wyswietl += BoolToBit(data[i]).ToString();
                    wyswietl += "\n";
                }
                else
                wyswietl += BoolToBit(data[i]).ToString();
            }
            return wyswietl;
        }
    }


    

}