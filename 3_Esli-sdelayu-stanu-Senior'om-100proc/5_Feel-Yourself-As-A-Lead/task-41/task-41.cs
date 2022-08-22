// 41. Выяснить являются ли три числа сторонами треугольника 
using _0_Library;

Console.WriteLine();
Console.Write("Input numbers separated by space (ex. 3 1 2): " );
int[] array = Library.InputToIntArray(' ');

Console.WriteLine();

void IfTriangle(int[] array)
{
    if (array[0] + array[1] > array[2])
    {
        if(array[1] + array[2] > array[0])
        {
            if(array[0] + array[2] > array[1])
            {
                Console.WriteLine($" Triangle with such sides ({array[0]}, {array[1]}, {array[2]}) => can exist");
            }
            else
            {
                Console.WriteLine($" Triangle with such sides ({array[0]}, {array[1]}, {array[2]}) => cannot exist");
            }
        }
        else
        {
            Console.WriteLine($" Triangle with such sides ({array[0]}, {array[1]}, {array[2]}) => cannot exist");
        }
    }
    else
    {
        Console.WriteLine($" Triangle with such sides ({array[0]}, {array[1]}, {array[2]}) => cannot exist");
    }
}
IfTriangle(array);
