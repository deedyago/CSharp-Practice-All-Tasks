// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
using _0_Library;

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

//Поиск суммы первой строки
int FirstStrokeSum(int[,] yorsarray)
{
    int sum = 0;
    for (int j = 0, i = 0; j < n; j++)
    {
        sum = sum + yorsarray[i, j];
    }
    return sum;
}

int sum = FirstStrokeSum(darray);

//Поиск суммы остальных строк 
int StrokeIndex(int[,] yorsarray)
{
    int sumtemp = 0;
    int strokeindex = 0; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sumtemp = sumtemp + yorsarray[i, j];
        }
            if (sumtemp < sum)
            {
                sum = sumtemp;
                strokeindex = i;
            }
            sumtemp = 0;
    }
    return strokeindex;
}

int strokeindex = StrokeIndex(darray);
Console.WriteLine();

//"Красивый" вывод результатов :D
void ArrayPrint(int[,] yorsarray)
{
    int tempsum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{yorsarray[i, j]} ");
            tempsum = tempsum + yorsarray[i, j];
        }

        Console.Write($"= {tempsum}");
        tempsum = 0;

        if (i == strokeindex)
        {
            Console.Write($"  {strokeindex+1} <- This-stroke-is-with-least-sum");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
}
ArrayPrint(darray);