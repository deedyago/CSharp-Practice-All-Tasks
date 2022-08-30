// 60. Частотные словарь для ввода пользователя
using _0_Library;
using System.Collections;

// метод для рандомного массива двумерного массива
double[] PowerOfString (char[] array, string ascii)
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
        for (int j = 0; j < array.Length; j++) //Char.GetNumericValue
        {
            if (array[j] == ascii[i])
            {
                        tempCount++;
                        //trueOrFalse = char.GetNumericValue(array[j]);
                        trueOrFalse = Convert.ToInt32(array[j]);
                        if (char.IsDigit(array[j]))
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountNumbers++;
                                
                        }
                        if(trueOrFalse >= 65 && trueOrFalse <= 122)
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountLettersEng++;
                                
                        }
                        if(trueOrFalse >= 161 && trueOrFalse <= 252)
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountLettersRu++;
                                
                        }
                        /*else
                        {
                                temparray[i] = temparray[i] + 1.0;
                                CountSymbols++;
                        }*/
                  
                        temparray[i] = temparray[i] + 1.0;  
            }
        } 
        temparray[i] = 100.0 * temparray[i] / array.Length;
        if (temparray[i] > 0.0)
        {
            Console.WriteLine($"    {ascii[i]}    Symbol be found:    {tempCount:D3}    times =>    {temparray[i]:F2} %    of all characters");
        }
        tempCount = 0;
    }
    Console.WriteLine($"\n   There are   {CountLettersEng:D2}   english letters \n   There are   {CountLettersRu:D2}   cyrillic letters\n   There are   {CountNumbers:D2}   numbers \n   There are   {CountSymbols:D2}   symbols \n");
    Console.WriteLine("\n");
    return temparray;
}

string ascii =" !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~"; //алфавит 32-127 ASCII   //массив - текст

// Через ввод пользователя
/*Console.WriteLine("\n Input your text: \n");
string array = Console.ReadLine()!;
char[] arrray = array.ToCharArray();*/

// Через подгрузку текстового файла
string array = System.IO.File.ReadAllText(@"D:\Разработчик\Введение-в-прогу\3_Esli-sdelayu-stanu-Senior'om-100proc\6_TwoDimensional-Arrays\task-60+\Text.txt");
char[] arrray = array.ToCharArray();


double [] darrayoutput = new double[ascii.Length];

Console.WriteLine("\n Powers of characters:\n ");

darrayoutput = PowerOfString(arrray, ascii);
