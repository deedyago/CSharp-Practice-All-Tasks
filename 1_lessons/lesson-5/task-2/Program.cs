
int[] array = new int[10];
int[] array2 = new int[(array.Length/2)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,15);
}

void Find(int[] arr)
{
    int sumtemp = 0;    
    for(int i = 0; i < arr.Length/2; i++)
    {
        sumtemp = arr[i] + arr[arr.Length - 1 -i];
        array2[i] = sumtemp;
    }
}
Find(array);


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]} ");
    }
}
Print(array);
Console.WriteLine();
Print(array2);