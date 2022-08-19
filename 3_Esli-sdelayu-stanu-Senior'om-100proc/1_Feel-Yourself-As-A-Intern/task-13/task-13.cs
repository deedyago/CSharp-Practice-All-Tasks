//  13. Выяснить, кратно ли число заданному, если нет, вывести остаток
using _0_Library;


Console.WriteLine();
Console.Write("  Input number 1: ");
 int number1 =  int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.Write("  Input number 2: ");
 int number2 =  int.Parse(Console.ReadLine()!);

 int Divide( int n1,  int n2) 
{
    int residue = n1 % n2;
    if(n2 % n1 == 0)
    {
        Console.WriteLine($"   {n2} is dividable on {n1}");
        return n2;
    }
    else
    {
        Console.WriteLine($"   Number {n2} is not dividable on {n1} and the residue is: {residue}");
        return n2 % n1;
    }
}
Divide(number1, number2);
