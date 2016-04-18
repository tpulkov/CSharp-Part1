using System;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double determinant = (b * b) - 4 * (a * c);
            double minusDeterminant = (-b - Math.Sqrt(determinant)) / (2 * a);
            double plusDeterminant = (-b + Math.Sqrt(determinant)) / (2 * a);
            if (determinant > 0)
            {
                Console.WriteLine("{0:F2}", minusDeterminant);                
                Console.WriteLine("{0:F2}", plusDeterminant);
            }
            else if (determinant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                Console.WriteLine("{0:F2}", (-b / (2 * a)));
            }
        }    
    }
}
