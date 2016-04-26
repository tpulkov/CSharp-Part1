using System;

namespace _04.Print_a_Deck
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] colors = { " of spades,", " of clubs,", " of hearts,", " of diamonds" };

            for (int i = 0; i <= Array.IndexOf(cards, input); i++)
            {
                for (int j = 0; j < colors.Length; j++)
                {
                    Console.Write(j != colors.Length - 1 ? cards[i] + colors[j] +
                                                " " : cards[i] + colors[j] + "\n");
                }

            }
        }
    }
}
