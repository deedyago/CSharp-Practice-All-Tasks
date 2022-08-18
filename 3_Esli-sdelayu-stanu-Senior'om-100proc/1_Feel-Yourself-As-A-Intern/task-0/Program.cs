//  0. Вывести квадрат числа

using static Library;

Console.Write("Input your number: " );
int number = InputToInt(Console.ReadLine()!);

int Square(int number)
{
    number = number * number;
    return number;
}
Console.WriteLine($" Square of number [{number}] is {Square(number)}");