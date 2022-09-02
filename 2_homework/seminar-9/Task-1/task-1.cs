// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
using _0_Library;

Console.WriteLine("   Input M: ");
int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("   Input N: ");
int.TryParse(Console.ReadLine(), out int n);

void PrintNumbers(int m, int n)
{
    for(int i = m; i <= n; i++)
    {
        Console.Write($"{i} ");
    }

}
Console.WriteLine();
PrintNumbers(m, n);