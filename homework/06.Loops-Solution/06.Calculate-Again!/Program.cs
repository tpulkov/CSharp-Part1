using System;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            BigInteger factorialA = 1;
            BigInteger factorialB = 1;

            for (int i = 1; i <= a; i++)
            {
                factorialA *= i;
            }
            for (int j = 1; j <= b; j++)
            {
                factorialB *= j;
            }

            Console.WriteLine(factorialA / factorialB);
        }
    }
}
