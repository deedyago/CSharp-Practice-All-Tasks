using System;

public class Library
{
    // метод ввода:D
    public static int InputToInt(string input)
    {
        int output = 0;
        output = int.Parse(input);
        return output;
    }

    // метод проверки на четность
    public bool IfEven(int input)
	{
        if (input % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // метод сравнения чисел
    public (int, int) MaxAndMin(int input1, int input2)
	{
        if (input1 > input2 )
        {
            return (i1: input1, i2: input2);
        }
        else
        {
            return (i1: input2, i2: input1);
        }
    }

    // метод проверки строки на палиндромность
    public int IfStringIsPalidrome(string input)
    {
        int count = 0;
        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] == input[input.Length - 1 - (i)])
            {
                count = count + 1;
            }
            else
            {
                count = count + 0;
            }
        }
        if (count == input.Length / 2)
        {
            return count = 1;
        }
        else
        {
            return count = 0;
        }
    }

    // метод проверки числа на палиндромность
    public int IfIntIsPalidrome(int input)
    {
        int numbertemp = input;
        int element = 0;
        int sumtemp = 0;
        while (numbertemp != 0)
        {
            element = numbertemp % 10;
            sumtemp = (sumtemp * 10) + element;

            numbertemp = numbertemp / 10;
        }
        if (sumtemp == input)
        {
            return sumtemp = 1;
        }
        else
        {
            return sumtemp = 0;
        }
    }


    // метод нахождения расстояние между 2-умя точками в 3D пространстве
    public float Find3DDistance(int[] yoursarray1, int[] yoursarray2)
    {
        int x = 0;
        int y = 0;
        int z = 0;
        float distance = 0;

        x = (yoursarray2[0] - yoursarray1[0]) * (yoursarray2[0] - yoursarray1[0]);
        y = (yoursarray2[1] - yoursarray1[1]) * (yoursarray2[1] - yoursarray1[1]);
        z = (yoursarray2[2] - yoursarray1[2]) * (yoursarray2[2] - yoursarray1[2]);


        distance = MathF.Sqrt(x + y + z);
        return distance;

    }

    // метод, который возводит A в натуральную степень B
    public int AInSqrB(int number1, int number2)
    {
        int step = 1;
        for (int i = 0; i < number2; i++)
        {
            step = step * number1;
        }
        return step;

    }


    // метод рандомайзера натуральных чисел
    public static void NaturalRamdomizer(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }



}
