using System;

namespace _02.Not_Divisible_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (i % 7 != 0)
                {
                    if (i % 3 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
