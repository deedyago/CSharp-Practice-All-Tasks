//Написать метод, принимающий десятичное представление и основание СС в которую нужно это число перевести, 2<= основание СС <= 9

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Input numeral system: ");
int osnovanie = int.Parse(Console.ReadLine());

string Ten(int number, int osnovanie)
{
    string str = "";
    while(number > 0)
    {
        int sum = 0;
        sum = number % osnovanie;
        number  = number/osnovanie;
        str = sum + str;
    }
    return str;
}
Console.WriteLine($"Equivalent in -{osnovanie}- numeral system of your number -{number}- in decimal numeral system is => {Ten(number,osnovanie)}");
