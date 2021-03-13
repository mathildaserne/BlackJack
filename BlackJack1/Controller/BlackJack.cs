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

            for (int i = 0; i < Dealer.Players.Count; i++)
            {
                Dealer.DealingOfCards(i);

                var status = Dealer.CheckForWinner(Dealer.Players[i]); 
                Dealer.Players[i].Status = status;
                ///<summary
                /// If status.win, player has won, choose to play again or exit
                ///</summary>
                if (status == Status.Win)
                {
                    Console.WriteLine(Dealer.Players[i].Name + " wins !!");
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
                ///<summary
                /// If status.bust, player has busted, choose to play again or exit
                ///</summary>
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
                ///<summary
                /// If status.nothing, no win or bust, choose to play again or exit
                ///</summary>
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
                ///<summary
                /// If status.housebust, house has busted, choose to play again or exit
                ///</summary>
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
                ///<summary
                /// If status.housewin, house has won, choose to play again or exit
                ///</summary>
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
                ///<summary
                /// If status.blackjack, player or house got blackjack, choose to play again or exit
                ///</summary>
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
}
