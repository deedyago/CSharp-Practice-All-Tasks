//  20. Задать номер четверти, показать диапазоны для возможных координат
using _0_Library;


Console.WriteLine();
Console.Write(" Input quarter: ");
int quarter = Library.InputToInt(Console.ReadLine()!); // = int number = int.Parse(Console.ReadLine()!);

string RangeOfQuarter(int q)
{
    if (q == 1)
    {
        return "from x = 1 to infinity and y = 1 to infinity";
    }
    if (q == 2)
    {
        return "from x = -1 to -infinity and y = 1 to infinity";
    }

    if (q == 3)
    {
        return "from x = -1 to -infinity and y = -1 to -infinity";
    }
    if (q == 4)
    {
        return "from x = 1 to infinity and y = -1 to -infinity";
    }
    return "Input is mistaken";
}
if (quarter < 1 || quarter > 4)
{
    Console.WriteLine(RangeOfQuarter(quarter));
}
else
{
    Console.WriteLine($" Range of numbers in {quarter} quarter can be {RangeOfQuarter(quarter)}");
}