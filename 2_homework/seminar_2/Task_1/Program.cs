//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int number = 0;

Console.Write("Input a 3 character number:" );
number = int.Parse(Console.ReadLine());

int Sqr (int a)
{
    int result = a/10;
    int b = result % 10;
    Console.WriteLine($"Second character of your number {a} is: {b}");
    return b; 
}
Sqr(number);