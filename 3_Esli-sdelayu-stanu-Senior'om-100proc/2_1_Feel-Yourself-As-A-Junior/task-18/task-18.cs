//  18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y	
using _0_Library;


Console.WriteLine();
Console.Write(" Input x: ");
int number1 = Library.InputToInt(Console.ReadLine()!); // = int number = int.Parse(Console.ReadLine()!);

Console.Write(" Input y: ");
int number2 = Library.InputToInt(Console.ReadLine()!);

//(!A && !B=!(A || B)