using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter the next integer: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        int maxSum = int.MinValue;

        //check if all elements are negative
        bool allNegative = true;
        for (int i = 0; i < length; i++)
        {
            if (array[i] >= 0)
            {
                allNegative = false;
                break;
            }
            if (array[i] > maxSum)
            {
                maxSum = array[i];
            }
        }

        if (allNegative)
        {
            Console.WriteLine("The max sum consisist of a single element and is {0}", maxSum);
        }
        else
        {
            maxSum = 0;
            int currentSum = 0;
            int startIndex = 0;
            int lengthMax = 0;
            int currentLength = 0;
            int currentIndex = 0;

            for (int i = 0; i < length; i++)
            {
                currentSum += array[i];
                if (currentSum > 0)
                {
                    currentLength++;
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        lengthMax = currentLength;
                        startIndex = currentIndex;
                    }
                }

                else
                {
                    currentSum = 0;
                    currentLength = 0;
                    currentIndex = i + 1;
                }
            }

            Console.WriteLine("The maximal sum is made of the following elemets:");
            for (int i = startIndex; i < startIndex + lengthMax; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("And the maximal sum is {0}", maxSum);
        }

    }
}
