using System;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[,] matrix = new int[number, number];
            int r = 0;
            int c = 0;
            int value = 1;
            while (value <= number * number)
            {
                while (c < matrix.GetLength(0) && matrix[c, r] == 0)
                {
                    matrix[r, c++] = value;
                    value++;
                }

                c--;
                r++;

                while (r < matrix.GetLength(1) && matrix[r, c] == 0)
                {
                    matrix[r++, c] = value;
                    value++;
                }

                r--;
                c--;

                while (c >= 0 && matrix[r, c] == 0)
                {
                    matrix[r, c--] = value;
                    value++;
                }

                c++;
                r--;

                while (r >= 0 && matrix[r, c] == 0)
                {
                    matrix[r--, c] = value;
                    value++;
                }

                c++;
                r++;
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();

            }
        }
    }
}
