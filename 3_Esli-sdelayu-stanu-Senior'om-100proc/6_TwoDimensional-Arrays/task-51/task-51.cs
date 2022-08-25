// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
using _0_Library;


Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] Task(int m, int n)
{
    int[,] darray = new int[m, n];
    for (int i = 0; i < darray.GetLength(0); i++)
    {
        for (int j = 0; j < darray.GetLength(1); j++)
        {
            darray[i, j] = i + j;
        }
    }
    return darray;
}

int[,] darray = Task(m,n);

Library.TwoDArrayPrint(darray);


