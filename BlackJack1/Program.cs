using System;
using System.Collections.Generic;
using BlackJack1.Controller;
using BlackJack1.View;
using System.Linq;

namespace BlackJack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // make console use UTF-8

            //Console.WriteLine(" spades (♠), diamonds (♦), clubs (♣) and hearts (♥).");
            //Controller.Player.EnterPlayersName();
            //Controller.Deck.card();
            // Console.WriteLine(Controller.Deck.cards);
            //Deck deck = new Deck(); // new deck
            //deck.GenerateDeck(); // Gets a new shuffled deck
            //foreach (var card in deck.cards)
            //    Console.WriteLine(card);

            //Console.WriteLine("---------------" + deck.cards.ElementAt(0));

            //This removes index 0, and a new number is declared for this index
            //deck.cards.RemoveAt(0);
            BlackJack blackjack = new BlackJack();
            blackjack.StartGame();
            Dealer deal = new Dealer();
            deal.PrepareDeck(); // ni glömde PrepareDeck
            deal.CheckForWinner();
            deal.DealingOfCards();
            //Ask marcus about remove part

            /*Console.WriteLine("----------------------" + deck.cards.ElementAt(0));
            deck.cards.RemoveAt(0);
            Console.WriteLine("----------------------" + deck.cards.ElementAt(1));
            deck.cards.RemoveAt(1);*/

        }
    }
}
