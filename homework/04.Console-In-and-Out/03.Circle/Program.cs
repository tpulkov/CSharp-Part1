//You should print one line only: the perimeter and the area of the circle, 
//separated by a whitespace, and with 2 digits precision

using System;

namespace CircleAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double pi = Math.PI;
            double radius = double.Parse(Console.ReadLine());
            double perimeter = (2 * pi * radius);
            double area = (pi * radius * radius);
            //output perimete " " area of circle
            Console.Write("{0:F2} {1:F2}", perimeter, area);

        }
    }
}
