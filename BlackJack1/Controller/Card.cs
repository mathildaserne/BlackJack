using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack1.Controller
{
    public class Card
    {
        public string CardSuit { get; set; }
        public int CardValue { get; set; }
        public static void card()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { CardSuit = "♠", CardValue = 2 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 3 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 4 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 5 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 6 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 7 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 8 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 9 });
            cards.Add(new Card() { CardSuit = "♠", CardValue = 10 });
            cards.Add(new Card() { CardSuit = "♦", CardValue =  2 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 3 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 4 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 5 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 6 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 7 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 8 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 9 });
            cards.Add(new Card() { CardSuit = "♦", CardValue = 10 });
        }
    }
}



