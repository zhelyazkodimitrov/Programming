using System;

class Variations
{
    static void Main()
    {
        //int upperLimit = 7;  //N
        //int elementsInCombination = 3; // K -  meaning K if loops

        //for (int i = 1; i <= upperLimit; i++)
        //{
        //    for (int j = 1; j <= upperLimit; j++)
        //    {
        //        for (int m = 1; m <= upperLimit; m++)
        //        {
        //            Console.WriteLine(" {0}, {1}, {2}", i, j, m);
        //        }
        //    }
        //}

        //DISCALIMER:
        //The solution below and commented out belongs to no_response !!!
        //I can fully understand and and implement it, but I would not refactor it or submit it as mine
        //Feel free to check it, I believe it is worth seing


        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < Math.Pow(n, k); i++)
        {
            int conv = i;
            int[] num = new int[k];
            for (int j = 0; j < k; j++)
            {
                num[k - j - 1] = conv % n;
                conv = conv / n;
            }

            Console.Write("{0}{1}", '{', num[0] + 1);
            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", num[j] + 1);
            }
            Console.WriteLine("}");
        }
    }
}

