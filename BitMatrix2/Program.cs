using BitMatrix2;

/*
var m1 = new BitMatrix(2, 3, 1, 1, 1, 0, 0, 0);
var m2 = new BitMatrix(2, 3, 0, 0, 0, 1, 1, 1);
Console.WriteLine(m1.Equals(m2));
m1 = new BitMatrix(1, 1, 0);
m2 = new BitMatrix(1, 1, 1);
Console.WriteLine(m1.Equals(m2));
*/

var m1 = new BitMatrix(2, 3, 1, 1, 1, 0, 0, 0);
var m2 = new BitMatrix(2, 3, 1, 1, 1, 0, 0, 0);
Console.WriteLine(m1 != m2);
Console.WriteLine(m1 == m2);
Console.WriteLine(m2 != m1);
Console.WriteLine(m2 == m1);

m1 = new BitMatrix(1, 1, 1);
m2 = new BitMatrix(1, 1, 1);
Console.WriteLine(m1 == m2);
Console.WriteLine(m1 != m2);