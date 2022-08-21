// 28. Подсчитать сумму цифр в числе
using _0_Library;
using System.Runtime.CompilerServices;

Console.WriteLine();
Console.Write("Input number: " );
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int SumOfCharInNumber(int input)
{
    int sum = 0;
    int tempchar = 0;
    while(input != 0)
    {
        tempchar = input %  10;
        sum += tempchar;
        input /= 10;
    }
    return sum;
}
Console.WriteLine($" Sum of chars in {number} == {SumOfCharInNumber(number)}");