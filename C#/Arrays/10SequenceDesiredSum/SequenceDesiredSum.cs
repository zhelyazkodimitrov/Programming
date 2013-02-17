using System;

class SequenceDesiredSum
{
    static void Main()
    {
        Console.Write("Please enter the length of the array:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Please enter the next integer: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter the Sum that is needed: ");
        int desiredSum = int.Parse(Console.ReadLine());

        bool sumFound = false;
        
        for (int i = 0; i < arrayLength; i++)
        {
            long currentSum = 0;
            for (int j = i; j < arrayLength; j++)
            {
                currentSum += array[j];
                if (currentSum == desiredSum)
                {
                    Console.WriteLine("The following consequtive element(s) make the desired sum:");
                    for (int m = i; m <= j; m++)
                    {
                        Console.Write("{0} ", array[m]);
                        sumFound = true;
                        
                    }

                    Console.WriteLine();
                }
            }
        }
        if (!sumFound)
        {
            Console.WriteLine("There is no such sequence of numbers");
        }
    }
}

