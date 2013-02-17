using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        string[] array = new string[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter next element: ");
            array[i] = Console.ReadLine();
        }

        for (int j = 0; j < length; j++) //j - pivot element - 1st element
        {
            int pivot = j;
            for (int i = 0; i < length; i++)
            {
                if ((array[i].Length < array[pivot].Length && i > pivot) || (array[i].Length > array[pivot].Length && i < pivot))
                {
                    string temp = string.Empty;
                    temp = array[i];
                    array[i] = array[pivot];
                    array[pivot] = temp;
                    pivot = i;  
                }
            }
        }
        Console.WriteLine("The sorted array looks like: ");
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
    }
}