// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.		
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
void ColumnSum(int [,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        sum /= array.GetLength(0);

        Console.WriteLine($" Sum of elements in column {i+1} == {sum}");
        sum = 0;
    }
}
ColumnSum(darray);


