using BitMatrix2;
int[] arr = new int[6] { 1, 0, 1, 1, 0, 1 };
var m = new BitMatrix(2, 3, arr);
var m1 = (BitMatrix)(m.Clone());
m[0, 1] = 1;
Console.WriteLine(m[0, 1] != m1[0, 1]);