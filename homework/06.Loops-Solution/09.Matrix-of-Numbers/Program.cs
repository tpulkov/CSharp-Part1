using System;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j < i + N; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}

