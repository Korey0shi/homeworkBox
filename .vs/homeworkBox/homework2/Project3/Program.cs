using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean[] isPrime = new bool [101];
            Console.WriteLine("100以内的质数有：");
            for (int i=2; i <= 100; i++)
            {
                isPrime[i] = true;
            }
            for (int j=2; j <= Math.Sqrt(100); j++)
            {
                if (isPrime[j] == true)
                {
                    for(int k = j * j; k <= 100; k += j)
                    {
                        isPrime[k] = false;
                    }
                }
            }
            for(int i = 2; i <= 100; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
