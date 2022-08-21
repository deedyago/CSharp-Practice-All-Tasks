// 26. Возведите число А в натуральную степень B используя цикл
using _0_Library;
using System.Runtime.CompilerServices;


Console.WriteLine();
Console.Write("Input first number: " );
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Input second number: " );
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($" Number {number1} in exponent of {number2} == {Library.AInSqrB(number1,number2)}");