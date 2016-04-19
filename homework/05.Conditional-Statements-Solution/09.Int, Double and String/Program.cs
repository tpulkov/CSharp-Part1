using System;

namespace _09.Int__Double_and_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string number = Console.ReadLine();

            switch (text)
            {
                case "integer": Console.WriteLine(int.Parse(number) + 1); break;
                case "real": Console.WriteLine("{0:F2}",  double.Parse(number) + 1); break;
                case "text": Console.WriteLine("{0}*", number); break;
                default:
                    break;
            }            
        }
    }
}
