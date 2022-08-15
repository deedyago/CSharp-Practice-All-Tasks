// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Input first number:");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Input second number:");
int number2 = int.Parse(Console.ReadLine());
int step = 1;

int func(int number1, int number2)
{
    for(int i = 0; i < number2; i++)
    {
            step = step * number1;
    }
    return step;
}
Console.Write($"Exponent is: {func(number1, number2)}");
