// 6. Выяснить является ли число чётным
using _0_Library;


Console.WriteLine();
Console.Write("  Input your number: ");
int number = int.Parse(Console.ReadLine()!);

if (Library.IfEven(number))
{
    Console.WriteLine($"    Your number {number} is even ");
}
else
{
    Console.WriteLine($"    Your number {number} is not even ");
}
