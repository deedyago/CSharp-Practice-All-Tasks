// 46. Написать программу масштабирования фигуры
using _0_Library;
using System.Collections;


//y = k1x + b1; y = k2x +b2
Console.WriteLine(" Input your coordinates ex. ( 0,0 1,1 2,2 ): ");
double[] coords = Library.InputToFloatArray(' ');

Console.WriteLine(" Input scale factor: ");
double scale = double.Parse(Console.ReadLine()!);

double[] ScaleArray(double[] array, double scalefactor)
{
    double[] coordsf = new double[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        coordsf[i] = array[i] * scalefactor;
    }
    return coordsf;
}

double[] coordsf = ScaleArray(coords,scale);

Console.WriteLine();

Console.WriteLine(" Your coords ");
Library.OneDArrayFloatPrint(coords);
Console.WriteLine($" \n were scaled by {scale} to ");
Library.OneDArrayFloatPrint(coordsf);


