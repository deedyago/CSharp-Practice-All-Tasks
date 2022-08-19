//  11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
using _0_Library;


Console.WriteLine();
int number = new Random().Next(10, 99);

int BiggerChar(int n)
{
  int char1 = number % 10;
  int char2 = number / 10;

  if(char1 > char2)
    {
        return char1;
    }
    else
    {
        return char2;
    }
}
Console.WriteLine($"   In number {number} bigger char is => {BiggerChar(number)}");

