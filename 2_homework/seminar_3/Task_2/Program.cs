//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//Ввод данных пользователем

Console.Write("Input yr first coordinate separated by space (ex. 3 6 -2):" );
string coord1 = Console.ReadLine();
string[] strcoord1 = coord1.Split(' ');
int[] intcoord1 = new int[strcoord1.Length];

Console.Write("Input yr second coordinate separated by space (ex. 3 6 -2):");
string coord2 = Console.ReadLine();
string[] strcoord2 = coord2.Split(' ');
int[] intcoord2 = new int[strcoord2.Length];

//Метод записи строчного массива в интовский
void ToIntArray(string[] stringsarray, int[] intsarray)
{
    for (int i = 0; i < 3; i++)
    {
        intsarray[i] = int.Parse(stringsarray[i]);
    }
}

ToIntArray(strcoord1, intcoord1);
ToIntArray(strcoord2, intcoord2);

//Решение
void FindCoords(int[] yoursarray1, int[] yoursarray2)
{
    int x = 0;
    int y = 0;
    int z = 0;
    float distance = 0;

    x = (yoursarray2[0] - yoursarray1[0]) * (yoursarray2[0] - yoursarray1[0]);
    y = (yoursarray2[1] - yoursarray1[1]) * (yoursarray2[1] - yoursarray1[1]);
    z = (yoursarray2[2] - yoursarray1[2]) * (yoursarray2[2] - yoursarray1[2]);


    distance = MathF.Sqrt(x + y + z);


    Console.WriteLine(distance);

}
FindCoords(intcoord1, intcoord2);