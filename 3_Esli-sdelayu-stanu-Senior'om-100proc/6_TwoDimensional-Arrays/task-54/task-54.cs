// 54. В матрице чисел найти сумму элементов главной диагонали	
using _0_Library;


Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer from... => ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer ...to => ");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] darray = Library.TwoDArray(m, n, min, max);

Library.TwoDArrayPrint(darray);
int Diagonale(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
            sum += array[i, i];
    }
    return sum;
}

Console.WriteLine($" Sum of elements on main diagonale == {Diagonale(darray)} ");

