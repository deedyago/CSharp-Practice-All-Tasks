//  21. Программа проверяет пятизначное число на палиндромом
using _0_Library;


Console.WriteLine();
Console.Write(" Input number: ");
int number = int.Parse(Console.ReadLine()!); 

if(Library.IfIntIsPalidrome(number) == 1)
{
    Console.WriteLine($"Your number //{number}// is a palindrom");
}
else
{
    Console.WriteLine($"Your number //{number}// is not a palindrom");
}
