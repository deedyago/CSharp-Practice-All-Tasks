// 24. Найти кубы чисел от 1 до N
using _0_Library;
using System.Runtime.CompilerServices;

Console.WriteLine();
Console.Write("Input N: " );
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine();

void Cube(int n)
{
    int cube = 1;
    for (int i = 1; i <= n; i++)
    {
        cube = i * i * i;
        Console.Write($"{cube} ");
    }
    Console.Write($" <- all cubes till the number {n}");
    Console.WriteLine();
}
Cube(n);