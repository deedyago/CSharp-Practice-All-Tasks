// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
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

int FindSumOfElementsOnOddI(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
Console.WriteLine($" \nSum of elements on odd position == {FindSumOfElementsOnOddI(array)} ");