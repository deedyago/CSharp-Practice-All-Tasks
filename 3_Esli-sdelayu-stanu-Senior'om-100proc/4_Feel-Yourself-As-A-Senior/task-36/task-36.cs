// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
using _0_Library;

Console.WriteLine();
Console.Write("Input size of your random array: " );
int size = int.Parse(Console.ReadLine()!);


Console.WriteLine();

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Library.NaturalRamdomizer(array, min, max);
    return array;
}
int[] array = RandomArray(size, 100, 999);

Library.OneDArrayPrint(array);

(int countp, int countn) FindNegAndPos(int[] array)
{
    int countp = 0;
    int countn = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countp++;
        }
        else 
        {
            countn++;
        }
    }
    return(countp, countn);
}
Console.WriteLine($" \nThere are {FindNegAndPos(array).countp} positive numbers and {FindNegAndPos(array).countn} negative numbers in yr array");