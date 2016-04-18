using System;

namespace _09.Sum_of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            float sum = 0;

            for (int i = 1; i <= number; i++)
            {
               sum += float.Parse(Console.ReadLine());                               
            }
            Console.WriteLine(sum);
        }
    }
}
