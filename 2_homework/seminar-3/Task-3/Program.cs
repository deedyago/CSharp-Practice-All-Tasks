//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Input your number:" );
int number = int.Parse(Console.ReadLine())!;

Console.WriteLine();

void Cube(int yournumber)
{
    int cube = 1;
    for (int i = 1; i <= yournumber; i++)
    {
        cube = i * i * i;
        Console.Write($"{cube} ");
    }
    Console.Write($" <- all cubes till the number {yournumber}");
    Console.WriteLine();
}
Cube(number);