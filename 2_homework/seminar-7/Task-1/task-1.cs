// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
using _0_Library;

Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer from... => ");
double min = double.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer ...to => ");
double max = double.Parse(Console.ReadLine()!);

Console.WriteLine();

double[,] TwoDFloatArray(int m, int n, double min, double max)
{
        double[,] output = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                output[i, j] = new Random().NextDouble() * (max - min);
            }
        }
        return output;
}

double[,] darray = TwoDFloatArray(m, n, min, max);    

Library.TwoDFloatArrayPrint(darray);


