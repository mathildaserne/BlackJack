namespace BlackJack1.Controller
{
    public class Card
    {
        public string Suit { get; set; } /// <paramname>
        /// "Suit"
        /// </paramname>
        public int Value { get; set; } ///<paramname>
        /// "Value"
        ///</paramname>
        public int Points { get; set; }///<paramname>
                                       /// "Points"
                                       ///</paramname>
        public override string ToString()
        {
            return GetName() + " " + Suit;
        }
        /// <summary>
        /// Giving each card the name by letter instead of numbers 
        /// </summary>
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