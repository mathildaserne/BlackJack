using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    public class BlackJack
    {
        Dealer Dealer; // creates dealer
                
        public BlackJack()
        {
            Dealer = new Dealer(); // creates dealer
            // Sätt default värden
        }
        public void StartGame(string dealer, string player)
        {
            Dealer.PrepareDeck(); // Sets deck and player

            Dealer.DealingOfCards(); // Give player and dealer one card 
            var status = Dealer.CheckForWinner(); // Check if someone has one
            // Deal 1-2 more cards +? 1-2 cards more (if requested)
            if (status == Status.Win) 
            {
                Console.WriteLine("Player has won ");
                // Player wins bet of house

                /* player wins */
            }
            if (status == Status.Bust) 
            {
                Console.WriteLine("Player has lost ");
                //Player loses bet to house

                /* player loses */
            }
            if (status == Status.Nothing) 
            { 

                /* keep playing*/
            }
            if (status == Status.HouseBust) 
            {
                Console.WriteLine("Player has won ");
                //Player wins bet
                /* player wins */
            }
            if (status == Status.HouseWins) 
            {
                Console.WriteLine("Player has lost ");
                // Player loses bet
                /* player loses */
            }
            // etc
        }
    }
}
