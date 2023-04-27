using BitMatrix2;

/*
var m1 = new BitMatrix(2, 3, 1, 1, 1, 0, 0, 0);
var m2 = new BitMatrix(2, 3, 0, 0, 0, 1, 1, 1);
Console.WriteLine(m1.Equals(m2));
m1 = new BitMatrix(1, 1, 0);
m2 = new BitMatrix(1, 1, 1);
Console.WriteLine(m1.Equals(m2));
*/

int[] arr = new int[] { -1, 1, 3, 4 };
foreach (var i in arr)
    foreach (var j in arr)
    {
        var m = new BitMatrix(3, 4);
        try
        {
            m[i, j] = 1;
            Console.WriteLine($"m[{i}, {j}] = {m[i, j]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine($"m[{i}, {j}] = exception");
        }
    }