using System;
using System.Globalization;
using System.Threading;

namespace _04.Print_a_Deck
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string card = Console.ReadLine();
            int symbol = Convert.ToInt32(card);
            for (int i = 2; i <= symbol; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                switch (card)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "A":Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i); break;

                    default:
                        break;
                }                
            }
        }
    }
}
