// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
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

(int sump, int sumn) DoSmth(int[] array)
{
    int sump = 0;
    int sumn = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sump += array[i];
        }
        else
        {
            sumn += array[i];
        }
    }
    return(sump, sumn);
}
Console.WriteLine();
Console.WriteLine($" Sum of positive == {DoSmth(array).sump} and sum of negative == {DoSmth(array).sumn}");