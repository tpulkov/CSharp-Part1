using System;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            string[] numbers = Console.ReadLine().Split(' ');

            long even = 1;
            long odd = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                if (i % 2 == 0)
                {
                    odd *= number;
                }
                else
                {
                    even *= number;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("yes " + even);
            }
            else
            {
                Console.WriteLine("no {0} {1}", odd, even);
            }

        }
    }
}
