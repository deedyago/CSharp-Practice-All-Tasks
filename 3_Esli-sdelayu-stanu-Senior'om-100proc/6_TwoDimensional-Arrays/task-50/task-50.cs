// 50. В двумерном массиве n×k заменить четные элементы на противоположные	
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

Console.WriteLine($" == \n");
int[,] Reverse(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i, j] * -1;
        }
    }
    return array;
}

darray = Reverse(darray);   

Library.TwoDArrayPrint(darray);


