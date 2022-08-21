//  16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
using _0_Library;

string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine();
Console.Write(" Input the number of the day: ");
int number = Library.InputToInt(Console.ReadLine()!); // = int number = int.Parse(Console.ReadLine()!);

void Func(int number)
{
    if (number < 6)
    {
        Console.WriteLine($"  {array[number - 1]} не является выходным");
    }
    else
    {
        Console.WriteLine($"  {array[number - 1]} является выходным");
    }
}
Func(number);