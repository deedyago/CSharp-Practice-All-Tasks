//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// Через строку
Console.Write("Input your number: ");
string number = Console.ReadLine();

void func(string number)
{
    if (number.Length > 2)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("Input has not 3rd character");
    }
}

func(number);

//Через не строку
Console.Write("Input your number: ");
int number = int.Parse(Console.ReadLine());

void func(int number)
{
    if(number/100 == 0)
    {
        Console.WriteLine("Input has not 3rd character");
    }
    else
    {
        int element = number % 10;
        Console.WriteLine(element);
    }
}

func(number);