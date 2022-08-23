//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Input your number:");
int number = int.Parse(Console.ReadLine());

Console.Write($"From range of 1 to {number} following numbers are even: ");

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"\n{i}");
    }
}