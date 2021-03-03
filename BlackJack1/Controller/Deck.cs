using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    public class Deck
    {
        public string CardSuit { get; set; }
        public int CardValue { get; set; }
        public static void card()
        {
            List<Deck> cards = new List<Deck>();
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 2 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 3 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 4 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 5 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 6 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 7 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 8 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 9 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 10 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 2 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 3 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 4 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 5 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 6 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 7 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 8 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 9 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 10 });
        }

        public static void showcard()
        {
        }

    }
}
