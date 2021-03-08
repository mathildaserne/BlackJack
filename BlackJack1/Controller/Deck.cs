using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    public class Deck
    {
        public static int Ace = 1;
        public static int Jack = 11;
        public static int Queen = 12;
        public static int King = 13;

        public List<Card> cards = new List<Card>();
        public void GenerateDeck(int amount = 1)
        {
            cards.Clear();
            for (var a = 0; a < amount; a++)
            {
                cards.Add(new Card() { Suit = "♠", Value = Ace, Points = 1 }) ;
                cards.Add(new Card() { Suit = "♠", Value = 2, Points = 2 });
                cards.Add(new Card() { Suit = "♠", Value = 3, Points = 3 });
                cards.Add(new Card() { Suit = "♠", Value = 4, Points = 4 });
                cards.Add(new Card() { Suit = "♠", Value = 5, Points = 5 });
                cards.Add(new Card() { Suit = "♠", Value = 6, Points = 6 });
                cards.Add(new Card() { Suit = "♠", Value = 7, Points = 7 });
                cards.Add(new Card() { Suit = "♠", Value = 8, Points = 8 });
                cards.Add(new Card() { Suit = "♠", Value = 9, Points = 9 });
                cards.Add(new Card() { Suit = "♠", Value = 10, Points = 10 });
                cards.Add(new Card() { Suit = "♠", Value = Jack, Points = 10 });
                cards.Add(new Card() { Suit = "♠", Value = Queen, Points = 10 });
                cards.Add(new Card() { Suit = "♠", Value = King, Points = 10 });

                cards.Add(new Card() { Suit = "♦", Value = Ace, Points = 1 });
                cards.Add(new Card() { Suit = "♦", Value = 2, Points = 2 });
                cards.Add(new Card() { Suit = "♦", Value = 3, Points = 3 });
                cards.Add(new Card() { Suit = "♦", Value = 4, Points = 4 });
                cards.Add(new Card() { Suit = "♦", Value = 5, Points = 5 });
                cards.Add(new Card() { Suit = "♦", Value = 6, Points = 6 });
                cards.Add(new Card() { Suit = "♦", Value = 7, Points = 7 });
                cards.Add(new Card() { Suit = "♦", Value = 8, Points = 8 });
                cards.Add(new Card() { Suit = "♦", Value = 9, Points = 9 });
                cards.Add(new Card() { Suit = "♦", Value = 10, Points = 10 });
                cards.Add(new Card() { Suit = "♦", Value = Jack, Points = 10 });
                cards.Add(new Card() { Suit = "♦", Value = Queen, Points = 10 });
                cards.Add(new Card() { Suit = "♦", Value = King, Points = 10 });

                cards.Add(new Card() { Suit = "♣", Value = Ace, Points = 1 });
                cards.Add(new Card() { Suit = "♣", Value = 2, Points = 2 });
                cards.Add(new Card() { Suit = "♣", Value = 3, Points = 3 });
                cards.Add(new Card() { Suit = "♣", Value = 4, Points = 4 });
                cards.Add(new Card() { Suit = "♣", Value = 5, Points = 5 });
                cards.Add(new Card() { Suit = "♣", Value = 6, Points = 6 });
                cards.Add(new Card() { Suit = "♣", Value = 7, Points = 7 });
                cards.Add(new Card() { Suit = "♣", Value = 8, Points = 8 });
                cards.Add(new Card() { Suit = "♣", Value = 9, Points = 9 });
                cards.Add(new Card() { Suit = "♣", Value = 10, Points = 10 });
                cards.Add(new Card() { Suit = "♣", Value = Jack, Points = 10 });
                cards.Add(new Card() { Suit = "♣", Value = Queen, Points = 10 });
                cards.Add(new Card() { Suit = "♣", Value = King, Points = 10 });

                cards.Add(new Card() { Suit = "♥", Value = Ace, Points = 1 });
                cards.Add(new Card() { Suit = "♥", Value = 2, Points = 2 });
                cards.Add(new Card() { Suit = "♥", Value = 3, Points = 3 });
                cards.Add(new Card() { Suit = "♥", Value = 4, Points = 4 });
                cards.Add(new Card() { Suit = "♥", Value = 5, Points = 5 });
                cards.Add(new Card() { Suit = "♥", Value = 6, Points = 6 });
                cards.Add(new Card() { Suit = "♥", Value = 7, Points = 7 });
                cards.Add(new Card() { Suit = "♥", Value = 8, Points = 8 });
                cards.Add(new Card() { Suit = "♥", Value = 9, Points = 9 });
                cards.Add(new Card() { Suit = "♥", Value = 10, Points = 10 });
                cards.Add(new Card() { Suit = "♥", Value = Jack, Points = 10 });
                cards.Add(new Card() { Suit = "♥", Value = Queen, Points = 10 });
                cards.Add(new Card() { Suit = "♥", Value = King, Points = 10 });
            }
            cards = cards.OrderBy(emp => Guid.NewGuid()).ToList(); // Shuffle list
        }
        public static void showcard()
        {
        }
    }
}
