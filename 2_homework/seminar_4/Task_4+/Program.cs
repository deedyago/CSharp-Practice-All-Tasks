//Написать метод, который генерирует массив 0 и 1 заданного количества N

Console.WriteLine("Input N: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

void Array(int n)
{
    for(int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write(array[i]);
    }
}
Array(n);