// 42. Определить сколько чисел больше 0 введено с клавиатуры
using _0_Library;

Console.WriteLine();
Console.Write("Input numbers separated by space (ex. 3 1 2): " );
int[] array = Library.InputToIntArray(' '); //  ../../../3_Esli-sdelayu-stanu-Senior'om-100proc/0_Library/Library.cs

Console.WriteLine();

int Positives(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($" There -{Positives(array)}- numbers > 0");
