// 7. Показать числа от -N до N
using _0_Library;


Console.WriteLine();
Console.Write("  Input your number : ");
int number = int.Parse(Console.ReadLine()!);

void NPrint(int n)
{
    int[] narray = new int[(n*2)+1];
    for(int i = 0; i <= n*2; i++)
    {
        narray[i] = (n*-1) + i;
        Console.Write($"{narray[i]} ");
    }
}
NPrint(number);

