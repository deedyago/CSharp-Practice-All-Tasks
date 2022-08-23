// Написать метод, принимающий бинарное представление числа и возвращающее десятичное представление числа


//Вроде бы получилось сделать универсальный из любой системы в десятичную
Console.WriteLine("Input your number: ");
string number = Console.ReadLine();

Console.WriteLine("Input numeral system: ");
int numeral = int.Parse(Console.ReadLine()!);

int Ten(string number)
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
       sum = (sum * numeral) + int.Parse(Convert.ToString(number[i]));    
    } 
    return sum;

}
Console.WriteLine($"Equivalent in decimal numeral system of your number -{number}- in -{numeral}- numeral system is => {Ten(number)}");