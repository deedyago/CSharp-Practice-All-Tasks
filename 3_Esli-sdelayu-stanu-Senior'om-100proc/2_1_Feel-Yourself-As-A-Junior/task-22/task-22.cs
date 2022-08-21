//  22. Найти расстояние между точками в пространстве 2D/3D	
using _0_Library;

//Создание массивов с координатами с помощью ввода пользователя с указание разделителя
Console.WriteLine();
Console.Write("Input yr first coordinate separated by space (ex. 3 6 -2):");
int[] coord1 = Library.InputToIntArray(' '); //<= Указывается разделитель ./,' ' etc.   // == see Library class

Console.Write("Input yr second coordinate separated by space (ex. 3 6 -2):");
int[] coord2 = Library.InputToIntArray(' ');

//Решение
Console.WriteLine();
float FindCoords(int[] yoursarray1, int[] yoursarray2)
{
    int x = 0;
    int y = 0;
    int z = 0;
    float distance = 0;
    switch ((coord1.Length + coord2.Length) / 2)
    {
        case 3:
            {
                x = (yoursarray2[0] - yoursarray1[0]) * (yoursarray2[0] - yoursarray1[0]);
                y = (yoursarray2[1] - yoursarray1[1]) * (yoursarray2[1] - yoursarray1[1]);
                z = (yoursarray2[2] - yoursarray1[2]) * (yoursarray2[2] - yoursarray1[2]);
                distance = MathF.Sqrt(x + y + z);
                Console.WriteLine($"  Distance between yours coordinates == {distance}");
                break;
            }
        case 2:
            {
                x = (yoursarray2[0] - yoursarray1[0]) * (yoursarray2[0] - yoursarray1[0]);
                y = (yoursarray2[1] - yoursarray1[1]) * (yoursarray2[1] - yoursarray1[1]);
                distance = MathF.Sqrt(x + y + z);
                Console.WriteLine($"  Distance between yours coordinates == {distance}");
                break;
            }
        default:
            {

                Console.WriteLine("  ERROR! SUCH COORDINATES CANNOT EXIST");
                
                break;
            }
    }
    return distance;
}
FindCoords(coord1, coord2);