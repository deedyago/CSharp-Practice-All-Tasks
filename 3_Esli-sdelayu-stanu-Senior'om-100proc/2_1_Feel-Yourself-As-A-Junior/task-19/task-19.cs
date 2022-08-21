//  19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
using _0_Library;


Console.WriteLine();
Console.Write(" Input x: ");
int x = Library.InputToInt(Console.ReadLine()!); // = int number = int.Parse(Console.ReadLine()!);

Console.Write(" Input y: ");
int y = Library.InputToInt(Console.ReadLine()!);

int NumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    } 
    if (x > 0 && y < 0) 
    {
        return 4;
    }
       
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 0;
}
Console.WriteLine($" {x} and {y} are in {NumberOfQuarter(x,y)}  quarter");