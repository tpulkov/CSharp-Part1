using System;
namespace _11.Interval
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());
            long value = 0;

            for (long sum = n + 1; sum < m; sum++)
            {

                if (sum % 5 == 0)
                {
                    value++;
                }
            }

            Console.WriteLine(value);
                      
        }
    }
}
