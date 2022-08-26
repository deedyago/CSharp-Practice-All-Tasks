// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент
using _0_Library;
using System.Collections;

//Ввод любых размеров матриц и их наполнения
Console.WriteLine("Input strokes of yr 1st random matrix: ");
int m1 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input columns of yr 1st random matrix: ");
int n1 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --from-- what number: ");
int min = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --to-- what number: ");
int max = int.Parse(Console.ReadLine())!;

int[,] darray = Library.TwoDArray(m1, n1, min, max);

Console.WriteLine();

Library.TwoDArrayPrint(darray);

int MinElement(int[,] array)
{
    int minElement = array[0, 0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < minElement)
            {
                minElement = array[i,j];
            }
        }
    }
    return minElement;
}

int[] foundIndexes = Library.DarrayFindElementI(darray, MinElement(darray));

int[,] DeleteColumnsRowsOfMinElement(int[,] array, int[] element)
{
  
    int k = 1;
    int l = 0;
    int[,] output = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++ )
        {
            if (i != element[0] && j != element[1])
            {
                output[k-1, l] = array[i, j];
                l++;      
            }
            
        }
        k = 1 + i;
        l = 0;
    }
    return output;
}

int[,] finalArray = DeleteColumnsRowsOfMinElement(darray, foundIndexes);

Library.TwoDArrayPrint(finalArray);