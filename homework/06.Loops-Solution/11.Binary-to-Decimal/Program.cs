using System;
using System.Numerics;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main()
        {
            string numInputBinary = Console.ReadLine();
            long numDecimal = 0;
            int a = 1 ;

            for (int i = numInputBinary.Length -1; i >= 0; i--)
            {
                int number = numInputBinary[i] - '0';
                numDecimal += number * a;
                a *= 2;
            }
            Console.WriteLine(numDecimal);
        }
    }
}
