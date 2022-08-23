// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
using _0_Library;

Console.WriteLine();
Console.Write("Input numbers separated by space (ex. 3 1 2): " );
int[] array = Library.InputToIntArray(' ');   // ..\3_Esli-sdelayu-stanu-Senior'om-100proc\0_Library\

Console.WriteLine();

(int count, int[] arrayp) Positives(int[] array)
{
    int count = 0;
    int counti = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        } 
    }
    int[] arrayp = new int[count];
    for(int i = 0; i < array.Length; i++)
    {    
        if(array[i] > 0)
        {
            arrayp[counti] = array[i];
            counti++;
        } 
    }
    
    return (count, arrayp);
}
int[] arrayp = Positives(array).arrayp;
Console.WriteLine($" There are -{Positives(array).count}- numbers > 0 \n and numbers are: ");
Library.OneDArrayPrint(arrayp);
