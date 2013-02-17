using System;

class SelectionSort
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

        int currentMin, temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            currentMin = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[currentMin])
                {
                    currentMin = j;
                }
            }

            if (i != currentMin)
            {
                temp = array[i];
                array[i] = array[currentMin];
                array[currentMin] = temp;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The array sorted in ascending order is:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}