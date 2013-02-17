using System;

    class DistinctCombinations
    {
        static void Main()
        {
            int upperLimit = 7;  //N
            int elementsInCombination = 3; // K -  meaning K if loops

            for (int i = 1; i <= upperLimit; i++)
            {
                for (int j = i; j <= upperLimit; j++)
                {
                    for (int m = j; m <= upperLimit; m++)
                    {
                        Console.WriteLine(" {0}, {1}, {2}", i, j, m);
                    }
                }
            }
        }
    }

