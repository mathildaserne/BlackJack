using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    public class BlackJack
    {
        Dealer DealerOne; // creates dealer
                
        public BlackJack()
        {
            DealerOne = new Dealer(); // creates dealer
            // Sätt default värden
        }

        public void StartGame()
        {
            DealerOne.PrepareDeck(); // Sets deck and player

            DealerOne.DealingOfCards(); // Give player and dealer one card 
            var status = DealerOne.CheckForWinner(); // Check if someone has one
            if (status == Status.Win) { /* player wins */}
            if (status == Status.Bust) { /* player loses */}
            if (status == Status.Nothing) { /* keep playing*/}
            if (status == Status.HouseBust) { /* player wins */}
            if (status == Status.HouseWins) { /* player loses */}
            // etc
        }
    }
}
