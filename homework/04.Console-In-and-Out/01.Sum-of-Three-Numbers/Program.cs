//     Write a program that reads 3 real numbers from the console and prints their sum.



using System;


namespace SumOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            // Input
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double result = x + y + z;
            //Output
            Console.WriteLine(result);

        }
    }
}
