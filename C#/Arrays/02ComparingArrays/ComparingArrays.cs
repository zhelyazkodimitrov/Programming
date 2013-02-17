using System;

class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the two arrays N");
        int arraySize = int.Parse(Console.ReadLine());
        string[] firstArray = new string[arraySize];
        string[] secondArray = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("Please enter the {0} element of the first array", i);
            firstArray[i] = Console.ReadLine();
        }
        for (int j = 0; j < arraySize; j++)
        {
            Console.WriteLine("Please enter the {0} element of the second array", j);
            secondArray[j] = Console.ReadLine();
        }
        for (int i = 0; i < arraySize; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The {0} elements of the arrays are equal", i);
            }
            else
            {
                Console.WriteLine("The {0} elements of the arrays are not equal", i);
            }
        }
    }
}

