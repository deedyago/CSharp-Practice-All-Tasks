// 65. Спирально заполнить двумерный массив
using _0_Library;

Console.WriteLine("Input strokes of yr random array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input columns of yr random array: ");
int n = int.Parse(Console.ReadLine()!);


// Пока работает для квадратных ( n x n ) и ( n + 1 x n ) массивов

int[,] ArraySpiralFill()
{
    int count = 0;
    int[,] yoursarray = new int[m,n];
    for (int i = 0; i <= n/2; i++)
    {
        for (int j = i; j <= n - i - 1; j++)
        {
            yoursarray[i, j] = count;
            count++;
        }
        for(int k = i+1; k < m - i - 1; k++)
        {
            yoursarray[k, n - i - 1] = count;
            count++;
        }
        for(int c = n - i - 1; c > i; c--)
        {
            yoursarray[m - i - 1, c] = count;
            count++;
        }
        for(int l = m - i - 1; l >= i + 1; l--)
        {
            yoursarray[l, i] = count;
            count++;
        }
    }
    return yoursarray;
}

int[,] spiralArray = ArraySpiralFill();
Library.TwoDArrayPrint(spiralArray);