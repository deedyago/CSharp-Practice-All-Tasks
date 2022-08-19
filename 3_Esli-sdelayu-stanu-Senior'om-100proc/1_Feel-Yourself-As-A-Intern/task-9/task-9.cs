//  9. Показать последнюю цифру трёхзначного числа
using _0_Library;


Console.WriteLine();
Console.Write("  Input your number : ");
int number = int.Parse(Console.ReadLine()!);

int LastCharOf(int n)
{
  int lastchar = number %= 10;
  return lastchar;
}
Console.WriteLine($"   Last char of number {number} is => {LastCharOf(number)} ");

