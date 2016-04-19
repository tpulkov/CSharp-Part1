using System;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            else if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
            else if (a == b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }            
        }
    }
}
