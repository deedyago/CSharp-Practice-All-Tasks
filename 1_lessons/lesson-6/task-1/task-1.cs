// 23. Показать таблицу квадратов чисел от 1 до N
using _0_Library;
using System.Runtime.CompilerServices;

//Создание массивов с координатами с помощью ввода пользователя с указание разделителя
Console.WriteLine();
Console.Write("Input N:" );
int n = int.Parse(Console.ReadLine())!;

Console.WriteLine();
int[,] ArrayOfPifagorGrid(int m, int n)
{
    int[,] resultarray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        
        for(int j = 0; j < n && i == 0; j++)
        {
            resultarray[i,j] = j;
        }
        resultarray[i,0] = i;
    }
    return resultarray;
}

int[,] array = ArrayOfPifagorGrid(10,10);

int[,] ArrayOfPifagor(int[,] array, int n)
{
    for (int i = 1; i <= n; i++)
    {
        for(int j = 1; j <= n; j++)
        {
            array[i,j] = array[0,j] * array[i,0];
        }
    }
    return array;
}
array = ArrayOfPifagor(array,n);


for (int i = 0; i < 10; i++)
{
        for(int j = 0; j < 10; j++)
        {
            Console.Write($"  {array[i,j]:D2}");
            /*if(array[i,j] == 0)
            {
            string[,] strarray = Array.ConvertAll(array, x => x.ToString());
            Console.Write($"{strarray[i,j] = " "}");
            } */
        }
        Console.WriteLine();
}