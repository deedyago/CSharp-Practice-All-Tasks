// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Console.WriteLine();
Console.WriteLine("Input size of yr random array: ");
int size = int.Parse(Console.ReadLine()!);

// По условию задачи указываем min 100, max 999
Console.WriteLine("Input range --from-- what number: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --to-- what number: ");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[size];
ArrayEvenFind(array); 
int[] evenarray = new int[ArrayEvenFind(array)]; //Создаем новый массив куда будем выводить нужные нам числа

//Рандомайзер
void RandomArray(int[] yorsarray)
{
    for(int i = 0; i < yorsarray.Length; i++)
    {
        yorsarray[i] = new Random().Next(min, max); 
    }
}
RandomArray(array);

Console.Write($"Your random array of size <{size}> from <{min}> to <{max}>: ");

void ArrayPrint(int[] yorsarrayprint)
{
    for (int i = 0; i < yorsarrayprint.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }
}
ArrayPrint(array);

Console.WriteLine("");

//Счетчик и вывод количества чётных чисел в массиве
int ArrayEvenFind(int[] yorsarrayoddsum)
{
    int count = 0;
    for (int i = 0; i < yorsarrayoddsum.Length; i++)
    {
        if (yorsarrayoddsum[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
    

}
Console.Write($"There are --{ArrayEvenFind(array)}-- even numbers in your array:");

// Вывод найденных чётных чисел в массиве
void ArrayEvenPrint(int[] yorsarrayoddsum)
{
    for (int i = 0; i < yorsarrayoddsum.Length; i++)
    {
        if (yorsarrayoddsum[i] % 2 == 0)
        {
            evenarray[i] = yorsarrayoddsum[i];
            Console.Write($" [{evenarray[i]}]");
        }
    }

}
ArrayEvenPrint(array);
