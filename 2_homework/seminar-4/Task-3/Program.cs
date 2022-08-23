// Задача 29: Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран

// Через рандом с заданием размера массива и диапазона чисел для заполнения
Console.WriteLine();
Console.WriteLine("Input size of yr random array: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --from-- what number: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --to-- what number: ");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[size];

//Рандомайзер
void RandomArray(int[] yorsarray)
{
    for(int i = 0; i < yorsarray.Length; i++)
    {
        yorsarray[i] = new Random().Next(min, max);
    }
}
RandomArray(array);

Console.WriteLine();
Console.Write($"Your random array of size <{size}> from <{min}> to <{max}> is: ");

//Вывод получившегося рандомного массива
void ArrayPrint(int[] yorsarrayprint)
{
    for (int i = 0; i < yorsarrayprint.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }
}
ArrayPrint(array);

///////////////////////////////////////////////////////////////////////////////////

// Через ввод пользователем
Console.Write("Input yr array separated by space (ex. 3 6 2 5 1 ...):");
string array = Console.ReadLine();
string[] strarray = array.Split(' ');
int[] intarray = new int[strarray.Length];

//Записываем строковый массив в интовский
for (int i = 0; i < strarray.Length; i++)
{
    intarray[i] = int.Parse(strarray[i]);
}

Console.Write($"Your array is: ");

//Вывод получившегося массива
void ArrayPrint(int[] yorsarrayprint)
{
    for (int i = 0; i < yorsarrayprint.Length; i++)
    {
        Console.Write($"[{intarray[i]}]");
    }
}
ArrayPrint(intarray);