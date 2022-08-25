// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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

int[,] Task2(int [,] array)
{
    for (int i = 2; i < array.GetLength(0); i += 2)
    {
        for (int j = 2; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return darray;
}

darray = Task2(darray);

Library.TwoDArrayPrint(darray);


