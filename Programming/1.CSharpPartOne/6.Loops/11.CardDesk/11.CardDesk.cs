﻿using System;


class CardDesk
{
    static void Main()
    {
        
        for (int j = 1; j <= 4; j++)
        {
            for (int i = 1; i <= 13; i++)
            {

                switch (i)
                {
                    case 1: Console.Write("Two of "); break;
                    case 2: Console.Write("Three of "); break;
                    case 3: Console.Write("Four of "); break;
                    case 4: Console.Write("Five of "); break;
                    case 5: Console.Write("Six of "); break;
                    case 6: Console.Write("Seven of "); break;
                    case 7: Console.Write("Eight of "); break;
                    case 8: Console.Write("Nine of "); break;
                    case 9: Console.Write("Ten of "); break;
                    case 10: Console.Write("Jack of "); break;
                    case 11: Console.Write("Queen of "); break;
                    case 12: Console.Write("King of "); break;
                    case 13: Console.Write("Ace of "); break;
                }

                switch (j)
                {
                    case 1: Console.WriteLine("\u2660 Spade"); break;
                    case 2: Console.WriteLine("\u2663 Club"); break;
                    case 3: Console.WriteLine("\u2666 Diamonds"); break;
                    case 4: Console.WriteLine("\u2665 Heard"); break;

                }



            }
        }


    }
}

