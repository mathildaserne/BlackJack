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
        public Random random;
        //public string deck;
        public Card cardNumber;
        public int count;

        /*public Deck(string cardface, string cardvalue)
        {
            string[] suit = { "hearts", "spades", "clubs", "diamonds" };
            string[] face = {"ace","two","three","four","five","six","seven","eight","nine",
                        "ten","jack","queen","king" };


        }*/

        
        public static void card()
        {
            List<Deck> cards = new List<Deck>();
            cards.Add(new Deck() { CardSuit = "♠", CardValue = Ace });   
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 2 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 3 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 4 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 5 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 6 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 7 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 8 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 9 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = 10 });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = Jack });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = Queen });
            cards.Add(new Deck() { CardSuit = "♠", CardValue = King });
            
            cards.Add(new Deck() { CardSuit = "♦", CardValue = Ace });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 2 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 3 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 4 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 5 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 6 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 7 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 8 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 9 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = 10 });
            cards.Add(new Deck() { CardSuit = "♦", CardValue = Jack });            
            cards.Add(new Deck() { CardSuit = "♦", CardValue = Queen });            
            cards.Add(new Deck() { CardSuit = "♦", CardValue = King });

            
            cards.Add(new Deck() { CardSuit = "♣", CardValue = Ace });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 2 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 3});
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 4 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 5 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 6 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 7 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 8 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 9 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = 10 });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = Jack });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = Queen });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });

            cards.Add(new Deck() { CardSuit = "(♥", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });
            cards.Add(new Deck() { CardSuit = "♣", CardValue = King });

        }

        public static void showcard()
        {
        }
    }
}
