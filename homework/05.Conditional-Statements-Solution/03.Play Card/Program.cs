﻿using System;

namespace _03.Play_Card
{
    class Program
    {
        static void Main()
        {
            string switchCase = Console.ReadLine();

            switch (switchCase)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("yes " + switchCase); break;

                default:
                    Console.WriteLine("no " + switchCase);
                    break;
            }
        }
    }
}
