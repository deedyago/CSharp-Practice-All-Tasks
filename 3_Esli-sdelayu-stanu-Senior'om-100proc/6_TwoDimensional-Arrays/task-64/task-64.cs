// 64. Показать треугольник Паскаля



using _0_Library;

//Console.WriteLine("Input depth of yr random array: ");
//int z = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input strokes of yr random array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input columns of yr random array: ");
int n = int.Parse(Console.ReadLine()!);






int[,] RandomArray(int[,] array)
{
    int[,] darray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            darray[i,j] = 1;
        }
    }
    return darray;
}

int[,] darray = new int[m,n];
darray = RandomArray(darray);

int[,] Pascal(int[,] array)
{
    for (int i = 1; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            array[i,j] = array[i,j-1] + array[i-1,j];
        }
    }
    return darray;
}
darray = Pascal(darray);

for(int i = 0; i < darray.GetLength(0) ; i++)
{
    for (int j = 0;  j < darray.GetLength(1); j++)
    {
       // if(i )
        Console.Write($" [{darray[i, j]:D2}]");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");

