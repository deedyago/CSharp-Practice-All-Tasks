// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Input 1st number: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Input 2nd number: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Input 3rd number: ");
int number_3 = int.Parse(Console.ReadLine());

if (number_1 > number_2)
{
    if (number_1 > number_3)
    {
        Console.WriteLine($"{number_1} is a maximum");
    }
    else
    {
        if (number_3 > number_2)
        {
            Console.WriteLine($"{number_3} is a maximum");
        }
        else
        {
            Console.WriteLine($"{number_2} is a maximum");
        }
    }
}
else
{
    if (number_2 > number_3)
    {
        Console.WriteLine($"{number_2} is a maximum");
    }
    else
    {
        Console.WriteLine($"{number_3} is a maximum");
    }
}