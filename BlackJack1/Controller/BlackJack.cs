using System;
using System.Linq;

namespace BlackJack1.Controller
{
    public class BlackJack
    {
        Dealer Dealer;
        /// <summary>
        /// creates dealer
        /// </summary>
        Player Player;
        /// <summary>
        /// creates player
        /// </summary>
        public BlackJack()
        {
            Dealer = new Dealer();
            /// <summary
            /// creates dealer
            /// </summary>

            // Sätt default värden
        }
        public void StartGame()
        {
            Player = new Player();
            Dealer.PrepareDeck();
            /// <summary
            /// Sets deck and player
            /// </summary>

            Dealer.DealingOfCards();
            /// <summary>
            /// Give player and dealer one card 
            /// </summary>

            var status = Dealer.CheckForWinner();
            /// <summary>
            /// Check if someone has one
            /// </summary>

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
        }
    }
}
