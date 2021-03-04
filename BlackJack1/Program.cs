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
            Console.OutputEncoding = System.Text.Encoding.UTF8; // make console use UTF-8

            //Console.WriteLine(" spades (♠), diamonds (♦), clubs (♣) and hearts (♥).");
            //Controller.Player.EnterPlayersName();
            //Controller.Deck.card();
            // Console.WriteLine(Controller.Deck.cards);
            Deck deck = new Deck(); // new deck
            deck.GenerateDeck(); // Gets a new shuffled deck
            foreach (var card in deck.cards)
                Console.WriteLine(card);
            Dealer deal = new Dealer();
            deal.CheckForWinner();
            //Ask marcus about remove part
            Console.WriteLine("halååååååååååå" + deck.cards.ElementAt(0));
            deck.cards.RemoveAt(0);
            Console.WriteLine("halååååååååååå" + deck.cards.ElementAt(1));
            deck.cards.RemoveAt(1);


        }
    }
}
