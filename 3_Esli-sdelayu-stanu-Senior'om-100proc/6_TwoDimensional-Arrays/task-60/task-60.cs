// 60. Составить частотный словарь элементов двумерного массива
using _0_Library;
using System.Collections;

//заполнение массива
char[,] RandomArrayofChars(ref char[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int  j= 0; j < input.GetLength(1); j++)
        {
            //input[i,j]=Convert.ToChar(System.Random.Shared.Next(65, 91)); 
            input[i,j] = Convert.ToChar(new Random().Next(32, 127));    
        }
    }
    return input;
}

//печать массива
void PrintRandomArrayofChars(char[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write($"   {input[i,j]}");   
        }
        Console.WriteLine();
    }
}

double[] PowerOfString (char[,] array, string ascii)
{
    double[] temparray = new double[ascii.Length];
    for (int i = 0; i < ascii.Length; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[j,k] == ascii[i])
                {
                    temparray[i] = temparray[i] + 1.0;
                }
            }   
        } 
        temparray[i] = 100.0 * temparray[i] / (array.GetLength(0) * array.GetLength(1));
        if (temparray[i] > 0.0)
        {
            Console.WriteLine($"   {ascii[i]}: {temparray[i]} %");
        }
    }
    Console.WriteLine("\n");
    return temparray;
}

string ascii =" !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~"; //алфавит 32-127 ASCII

char[,] darray = new char[4,4];    //массив - текст
double [] darrayoutput = new double[ascii.Length]; //массив частот

darray = RandomArrayofChars(ref darray);
Console.WriteLine("\n Сгенерирован следующий массив:\n");
PrintRandomArrayofChars(darray);
Console.WriteLine("\n Массив мощностей:\n ");

darrayoutput = PowerOfString(darray, ascii);

string kek = "";
for (int  j= 0; j < 255; j++)
{
    kek = String.Concat(kek,Convert.ToChar(j));    
}
Console.WriteLine(kek);