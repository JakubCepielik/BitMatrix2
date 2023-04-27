namespace BitMatrix2
{
    using System;
    using System.Collections;

    public partial class BitMatrix : ICloneable
    {
        public object Clone()
        {
            BitMatrix copy = new BitMatrix(this.NumberOfRows,this.NumberOfColumns);
            int i = 0;
            foreach(bool item in this.data) 
            {
                copy.data[i] = item;
                i++;
            }
            return copy;
        }
    }

}