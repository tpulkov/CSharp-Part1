using System;

namespace _04.Formatting_Numbers
{
    class Program
    {
        static void Main()
        {
            byte a = byte.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

              
            Console.Write("{0:X}", a);  //a == hexadecimal 
            Console.Write(" |{0}| ", Convert.ToString(a, 2).PadLeft(10, '0')); // a == binary  representations
            Console.WriteLine("{0:F2}|{1:F3} |", b, c);

        }
    }
}
