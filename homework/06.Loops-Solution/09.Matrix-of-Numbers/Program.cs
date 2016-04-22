using System;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int side = n * 2 - 1;

            for (int row = 0; row < side; row++)
            {
                for (int col = 0; col < side; col++)
                {
                    
                    Console.Write('X');
                }
            }
            


        }
    }
}
