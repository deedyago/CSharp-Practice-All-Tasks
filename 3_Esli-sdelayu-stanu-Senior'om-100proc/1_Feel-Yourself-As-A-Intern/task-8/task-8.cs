// 8. Показать четные числа от 1 до N
using _0_Library;


Console.WriteLine();
Console.Write("  Input your number : ");
int number = int.Parse(Console.ReadLine()!);

void EvenTillN(int n)
{
    int[] evenarray = new int[n+1];
    Console.Write($" Even number till {number} are: ");
    for(int i = 1; i <= n; i++)
    {
        if(i % 2 == 0)
        {
            evenarray[i] = i;
            Console.Write($"{evenarray[i]} ");
        }
        
    }
}
EvenTillN(number);

