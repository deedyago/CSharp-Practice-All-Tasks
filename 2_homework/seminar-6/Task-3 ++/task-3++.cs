// Написать метод поворота массива [N,N]
using _0_Library;
using System.Collections;

// Вводы
Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer from... => ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer ...to => ");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine();

// Создаем рандомный двумерный массив натуральных чисел 
int[,] TwoDArray(int m, int n, int min, int max)
{
    int[,] output = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
           Library.TwoDNaturalRamdomizer(output,min,max); 
        }
    }
    return output;
}

int[,] darray = TwoDArray(m, n, min, max); // инициализируем двумерный массив


// Поворот массива на одну итерацию поворота = 45 градусов по часовой стрелке (пока что:d)
int[,] DArrayRotate(int[,] array)
{
    int[] temparray = new int[array.GetLength(0)];
    int[,] output = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            temparray[j] = array[j,i];
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
             output[i,j] = temparray[array.GetLength(1)-1-j];
        }
    }
    return output;
}
Library.TwoDArrayPrint(darray);


Console.WriteLine($" Input degree of rotation ex.: 45, 90, 180: "); // Просим пользователя ввести градус поворота, на сколько будем массив поворачивать
int degree = int.Parse(Console.ReadLine()!);


// Запускаем метод поворота DArrayRotate столько раз сколько будет равно == (градус пользователя/одну итерацию поворота, которую можно тоже указать)
int[,] RotationDegree(int[,] array,int degree)
{
    int degreeiteration = 45;
                                          // тут я пробовал сделать поворот массива с разными размерами столбцов и строк
                                          // пока работает только для одного поворота по часовой стрелке на 45 градусов
                                          // для массивов с одинаковыми размерами - поворот работает на любой градус, который введет пользователь
        switch(m < n || n < m)           

        {
            case true:
                {
                    int[,] darray2 = new int[n,m];
                    for (int i = 0; i < n; i++)
                    {   
                        for (int j = 0; j < m; j++)
                        {
                            darray2[i,m-1-j] = array[j,i];
                        }
                    }
                    for(int i = degree/degreeiteration; i > 1; i-- )
                    {
                        darray2 = DArrayRotate(darray2);
                    }
                    return darray2;
                    break;
                }
            case false:
                {
                    for(int i = degree/degreeiteration; i > 0; i-- )
                    {
                        darray = DArrayRotate(darray);
                    }
                    return darray;
                    break;
                }
        }    
}


darray = RotationDegree(darray,degree);
Library.TwoDArrayPrint(darray);



