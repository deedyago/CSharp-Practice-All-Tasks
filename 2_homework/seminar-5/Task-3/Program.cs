// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine("Input size of yr random array: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --from-- what number (ex. 1,123 5 10) : ");
double mina = double.Parse(Console.ReadLine()!);

Console.WriteLine("Input range --to-- what number (ex. 1,123 5 10) : ");
double maxa = double.Parse(Console.ReadLine()!);

double[] array = new double[size];


//Создание рандомного массива
void RandomArray(double[] yorsarray)
{
    for (int i = 0; i < yorsarray.Length; i++)
    {
        yorsarray[i] = new Random().NextDouble()*maxa-mina;
    }
}
RandomArray(array);

//Вывод созданного массива
Console.Write($"Your random array of size <{size}> from <{mina}> to <{maxa}>: ");

void ArrayPrint(double[] yorsarrayprint)
{
    for (int i = 0; i < yorsarrayprint.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}
ArrayPrint(array);

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
    return (ineq: ineq, min: min, max: max);

}
Console.WriteLine($"\nMin is [{Inequality(array).min}] and max is [{Inequality(array).max}] and their inequality is -> {Inequality(array).ineq}");