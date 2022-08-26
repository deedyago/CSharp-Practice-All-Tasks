// 61. Найти произведение двух матриц
using _0_Library;
using System.Collections;

//Ввод любых размеров матриц и их наполнения
Console.WriteLine("Input strokes of yr 1st random matrix: ");
int m1 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input columns of yr 1st random matrix: ");
int n1 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --from-- what number: ");
int min1 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --to-- what number: ");
int max1 = int.Parse(Console.ReadLine())!;

int[,] matrix1 = new int[m1, n1];

Console.WriteLine("Input strokes of yr 2nd random matrix: ");
int m2 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input columns of yr 2nd random matrix: ");
int n2 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --from-- what number: ");
int min2 = int.Parse(Console.ReadLine())!;

Console.WriteLine("Input range --to-- what number: ");
int max2 = int.Parse(Console.ReadLine())!;


int[,] matrix2 = new int[m2, n2];

 //Задаем размер финальной матрицы по правилам математики:d
int[,] matrix3 = new int[m1, n2];

// Ставим условие выполнения кода тоже по правилам математики
if(m1 == n2)
{
    //Создание рандомных матриц
    matrix1 = Library.TwoDArray(m1, n1, min1, max1);
    matrix2 = Library.TwoDArray(m1, n1, min1, max1);

    Console.WriteLine();

    Library.TwoDArrayPrint(matrix1);
    Library.TwoDArrayPrint(matrix2);



    //Блок с вычислением произведения созданных матриц:d
    int[,] MatrixOp(int[,] yoursmatrix1, int[,] yoursmatrix2)
    {
        int optemp1 = 0;
        int sum = 0;
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                for (int k = 0; k < n1; k++)
                {
                    optemp1 = yoursmatrix1[i, k] * yoursmatrix2[k, j];
                    sum = sum + optemp1;
                    optemp1 = 0;
                }
                matrix3[i, j] = sum;
                sum = 0;
            }
        }
        return matrix3;
    }

    matrix3 = MatrixOp(matrix1,matrix2);

    Console.WriteLine();

    //Вывод получившейся матрицы
    void EndMatrixPrint(int[,] yoursmatrix)
    {
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write($" {yoursmatrix[i, j]:D3} ");

            }
            Console.WriteLine();
        }
    }
    EndMatrixPrint(matrix3);
}
else
{
    Console.WriteLine();
    Console.WriteLine("   MATRIXES WITH SUCH SIZES CANNOT BE MULTIPLIED TOGETHER \n(ps.: columns of 1st matrix must be equal to strokes of second one)\n");
}

