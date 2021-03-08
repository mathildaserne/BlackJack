using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    public class BlackJack
    {
        Dealer Dealer; // creates dealer
        Player Player; // creates player      
        public BlackJack()
        {
            Dealer = new Dealer(); // creates dealer
            // Sätt default värden
        }
        public void StartGame()
        {
            Player = new Player();
            Dealer.PrepareDeck(); // Sets deck and player
            Dealer.DealingOfCards(); // Give player and dealer one card 

            var status = Dealer.CheckForWinner(); // Check if someone has one

            // if requested 1-2 cards more

            if (status == Status.Win)
            {
                Console.WriteLine("Player wins !!");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Play again or exit?");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
                if (answer.All(char.IsLetter) && answer != null && answer == "Play again")
                {
                    StartGame();
                }
                else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                {
                    Console.Clear();
                }
                // Player wins bet of house

                // player wins 
            }
            if (status == Status.Bust)
            {
                Console.WriteLine("Player has busted.. House wins ");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Play again or exit?");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
                if (answer.All(char.IsLetter) && answer != null && answer == "Play again")
                {
                    StartGame();
                }
                else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                {
                    Console.Clear();
                }
                //Player loses bet to house

                // player loses 
            }
            if (status == Status.Nothing)
            {
                Console.WriteLine("There is no win..");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Play again or exit?");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
                if (answer.All(char.IsLetter) && answer != null && answer == "Play again")
                {
                    StartGame();
                }
                else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                {
                    Console.Clear();
                }
                // keep playing
            }
            if (status == Status.HouseBust)
            {
                Console.WriteLine("House has busted.. Player wins ");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Play again or exit?");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
                if (answer.All(char.IsLetter) && answer != null && answer == "Play again")
                {
                    StartGame();
                }
                else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                {
                    Console.Clear();
                }
                //Player wins bet
                // player wins 
            }
            if (status == Status.HouseWins)
            {
                Console.WriteLine("House wins !!");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Play again or exit?");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
                if (answer.All(char.IsLetter) && answer != null && answer == "Play again")
                {
                    StartGame();
                }
                else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                {
                    Console.Clear();
                }
                // Player loses bet
                // player loses 
            }
            if (status == Status.BlackJack)
            {
                Console.WriteLine("Blackjack !!");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Play again or exit?");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
                if (answer.All(char.IsLetter) && answer != null && answer == "Play again")
                {
                    StartGame();
                }
                else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                {
                    Console.Clear();
                }
            }
            // etc

        }
    }
}
