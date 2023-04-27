namespace BitMatrix2
{

    using System;
    using System.Collections;

    public partial class BitMatrix : IEnumerable<int>
    {
        public int this[int i, int j]
        {
            get 
            { 
                if (NumberOfRows <= i || NumberOfColumns <= j || i < 0 || j < 0) throw new IndexOutOfRangeException();
                else
                    return BoolToBit(data[i * NumberOfColumns + j]);
            }
            set 
            {
                if (NumberOfRows <= i || NumberOfColumns <= j || i <0 || j<0) throw new IndexOutOfRangeException();
                else
                data[i * NumberOfColumns + j] = BitToBool(value); 
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i<data.Length;i++)
            {
                
                yield return BoolToBit(data[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

