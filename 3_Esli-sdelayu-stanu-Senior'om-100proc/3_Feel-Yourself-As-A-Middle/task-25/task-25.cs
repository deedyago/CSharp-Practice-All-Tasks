// 25. Найти сумму чисел от 1 до А
using _0_Library;
using System.Runtime.CompilerServices;


Console.WriteLine();
Console.Write("Input N: " );
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int Sum(int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
   Console.WriteLine($" Sum of number till {n} == {Sum(n)}");