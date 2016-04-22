using System;

namespace _01.Numbers_from_1_to_N
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
