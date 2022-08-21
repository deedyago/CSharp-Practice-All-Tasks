// 27. Определить количество цифр в числе
using _0_Library;
using System.Runtime.CompilerServices;

Console.WriteLine();
Console.Write("Input number: " );
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int QOfCharInNumber(int input)
{
    int count = 0;
    while(input != 0)
    {
        input /= 10;
        count++;
    }
    return count;
}
Console.WriteLine($" Number {number} consists of {QOfCharInNumber(number)} chars");