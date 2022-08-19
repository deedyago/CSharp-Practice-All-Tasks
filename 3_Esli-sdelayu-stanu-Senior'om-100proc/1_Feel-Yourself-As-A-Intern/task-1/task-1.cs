//  1. По двум заданным числам проверять является ли первое квадратом второго

using _0_Library;

Console.WriteLine();
Console.Write("Input your 1st number: " );
int number1 = Library.InputToInt(Console.ReadLine()!);

Console.Write("Input your 2nd number: " );
int number2 = Library.InputToInt(Console.ReadLine()!); 

string IfFirstSquareofSecond(int number1, int number2)
{
    string y = "is";
    string n = "is not";
    if(number1 / number2 == number2)
    {
        return y;
    }
    else
    {
        return n;
    }
}
Console.WriteLine();
Console.WriteLine($" Number {number1} {IfFirstSquareofSecond(number1,number2)} a square of number {number2}");