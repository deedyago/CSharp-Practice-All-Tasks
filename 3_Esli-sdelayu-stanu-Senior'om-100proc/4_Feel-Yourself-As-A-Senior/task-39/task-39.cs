// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
int[] array = RandomArray(size, 1, 10);

Library.OneDArrayPrint(array);
Console.WriteLine("\n  ==");

int[] SumOfPairs(int[] array)
{
    int[] array2 = new int[array.Length/2];  
    
    for(int i = 0; i < array.Length/2; i++)
    {
        array2[i] = array[i] * array[array.Length - 1 -i];
    }
    return array2;
}

int[] array2 = SumOfPairs(array);
Library.OneDArrayPrint(array2);
