using System;
using System.Collections.Generic;


class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: ");
        int length = int.Parse(Console.ReadLine());

        List<int> array = new List<int>();
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter the next number in the array: ");
            array.Add(int.Parse(Console.ReadLine()));
        }

        array.Sort();

        int startCurrent = 0;
        int lengthCurrent = 1;
        int startMax = 0;
        int lenghtMax = 1;

        for (int i = 1; i < length; i++)
        {
            if (array[i] == array[startCurrent])
            {
                lengthCurrent++;
            }
            else
            {
                startCurrent = i;
                lengthCurrent = 1;
            }

            if (lengthCurrent > lenghtMax)
            {
                startMax = startCurrent;
                lenghtMax = lengthCurrent;
            }
        }

        Console.WriteLine("The number {0} is repeated the most - {1} times", array[startMax], lenghtMax);
    }
}

