// 30. Показать кубы чисел, заканчивающихся на четную цифру
using _0_Library;
using System.Runtime.CompilerServices;

Console.WriteLine();
Console.Write("Input N: " );
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine();

void CubeEven(int n)
{
    int cube = 1;
    for (int i = 1; i <= n; i++)
    {
        cube = i * i * i;
        if((cube % 10) % 2 == 0)
        {
            Console.Write($"{cube} ");
        }
    }
    Console.Write($" <- all cubes till the number {n} with last char is even ");
    Console.WriteLine();
}
CubeEven(n);