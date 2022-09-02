// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
using _0_Library;

Console.WriteLine("   Input M: ");
int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("   Input N: ");
int.TryParse(Console.ReadLine(), out int n);

int Sum(int m, int n)
{
    int sum = 0;
    for(int i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
Console.Write($"\nSum is: {Sum(m, n)}");