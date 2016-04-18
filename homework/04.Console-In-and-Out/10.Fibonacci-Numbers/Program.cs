using System;


namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {            
            long n = long.Parse(Console.ReadLine());
            long first = -1;
            long second = 1;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = first + second;
                if (i != n - 1)
                {
                    Console.Write(sum + ", ");
                }
                else
                {
                    Console.WriteLine(sum);
                }
                first = second;
                second = sum;
            }
        }
    }
}
