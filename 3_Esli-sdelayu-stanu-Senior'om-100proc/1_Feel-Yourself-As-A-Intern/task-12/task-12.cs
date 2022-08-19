//  12. Удалить вторую цифру трёхзначного числа
using _0_Library;


Console.WriteLine();
Console.Write("  Input your number : ");
int number = int.Parse(Console.ReadLine()!);

(int, int, int) DeleteSecondChar(int n) 
{
  int lastchar = number % 10;
  int firstchar = number / 100;

  int middlechar = number / 10;
    middlechar %= 10;

  return (firstchar, lastchar, middlechar);
}
Console.WriteLine($"   Output number is {DeleteSecondChar(number).Item1}{DeleteSecondChar(number).Item2} by deleting {DeleteSecondChar(number).Item3} in number {number}");
