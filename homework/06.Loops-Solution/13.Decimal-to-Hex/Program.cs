using System;
namespace _13.Decimal_to_Hex
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine("{0:X}", number);
        }
    }
}
