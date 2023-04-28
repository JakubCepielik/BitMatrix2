using BitMatrix2;

BitMatrix m;
string s = "";
if (BitMatrix.TryParse(s,out m))
{
    Console.WriteLine(m.NumberOfRows);
    Console.WriteLine(m.NumberOfColumns);
    Console.WriteLine(m);

}
Console.WriteLine(BitMatrix.TryParse(s, out m));