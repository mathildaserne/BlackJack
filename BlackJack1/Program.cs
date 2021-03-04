using System;
using System.Collections.Generic;
using BlackJack1.Controller;
using BlackJack1.View;

namespace BlackJack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" spades (♠), diamonds (♦), clubs (♣) and hearts (♥).");
            Controller.Player.EnterPlayersName();
            //Controller.Deck.card();
           // Console.WriteLine(Controller.Deck.cards);
        }
    }
}
