using System;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a < b & a < c)
            {
                if (b < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else if (b < a & b < c)
            {
                if (a < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            else if (c < a & c < b)
            {
                if (a < b)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                if (c < b)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
