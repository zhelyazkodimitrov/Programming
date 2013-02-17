using System;

class LexicographicalComparison
{
    static void Main()
    {
        Console.Write("Please enter the first string of characters: ");
        string firstString = Console.ReadLine();
        Console.Write("Please enter the second string of characters: ");
        string secondString = Console.ReadLine();

        char[] firstCharArray = firstString.ToCharArray();
        int firstCharLength = firstCharArray.Length;

        char[] secondCharArray = secondString.ToCharArray();
        int secondCharLength = secondCharArray.Length;

        int minLength = Math.Min(firstCharLength, secondCharLength);
        bool identical = true;

        for (int i = 0; i < minLength; i++)
        {
            if (firstCharArray[i] < secondCharArray[i])
            {
                Console.WriteLine("The first string of chars comes lexicographically first");
                identical = false;
                break;
            }

            else if (firstCharArray[i] > secondCharArray[i])
            {
                Console.WriteLine("The second string of chars comes lexicographically first");
                identical = false;
                break;
            }
        }
        if (identical == true)
        {
            if (firstCharLength < secondCharLength)
            {
                Console.WriteLine("The first string of chars comes lexicographically first");
            }
            else if (firstCharLength > secondCharLength)
            {
                Console.WriteLine("The second string of chars comes lexicographically first");
            }
            else
            {
                Console.WriteLine("The 2 strings of chars are identical");
            }
        }
    }
}

