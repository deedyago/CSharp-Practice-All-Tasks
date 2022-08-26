// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
using _0_Library;

Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer from... => ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer ...to => ");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine();

// Создаем рандомный массив
 int[,] TwoDArray(int m, int n, int min, int max)
{
        int[,] output = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                output[i, j] = new Random().Next(min, max);
            }
        }
        return output;
}

int[,] darray = TwoDArray(m, n, min, max);                            // Инициализируем рандомный массив

Library.TwoDArrayPrint(darray);                                       // Выводим его

Console.WriteLine($" Input number to search: ");                      // Просим пользователя ввести элемент для поиска
int search = int.Parse(Console.ReadLine()!);

(int[] foundindexes, int count) DarrayFindElementI(int [,] array, int input)
{

    int sizecount = 0;                                                 // 42 - 54 строки делаю это для "красивого" вывода
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == input)
            {
                sizecount += 2;
                count++;
            }
        }
    }
    int k = 0;                       // новая переменная что бы новый массив заполнялся с начала, а не с i или j индекса, когда элемент который мы ищем найдется
    int[] foundindexes = new int[sizecount];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == input)
            {
                foundindexes[k] = i;
                foundindexes[k+1] = j;
                k+=2;
            }
        }
    }
    return (foundindexes, count);
}

int[] foundindexes = DarrayFindElementI(darray,search).foundindexes;
int count = DarrayFindElementI(darray,search).count;

switch (count > 0)             // Проверка, а существует ли вообще такой элемент в массиве
{
        case true:
            {
                Console.Write($" Number {search} your seaching for is on such places  =>  ");
                for(int i = 0; i < foundindexes.Length-1; i+=2)
                {
                    Console.Write($" [{foundindexes[i]},{foundindexes[i+1]}]  ");
                }
                break;
            }
        case false:
            {
                Console.WriteLine($"\n There is no element you are searching for\n ");
                break;
            }
}


