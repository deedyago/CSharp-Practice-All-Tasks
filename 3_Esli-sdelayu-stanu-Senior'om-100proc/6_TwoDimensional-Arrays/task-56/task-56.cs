// 56. Написать программу, которая обменивает элементы первой строки и последней строки		
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
int[,] ChangeStrokes(int [,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
          temp = array[0, i];
          array[0, i] = array[array.GetLength(0)-1, i];
          array[array.GetLength(0)-1, i] = temp;
    }
    return array;
}

darray = ChangeStrokes(darray);
Library.TwoDArrayPrint(darray);
