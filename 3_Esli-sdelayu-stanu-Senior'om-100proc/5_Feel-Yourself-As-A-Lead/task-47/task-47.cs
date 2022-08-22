// 47. Написать программу копирования массива
using _0_Library;
using System.Collections;


//y = k1x + b1; y = k2x +b2
Console.WriteLine();
int[] array = new int[10];

Library.NaturalRamdomizer(array, 1, 10);

int[] ArrayCopy(int[] array1)
{
    int[] array2 = new int[array1.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array2[i] = array1[i];
    }
    return array2;
}
int[] array2 = ArrayCopy(array);

Library.OneDArrayPrint(array);
Console.WriteLine($"\n == ");
Library.OneDArrayPrint(array2);


