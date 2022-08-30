// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива	
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

//Сортировка строк двойного массива по убыванию
int[,] StrokesArange(int[,] yorsarray)
{
    int temp = 0;
    for (int i = 0; i < m; i++) 
    {
        for(int j = 0; j < n; j++)
        {
            for (int k = n-1; k > j ; k--)
            {
                if (yorsarray[i,k] > yorsarray[i,k-1])
                    {
                        temp = yorsarray[i,k];
                        yorsarray[i,k] = yorsarray[i,k - 1];
                        yorsarray[i,k - 1] = temp;
                    }
            }  
        }
    }
    return yorsarray;
}

darray = StrokesArange(darray);

Library.TwoDArrayPrint(darray);