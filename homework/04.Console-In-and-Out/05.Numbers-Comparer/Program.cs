//Write a program that gets two numbers from the console and prints the greater of them.
using System;


namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            //input
            double num01 = double.Parse(Console.ReadLine());
            double num02 = double.Parse(Console.ReadLine());
            //output greaterNumber
            if (num01 < num02)
            {
                Console.WriteLine(num02);
            }
            else if (num02 < num01)
            {
                Console.WriteLine(num01);
            }
            else
            {
                Console.WriteLine(num01);
            }
        }
    }
}
