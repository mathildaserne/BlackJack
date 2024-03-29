﻿using BlackJack1.Controller;
using System;

namespace BlackJack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // make console use UTF-8

            BlackJack blackjack = new BlackJack();
            blackjack.StartGame();
            Dealer deal = new Dealer();
            deal.PrepareDeck(); // ni glömde PrepareDeck
            deal.CheckForWinner();
            deal.DealingOfCards(0);

        }
    }
}
