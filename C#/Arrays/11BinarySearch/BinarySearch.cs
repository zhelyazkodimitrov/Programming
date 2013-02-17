using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        List<int> array = new List<int>();
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Please enter the next number in the array: ");
            array.Add(int.Parse(Console.ReadLine()));
        }

        array.Sort();
        Console.WriteLine();
        Console.WriteLine("Your array was sorted. It looks like this:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        Console.Write("Please enter the number which index is sought in the sorted array: ");
        int desiredElement = int.Parse(Console.ReadLine());

        int currentStartPosition = 0;
        int currentEndPosition = array.Count - 1;
        int currentMiddlePosition = new int();
        bool elementFound = false;

        while (currentEndPosition >= currentStartPosition)
        {
            currentMiddlePosition = (currentStartPosition + currentEndPosition) / 2;

            if (desiredElement < array[currentMiddlePosition])
            {
                currentEndPosition = currentMiddlePosition - 1;
            }

            else if (desiredElement > array[currentMiddlePosition])
            {
                currentStartPosition = currentMiddlePosition + 1;
            }
            else
            {
                elementFound = true;
                Console.WriteLine("The desired element was found at position {0}", currentMiddlePosition);
                break;
            }

        }

        if (!elementFound)
        {
            Console.WriteLine("No such element was found");
        }
    }
}


