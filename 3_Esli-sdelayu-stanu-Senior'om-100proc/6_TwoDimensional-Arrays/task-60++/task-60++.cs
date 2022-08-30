// 60. Частотные словарь для ввода пользователя
using _0_Library;
using System.Collections;
using System.IO;


// метод для рандомного массива двумерного массива
void PowerOfString (string array)
{
    Dictionary<char, int> symbols = new Dictionary<char, int> ();

   
    int CountSymbols = 0;
    int CountNumbers = 0;
    int CountLettersEng = 0;
    int CountLettersRu = 0;
    int tempCount = 0;
    int trueOrFalse = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (symbols.ContainsKey(array[j]))
        {
            symbols[array[j]]++;
        }
        else
        {
            symbols.Add(array[j], 1);
        }
                        tempCount++;                    
                        trueOrFalse = Convert.ToInt32(array[j]);
                        if (char.IsDigit(array[j]))
                        {
                                CountNumbers++;
                                
                        }
                        else if((array[j] >= 'A' && array[j] <= 'Z') || (array[j] >= 'a' && array[j] <= 'z'))
                        {
                                CountLettersEng++;
                                
                        }
                        else if((array[j] >= 'А' && array[j] <= 'Я') || (array[j] >= 'а' && array[j] <= 'я'))
                        {
                                CountLettersRu++;
                                
                        }
                        else
                        {
                                CountSymbols++;
                        }
    } 
    Console.WriteLine(String.Join("\r\n",symbols.Select(c,)))

    Console.WriteLine($"\n   There are   {CountLettersEng:D2}   english letters \n   There are   {CountLettersRu:D2}   cyrillic letters\n   There are   {CountNumbers:D2}   numbers \n   There are   {CountSymbols:D2}   symbols \n");
    Console.WriteLine("\n");
}


// Через ввод пользователя
Console.WriteLine("\n Input your text: \n");
string array = Console.ReadLine()!;
char[] arrray = array.ToCharArray();

Console.WriteLine("\n Powers of characters:\n ");

string path = @"D:\Разработчик\Введение-в-прогу\3_Esli-sdelayu-stanu-Senior'om-100proc\6_TwoDimensional-Arrays\task-60++\Text.txt";
using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
{
    PowerOfString(sr.ReadToEnd());
}



/*var deict = "qwqweqeqweqeqweqweeqw".GroupBy(e=>e);
foreach (var kvp in deict)
{
    Console.WriteLine($"{kvp.Key} {kvp.Count()}");
}*/