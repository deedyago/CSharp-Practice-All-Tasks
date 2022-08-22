// 43. Написать программу преобразования десятичного числа в двоичное
using _0_Library;

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Input into numeral system to convert: ");
int osnovanie = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Equivalent in -{osnovanie}- numeral system of your number -{number}- in decimal numeral system is => {Library.TenDimensionalTo(number,osnovanie)}");
