// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита


using _0_Library;

string input = "asiv";

int[] buffer = new int[input.Length-1];
int sum = -1;
for(int i = 0; i < 4; i++)
{
    if(sum == 3) sum = 0;
    buffer[i] = sum + 1;
}
sum = 0;
for(int i = 0; i < 4; i++)
{
    Console.Write(input[i]);
}
Console.WriteLine();