// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
using _0_Library;

Console.WriteLine();
Console.Write("Input size of your random array: " );
int size = int.Parse(Console.ReadLine()!);
Console.Write("Input range to start: " );
int m = int.Parse(Console.ReadLine()!);
Console.Write("Input range to end:  " );
int n = int.Parse(Console.ReadLine()!);



Console.WriteLine();

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Library.NaturalRamdomizer(array, min, max);
    return array;
}
int[] array = RandomArray(size, 1, 10);

Library.OneDArrayPrint(array);

int FindCountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i >= m && i < n)
        {
            count += 1;
        }
    }
    return count;
}
Console.WriteLine($" \n\nThere are {FindCountElements(array)} elements between {m} to {n} range");