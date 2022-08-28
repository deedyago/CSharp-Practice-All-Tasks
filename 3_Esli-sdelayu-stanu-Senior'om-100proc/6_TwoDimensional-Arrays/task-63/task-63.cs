/// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента


//Ввод данных
Console.WriteLine("Input depth of yr random array: ");
int z = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input strokes of yr random array: ");
int m = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input columns of yr random array: ");
int n = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --from-- what number: ");
int min = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --to-- what number: ");
int max = int.Parse(Console.ReadLine())!;

int[,,] array = new int[z, m, n];

//Создание рандомного тройного массивы
void RandomArray(int[,,] yoursarray)
{
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int k = 0; k < n; k++)
            {
                yoursarray[i, j, k] = new Random().Next(min, max);
            }
        }
    }
}
RandomArray(array);

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