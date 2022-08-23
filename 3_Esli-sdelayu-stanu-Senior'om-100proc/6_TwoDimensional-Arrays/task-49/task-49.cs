// 49. Показать двумерный массив размером m×n заполненный вещественными числами
using _0_Library;


//y = k1x + b1; y = k2x +b2
Console.WriteLine($" Input number of strokes of your array: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input number of columns of your array: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer from... => ");
double min = double.Parse(Console.ReadLine()!);

Console.WriteLine($" Input range of randomizer ...to => ");
double max = double.Parse(Console.ReadLine()!);

Console.WriteLine();


double[,] darray = Library.TwoDFloatArray(m, n, min, max);    


Library.TwoDFloatArrayPrint(darray);


