// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
using _0_Library;

Console.WriteLine();
Console.Write("Input size of your random array: " );
int size = int.Parse(Console.ReadLine()!);


Console.WriteLine();
double[] RandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    Library.FloatRandomizer(array, min, max);
    return array;
}
double[] array = RandomArray(size, -10, 10);

Library.OneDArrayFloatPrint(array);

//Поиск и вывод разницы макс и мин значения элементов в массиве
(double ineq, double min, double max) Inequality(double[] yoursarray2)
{
    double ineq = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < yoursarray2.Length; i++)
    {
        
        if (max < yoursarray2[i])
        {
            max = yoursarray2[i];
        }
        if (min > yoursarray2[i])
        {
            min = yoursarray2[i];
        }
    }
    ineq = max - min;
    return (ineq, min, max);

}
Console.WriteLine($"\n\n   Min is [{Inequality(array).min}] and max is [{Inequality(array).max}] and their inequality is -> {Inequality(array).ineq}");
