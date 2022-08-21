//  17. По двум заданным числам проверять является ли одно квадратом другого
using _0_Library;


Console.WriteLine();
Console.Write(" Input 1st number: ");
int number1 = Library.InputToInt(Console.ReadLine()!); // = int number = int.Parse(Console.ReadLine()!);

Console.Write(" Input 2nd number: ");
int number2 = Library.InputToInt(Console.ReadLine()!);

(string, int, int) IfSquare(int n1, int n2)
{
    if (n1 > n2)
    {
        if(n1 / n2 == n2)
        {
            return ("is", n1, n2);
        }
        else
        {
            return ("is not", n1, n2);
        }
    }
    else
    {
        if(n2 / n1 == n1)
        {
            return ("is", n2, n1);
        }
        else
        {
            return ("is not", n2, n1);
        }
    }
}
Console.WriteLine($" Number {IfSquare(number1, number2).Item2} {IfSquare(number1, number2).Item1} square of {IfSquare(number1, number2).Item3}");