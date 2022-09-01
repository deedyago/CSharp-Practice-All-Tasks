using _0_Library;


int[,] labirint = new int[10, 10]
{
    {1, 1, 2, 1, 1, 1, 1, 1, 1, 1},
    {1, 1, 0, 0, 1, 0, 1, 0, 0, 1},
    {1, 1, 1, 0, 1, 0, 1, 0, 1, 1},
    {1, 0, 0, 0, 0, 0, 1, 0, 0, 1},
    {1, 0, 1, 0, 1, 1, 1, 1, 0, 1},
    {1, 0, 1, 0, 0, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 0, 1, 1},
    {1, 0, 0, 0, 1, 0, 0, 0, 0, 1},
    {1, 0, 1, 0, 0, 0, 1, 0, 0, 1},
    {1, 3, 1, 1, 1, 1, 1, 1, 1, 1}
};

//Library.TwoDArrayPrint(labirint);

int startX = 9;
int startY = 1;



static void PrintMatrix2DBeautifully(int[,] matrix) //Вывод двумерного массива (матрицы) в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 1) Console.Write("х ");
            if (matrix[i, j] == 0) Console.Write("  ");
            if (matrix[i, j] == 2) Console.Write("В ");
            if(matrix[i, j] == 3) Console.Write("K ");
            if (matrix[i, j] == 4) Console.Write("- ");

        }
        Console.WriteLine();
    }
}
PrintMatrix2DBeautifully(labirint);




(int[,], int, int) Movment(int[,] matrix, int xPos, int yPos)
{
    int[,] bufferLabirint = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int xPosBuf = xPos;
    int yPosBuf = yPos;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            bufferLabirint[i, j] = matrix[i, j];
        }
    }
    //Движение вверх i - 1 вниз i + 1 влево y - 1 вправо y + 1
    if (matrix[xPosBuf, yPosBuf] != 2)
    {
        if (matrix[xPosBuf - 1, yPosBuf] != 1  && (xPosBuf < matrix.GetLength(0) && xPosBuf > 0))
        {
            bufferLabirint[xPosBuf - 1, yPosBuf] = 3;
            bufferLabirint[xPosBuf, yPosBuf] = 4;
            xPosBuf--;
            Movment(bufferLabirint, xPosBuf, yPosBuf);
        }
        else if (matrix[xPosBuf, yPosBuf + 1] != 1 && (yPosBuf < matrix.GetLength(1) && yPosBuf > 0))
        {
            bufferLabirint[xPosBuf, yPosBuf + 1] = 3;
            bufferLabirint[xPosBuf, yPosBuf] = 4;
            yPosBuf++;
            Movment(bufferLabirint, xPosBuf, yPosBuf);
        }
        else if (matrix[xPosBuf + 1, yPosBuf] != 1 && (xPosBuf < matrix.GetLength(0) && xPosBuf > 0))
        {
            bufferLabirint[xPosBuf + 1, yPosBuf] = 3;
            bufferLabirint[xPosBuf, yPosBuf] = 4;
            xPosBuf++;
            Movment(bufferLabirint, xPosBuf, yPosBuf);
        }
        else if (matrix[xPosBuf, yPosBuf - 1] != 1 && (yPosBuf < matrix.GetLength(1) && yPosBuf > 0))
        {
            bufferLabirint[xPosBuf, yPosBuf - 1] = 3;
            bufferLabirint[xPosBuf, yPosBuf] = 4;
            yPosBuf--;
            Movment(bufferLabirint, xPosBuf, yPosBuf);
        }
    }
    else
    {
        Console.WriteLine("Kek");
    }
    return (bufferLabirint, xPosBuf, yPosBuf);
}

(labirint, startX, startY) = Movment(labirint, startX, startY);
PrintMatrix2DBeautifully(labirint);

Console.WriteLine($"{startX}, {startY}");