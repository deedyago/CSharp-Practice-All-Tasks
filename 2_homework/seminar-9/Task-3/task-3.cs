// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
using _0_Library;

Console.WriteLine("   Input M: ");
int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("   Input N: ");
int.TryParse(Console.ReadLine(), out int n);


Console.WriteLine();
 int Akkerman( int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }

    else
    {
        if ((n != 0) && (m == 0))
        {
            return Akkerman(n - 1, 1);
        }
        else
        {
            return Akkerman(n - 1, Akkerman(n, m - 1));
        } 
    }
}
Console.WriteLine(Akkerman(n, m));