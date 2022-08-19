// 4. Найти максимальное из трех чисел
using _0_Library;


Console.WriteLine();
Console.Write("  Input 1st number: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.Write("  Input 2nd number: ");
int number_2 = int.Parse(Console.ReadLine()!);

Console.Write("  Input 3rd number: ");
int number_3 = int.Parse(Console.ReadLine()!);

int Max(int number1, int number2, int number3)
{
    if (number_1 > number_2)
    {
        if (number_1 > number_3)
        {
            return number_1;
        }
        else
        {
            return number_3;
        }
    }
    else
    {
        if (number_3 > number_2)
        {
            return number_3;
        }
        else
        {
            return number_2;
        }
    }
    
}

Console.WriteLine($"    {Max(number_1, number_2, number_3)} is a maximum");
