//  2. Даны два числа. Показать большее и меньшее число
using _0_Library;

Console.WriteLine();
Console.Write("Input your 1st number: " );
int number1 = Library.InputToInt(Console.ReadLine()!);

Console.Write("Input your 2nd number: " );
int number2 = Library.InputToInt(Console.ReadLine()!); 

Console.WriteLine($" Number [{MaxAndMin(number1, number2).i1}] is a maximum\n Number [{Library.MaxAndMin(number1, number2).i2}] is a minimum");