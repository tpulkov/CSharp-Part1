using System;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;

            for (int i = 0; i < a; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum += numbers;
                if (max < numbers)
                {
                    max = numbers;
                }
                if (min >= numbers)
                {
                    min = numbers;
                }
            }
            double avg = sum / a;            
            //output
            Console.WriteLine("min={0:F2}\nmax={1:F2}\nsum={2:F2}\navg={3:F2}", min, max, sum, avg);
        }
    }
}
