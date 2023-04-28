namespace BitMatrix2
{
    using System;
    using System.Collections;

    public partial class BitMatrix
    {
        public static BitMatrix Parse(string s)
        {
            if(s == null || s == "") throw new ArgumentNullException();
            string[] rows = s.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(row => row.Trim('\r')).ToArray();
            for (int i = 0; i < rows.Length - 1; i++)
            {
                if (rows[i].Length != rows[i + 1].Length)
                    throw new FormatException();
            }
            char[] data = new char[rows.Length * rows[0].Length];
            for (int i = 0; i < rows.Length; i++)
            {
                char[] tmp = rows[i].ToCharArray();
                int j = i * rows[i].Length;
                foreach (char c in tmp)
                {
                    data[j] = c;
                    j++;
                }
            }
        
            int[] intdata = Array.ConvertAll(data, c => (int)Char.GetNumericValue(c));

            foreach(int i in intdata)
            {
                if(i != 0 && i != 1)
                    throw new FormatException();
            }
            BitMatrix parse = new BitMatrix(rows.Length,rows[0].Length, intdata);
            return parse;
        }

        public static bool TryParse(string s, out BitMatrix result)
        {
            result = new BitMatrix(1, 1);
            if (s == null || s == "")
            {
                return false;
            }
            string[] rows = s.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(row => row.Trim('\r')).ToArray();
            for (int i = 0; i < rows.Length - 1; i++)
            {
                if (rows[i].Length != rows[i + 1].Length)
                {
                    return false;
                }
            }
            char[] data = new char[rows.Length * rows[0].Length];
            for (int i = 0; i < rows.Length; i++)
            {
                char[] tmp = rows[i].ToCharArray();
                int j = i * rows[i].Length;
                foreach (char c in tmp)
                {
                    data[j] = c;
                    j++;
                }
            }

            int[] intdata = Array.ConvertAll(data, c => (int)Char.GetNumericValue(c));

            foreach (int i in intdata)
            {
                if (i != 0 && i != 1)
                {
                    return false;
                }
            }
            result = new BitMatrix(rows.Length, rows[0].Length, intdata);
            return true;
        }

    }

}