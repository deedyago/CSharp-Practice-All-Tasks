// 34. Написать программу замену элементов массива на противоположные
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
int[] array = RandomArray(size, -9, 9);

Library.OneDArrayPrint(array);
Console.WriteLine();
Console.WriteLine("==");

int[] Invert(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*-1;
    }
    return array;
}
Invert(array);
Library.OneDArrayPrint(array);