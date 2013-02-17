using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] isNotPrime = new bool[10000001];

        for (int i = 2; i * i <= isNotPrime.Length; i++)
        {
            if (!isNotPrime[i])
            {
                for (int j = i * i; j < isNotPrime.Length; j += i)
                {
                    isNotPrime[j] = true;
                }
            }
        }

        for (int i = 2; i < isNotPrime.Length; i++)
        {
            if (!isNotPrime[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
