using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack1.Controller
{
    class Card
    {
        public enum Suit
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts
        }
        public enum Face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public class Card_
        {
            public Suit Suit { get; }
            public Face Face { get; }
            public int Value { get; set; }
        }


    }
}



