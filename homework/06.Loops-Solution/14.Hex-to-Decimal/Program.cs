using System;
using System.Numerics;

namespace _14.Hex_to_Decimal
{
    class Program
    {
        static void Main()
        {

            string numHex = Console.ReadLine();
            BigInteger numDecimal = 0;
            long a = 1;

            for (int i = numHex.Length - 1; i >= 0; i--)
            {
                int number;
                switch (numHex[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default:
                        number = numHex[i] - '0'; break;
                        break;
                }
                numDecimal += number * a;
                a *= 16;
            }
            Console.WriteLine(numDecimal);
        }
    }
}
