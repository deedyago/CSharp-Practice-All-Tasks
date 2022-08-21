//  15. Дано число. Проверить кратно ли оно 7 и 23
using _0_Library;


Console.WriteLine();
Console.Write("  Input number: ");
int number = int.Parse(Console.ReadLine()!);

string IfDividable(int n) 
{
    if (n % 7 == 0)
    {
        if(n % 23 == 0)
        {
            return "is";
        }
        else
        {
            return "is not";
        }
    }
    else
    {
        return "is not";
    }
}
Console.WriteLine($"   Input {number} {IfDividable(number)} dividable on 7 and 23");