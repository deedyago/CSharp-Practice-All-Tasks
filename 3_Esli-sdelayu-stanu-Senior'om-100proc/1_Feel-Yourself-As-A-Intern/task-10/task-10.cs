//  9. Показать последнюю цифру трёхзначного числа
using _0_Library;


Console.WriteLine();
Console.Write("  Input your number : ");
int number = int.Parse(Console.ReadLine()!);

int SecondCharOf(int n)
{
  int lastchar = number / 10;
  lastchar %= 10;
  return lastchar;
}
Console.WriteLine($"   Second char of number {number} is => {SecondCharOf(number)} ");

