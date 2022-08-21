// 3. По заданному номеру дня недели вывести его название
using _0_Library;

string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine();
Console.Write(" Input the number of the day: ");
int number = Library.InputToInt(Console.ReadLine()!); // = int number = int.Parse(Console.ReadLine()!);

void Func(int number)
{
    Console.WriteLine($"  {array[number-1]}");
}
Func(number);