// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем
using _0_Library;

Console.WriteLine();
Console.Write("  Input b1:");
float b1 = float.Parse(Console.ReadLine()!);

Console.Write("  Input k1:");
float k1 = float.Parse(Console.ReadLine()!);

Console.Write("  Input b2:");
float b2 = float.Parse(Console.ReadLine()!);

Console.Write("  Input k2:");
float k2 = float.Parse(Console.ReadLine()!);

//y = k1x + b1; y = k2x +b2
(float x, float y) Find(float b1, float k1, float b2, float k2)
{
    float x = 0;
    float y = 0;

    x = (b2 - b1) / (k1 - k2);

    y = k1 * x + b1;
    return (x, y);
}
Console.WriteLine();
Console.WriteLine($"  Точка пересечения прямых: x = [{Find(b1, k1, b2, k2).x}], y = [{Find(b1, k1, b2, k2).y}]\n "); ;