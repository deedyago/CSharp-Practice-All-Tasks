﻿// 31. Задать массив из 8 элементов и вывести их на экран 
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
int[] array = RandomArray(size, 1, 9);

Library.OneDArrayPrint(array);