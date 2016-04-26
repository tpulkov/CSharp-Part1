using System;
using System.Linq;

namespace _15.GCD
{
    class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine().Split(' ').Select(euclidean => int.Parse(euclidean)).ToArray();
            int a = numbers[0];
            int b = numbers[1];

            int reminder = 1;

            while (b != 0)
            {
                reminder = a % b;
                a = b;
                b = reminder;
            }
            Console.WriteLine(Math.Abs(a));
        }
    }
}

