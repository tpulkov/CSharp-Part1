using System;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i <= n - k)
                {
                    factorial *= i;
                }
                factorialN *= i;
            }
            //Console.WriteLine(factorialN);
            for (int i = 1; i <= k; i++)
            {
                factorialK *= i;
            }
            //Console.WriteLine(factorialK);
            BigInteger result = factorialN / (factorialK * factorial);
            Console.WriteLine(result);
        }

    }
}
