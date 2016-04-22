using System;
using System.Numerics;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialPlus = 1;

            for (int i = numberInput + 1; i <= 2 * numberInput; i++)
            {               
                factorialN *= i;
                factorialPlus *= i - numberInput + 1;
            }
            BigInteger catalan = factorialN / factorialPlus;

            


            Console.WriteLine(catalan);
        }
    }
}
