//  2. Даны два числа. Показать большее и меньшее число

using static Library;

Console.WriteLine();
Console.Write("Input your 1st number: " );
int number1 = InputToInt(Console.ReadLine()!);

Console.Write("Input your 2nd number: " );
int number2 = InputToInt(Console.ReadLine()!); 

Console.WriteLine($" Number [{MaxAndMin(number1, number2).Item1}] is a maximum\n Number [{MaxAndMin(number1, number2).Item2}] is a minimum");