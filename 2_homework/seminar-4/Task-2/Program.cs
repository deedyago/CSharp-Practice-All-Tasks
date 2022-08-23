// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Input your number:");
int number1 = int.Parse(Console.ReadLine());

int func(int a)
{
    int sum = 0;
    int temp = 0;
    for(int i = 0; number1 != 0; i++)
    {
        temp = number1 % 10;
        number1 = number1 /10;
        sum = temp + sum;
    }
    return sum;
}
Console.Write($"Sum is: {func(number1)}");