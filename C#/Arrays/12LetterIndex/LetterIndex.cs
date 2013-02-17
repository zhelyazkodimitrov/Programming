using System;
using System.Collections.Generic;

class LetterIndex
{
    static void Main()
    { 
        char[] letterArray = new char['z' - 'a' + 1];
        for (int i = 0; i < letterArray.Length; i++)
        {
            letterArray[i] = (char)('a' + i);
        }
        Console.WriteLine("Please enter a word:");
        string word = Console.ReadLine().ToLower();

        foreach (char letter in word)
        {
            Console.WriteLine("Letter {0} - position in alphabet: {1}", letter, letter - 'a' + 1);
        }
    }
}


