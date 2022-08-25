// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная)	
using _0_Library;
using System.Collections;

// Вводы
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

// Поворот массива на одну итерацию поворота = 45 градусов по часовой стрелке (пока что:d)
int[,] DArrayRotate(int[,] array)
{
    int[] temparray = new int[array.GetLength(0)];
    int[,] output = new int[array.GetLength(0), array.GetLength(1)];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
            temparray[j] = array[i,j];
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
             output[j,i] = temparray[j];
            }
        }
    return output;
}
if(m == n)
{
    Library.TwoDArrayPrint(darray);
    darray = DArrayRotate(darray);
    Library.TwoDArrayPrint(darray);
}
else
{
     Console.WriteLine($" Task cannot be executed, because of wrong size inputs!\n ");
}
