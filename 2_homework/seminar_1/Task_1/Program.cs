// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Input 1st number: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Input 2nd number: ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 < number_2)
{
    Console.WriteLine($"Min number is {number_1}\nMax number is {number_2}");
}
else
{
    Console.WriteLine($"Min number is {number_2}\nMax number is {number_1}");
}