﻿using System;

namespace _07.Sort_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b & a < c)
            {
                if (b < c)
                {
                    Console.WriteLine("{0} {1} {2}", c , b ,a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else if (b < a & b < c)
            {
                if (a < c)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if (c < a & c < b)
            {
                if (a < b)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
            }
            else
            {
                if (c < b)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}
