//  14. Найти третью цифру числа или сообщить, что её нет
using _0_Library;


Console.WriteLine();
Console.Write("  Input number: ");
string number = Console.ReadLine()!;

void IfThere3rdChar(string n) 
{
    if (n.Length > 2)
    {
        Console.WriteLine(n[2]);
    }
    else
    {
        Console.WriteLine("Input has not 3rd character");
    }
}

IfThere3rdChar(number);
