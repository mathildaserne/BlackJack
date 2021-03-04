using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack1.Controller
{
    public class Card
    {
        public string Suit { get; set; }
        public int Value { get; set; }
        public override string ToString()
        {
            return GetName()  + " "  +  Suit;
        }

        public string GetName()
        {
            return Value switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                10 => "Ten",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => "Joker",
            };
        }
    }
}