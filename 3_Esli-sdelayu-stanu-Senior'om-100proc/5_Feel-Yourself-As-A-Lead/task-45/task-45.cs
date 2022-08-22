// 45. Показать числа Фибоначчи
using _0_Library;


//y = k1x + b1; y = k2x +b2
Console.Write(" Input size of fibonacci line: ");
int size = int.Parse(Console.ReadLine()!);

int[] FibonacciArray(int size)
{
    int[] fibonacciarray = new int[size];
    fibonacciarray[0] = 0;
    fibonacciarray[1] = 1;
    for(int i = 2; i < fibonacciarray.Length; i++)
    {
        fibonacciarray[i] = fibonacciarray[i-1] + fibonacciarray[i-2];
    }
    return fibonacciarray;
}

int[] fibonacciarray = FibonacciArray(size);
Console.WriteLine();
Library.OneDArrayPrint(fibonacciarray);
