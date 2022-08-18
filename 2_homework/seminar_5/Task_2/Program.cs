// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Input size of yr random array: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --from-- what number: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --to-- what number: ");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[size];


//Создание рандомного массива
void RandomArray(int[] yorsarray)
{
    for (int i = 0; i < yorsarray.Length; i++)
    {
        yorsarray[i] = new Random().Next(min, max);
    }
}
RandomArray(array);

//Вывод созданного массива
Console.WriteLine();
Console.Write($"Your random array of size <{size}> from <{min}> to <{max}>: ");

void ArrayPrint(int[] yorsarrayprint)
{
    for (int i = 0; i < yorsarrayprint.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }
}
ArrayPrint(array);

//Поиск и вывод элементов на нечетных позициях
Console.Write($"\nNumbers on odd indexes are:");

int SumFinder(int[] yoursarray2)
{
    int sum = 0;
    for(int i = 0; i < yoursarray2.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + yoursarray2[i-1];
            Console.Write($" [{yoursarray2[i-1]}]");
        }
    }
    return sum;
}

Console.Write($" and their sum is -> {SumFinder(array)}");