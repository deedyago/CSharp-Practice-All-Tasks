// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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

int[,] darray = Library.TwoDArray(m, n, min, max);

Library.TwoDArrayPrint(darray);
Console.WriteLine($" Input number to search: ");
int search = int.Parse(Console.ReadLine()!);

(int[] foundindexes, int count) DarrayFindElementI(int [,] array, int input)
{

    int sizecount = 0;
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
    int k = 0;
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

switch (count > 0)
{
        case true:
            {
                for(int i = 0; i < foundindexes.Length-1; i+=2)
                {
                    Console.Write($"[{foundindexes[i]},{foundindexes[i+1]}]  ");
                }
                break;
            }
        case false:
            {
                Console.WriteLine($"There is no element you are searching for ");
                break;
            }
}


