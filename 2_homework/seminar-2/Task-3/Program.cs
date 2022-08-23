//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int i = 0;

Console.Write("Input the number of the day: ");
i = int.Parse(Console.ReadLine());

void func(int i)
{
    if (i < 6)
    {
        Console.WriteLine($"{array[i-1]} не является выходным");
    }
    else
    {
        Console.WriteLine($"{array[i-1]} является выходным");
    }
}
func(i);    