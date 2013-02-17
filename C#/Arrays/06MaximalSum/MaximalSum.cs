using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the size of the array N: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of elements with max sum K: ");
        int elementsNumber = int.Parse(Console.ReadLine());

        List<int> array = new List<int>();
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter the next number in the array: ");
            array.Add(int.Parse(Console.ReadLine()));
        }

        array.Sort();
        long maxSum = new long();
        Console.WriteLine("The following K elements have the max possible sum in this array:");
        for (int i = length - elementsNumber; i < length; i++)
        {
            Console.WriteLine(array[i]);
            maxSum += array[i];
        }
        Console.WriteLine("And the max sum in {0}", maxSum);
    }
}

