// 35. Определить, присутствует ли в заданном массиве, некоторое число
using _0_Library;

Console.WriteLine();
Console.Write("Input size of your random array: " );
int size = int.Parse(Console.ReadLine()!);

Console.Write("Input number to find: " );
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Library.NaturalRamdomizer(array, min, max);
    return array;
}
int[] array = RandomArray(size, -9, 9);

Library.OneDArrayPrint(array);

void SearchElementInArray(int[] array)
{
    int search = 0;
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        count++;
        if (array[i] == number)
        {
            search = array[i];
            Console.WriteLine($"\n Number you are searching is on {i} position");
            break;
        }
        else if(count == array.Length)
        {
            Console.WriteLine("\n Number you are searching does not exists in this array");
        }
    }
}
SearchElementInArray(array);