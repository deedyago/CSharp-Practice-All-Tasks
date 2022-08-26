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
         Console.Write("  ");
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write($"   {input[i,j]}");   
        }
        Console.WriteLine();
    }
}

// метод для рандомного массива двумерного массива
double[] PowerOfString (char[,] array, string ascii)
{
    double[] temparray = new double[ascii.Length];
    int CountSymbols = 0;
    int CountNumbers = 0;
    int CountLettersEng = 0;
    int CountLettersRu = 0;
    int tempCount = 0;
    int trueOrFalse = 0;

    for (int i = 0; i < ascii.Length; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[j,k] == ascii[i])
                {
                        trueOrFalse = Convert.ToInt32(array[j,k]);
                        if(trueOrFalse >= 48 && trueOrFalse <= 57)
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountNumbers++;
                                break;
                        }
                        if(trueOrFalse >= 65 && trueOrFalse <= 122)
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountLettersEng++;
                                break;
                        }
                        if(trueOrFalse >= 161 && trueOrFalse <= 252)
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountLettersRu++;
                                break;
                        }
                        else
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountSymbols++;
                        }
                  
                    temparray[i] = temparray[i] + 1.0;
                    tempCount++;
                }
            }
        } 
        temparray[i] = 100.0 * temparray[i] / (array.GetLength(0) * array.GetLength(1));
        
        if (temparray[i] > 0.0)
        {
            Console.WriteLine($"    {ascii[i]}    Symbol be found:    {tempCount}    times =>    {temparray[i]} %    of all characters");
        }
        tempCount = 0;
    }
    Console.WriteLine($"\n   There are   {CountLettersEng:D2}   english letters \n   There are   {CountLettersRu:D2}   cyrillic letters\n   There are   {CountNumbers:D2}   numbers \n   There are   {CountSymbols:D2}   symbols \n");
    Console.WriteLine("\n");
    return temparray;
}

string ascii =" !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~"; //алфавит 32-127 ASCII

char[,] darray = new char[10,10];    //массив - текст

char[] array = Console.ReadLine()!;
double [] darrayoutput = new double[ascii.Length]; //массив частот

darray = RandomArrayofChars(ref darray);

Console.WriteLine("\n Random array:\n");

PrintRandomArrayofChars(darray);

Console.WriteLine("\n Powers of characters:\n ");

darrayoutput = PowerOfString(darray, ascii);
