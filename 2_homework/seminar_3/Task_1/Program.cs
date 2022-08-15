//Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом

//Через строку
Console.Write("Input your number:" );
string number = Console.ReadLine();

Console.WriteLine();
void Pal (string a)
{
    int count = 0;
    for (int i = 0; i < number.Length/2; i++)
    {
        if (number[i] == number[number.Length - 1 - (i)])
        {
            count = count + 1;
        }
        else
        {
            count = count + 0;
        }
    }
    if (count == number.Length/2)
    {
        Console.WriteLine($"Your number //{number}// is a palindrom");
    }
    else
    {
        Console.WriteLine($"Your number //{number}// is not a palindrom");
    }
}
Pal(number);
Console.WriteLine();

//Через не строку
Console.Write("Input your number:" );
int number2 = int.Parse(Console.ReadLine());

void Pallindrome(int number)
{
    int numbertemp = number;
    int element = 0;
    int sumtemp = 0;
    while(numbertemp != 0)
    {
        element = numbertemp%10;
        sumtemp = (sumtemp * 10) + element;
 
        numbertemp = numbertemp/10;
    }
    if(sumtemp == number)
    {
        Console.WriteLine($"Your number //{number}// is a palindrom");
    }
    else
    {
        Console.WriteLine($"Your number //{number}// is not a palindrom");
    }
}
Pallindrome(number2);