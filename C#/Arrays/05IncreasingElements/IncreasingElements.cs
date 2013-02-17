using System;

class EqualElements
{
    static void Main()
    {
        Console.Write("Please enter the number of integers of the sequence: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter the next integer: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int startMax = 0;
        int lengthMax = 1;
        int startNew = 0;
        int lengthNew = 1;
        for (int i = 1; i < length; i++)
        {

            if (array[i] > array[i - 1])
            {
                lengthNew++;
            }
            else
            {
                startNew = i;
                lengthNew = 1;
            }

            if (lengthNew > lengthMax)
            {
                lengthMax = lengthNew;
                startMax = startNew;
            }
        }

        Console.WriteLine("The maximal increasing sequense consists of:");
        for (int i = startMax; i < startMax + lengthMax; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}

