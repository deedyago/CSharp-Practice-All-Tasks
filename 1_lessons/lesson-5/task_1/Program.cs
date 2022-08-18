int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,134);
}

int Find2(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count += 1;
        }
    }
    return count;
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]} ");
    }
}
Print(array);
Console.WriteLine($" = {Find2(array)}");