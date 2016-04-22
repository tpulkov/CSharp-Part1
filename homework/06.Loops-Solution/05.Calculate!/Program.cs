using System;

namespace _05.Calculate_
{
    class Program
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double factorial = 1;
            for (int i = 1 ; i <= n; i++)
            {                
                factorial *= i;
                double number = Math.Pow(x, i);

                sum += factorial / number;
                
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
