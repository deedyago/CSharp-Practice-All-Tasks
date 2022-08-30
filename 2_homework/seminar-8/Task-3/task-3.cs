//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Ввод данных
Console.WriteLine("Input depth of yr random array: ");
int z = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input strokes of yr random array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input columns of yr random array: ");
int n = int.Parse(Console.ReadLine()!);

//Создание рандомного тройного массивы
int[,,] RandomArray()
{
    int[,,] array = new int[z, m, n];
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int k = 0; k < n; k++)
            {
                array[i, j, k] = new Random().Next(0, 100);
            }
        }
    }
    return array;
}

int[,,] array = RandomArray();
Console.WriteLine();

//Вывод рандомного массива с индексами элементов
void RandomArrayPrint(int[,,] yoursarray)
{
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write($"{yoursarray[i, j, k]} - [{i},{j},{k}] ");
                Console.WriteLine();
            }
            
        }
    }
}
RandomArrayPrint(array);