// 48. Показать двумерный массив размером m×n заполненный целыми числами
using _0_Library;
using System.Collections;


Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer from... => ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer ...to => ");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] TwoDArray(int m, int n, int min, int max)
{
    int[,] output = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
           Library.TwoDNaturalRamdomizer(output,min,max);
        }
    }
    return output;
}

Console.WriteLine();

int[,] darray = Library.TwoDArray(m, n, min, max);    

Library.TwoDArrayPrint(darray);



