using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack1.Controller
{
    public enum Status
    {
        Win,
        Bust,
        Nothing,
        HouseWins,
        HouseBust,
        BlackJack
    }
    public class Player
    {
        public Status Status { get; set; } = new Status(); ///<paramname>
                                                           /// "Status"
                                                           ///</paramname>
        public string Name { get; set; } = ""; ///<paramname>
                                               /// "Name"
                                               ///</paramname>
        public int Bet { get; set; } = 0; ///<paramname>
                                          /// "Bet"
                                          ///</paramname>
        public List<Card> cards { get; set; } = new List<Card>();  /// <summary>
                                                                   /// spelarens hand
                                                                   /// </summary>
                                                                   /// <list>
                                                                   /// List type Card
                                                                   /// </list>
        public List<Player> PlayerList { get; set; } ///<list>
        /// List type Player
        ///</list>

        ///<summary>
        /// Welcome to blackjack, deside bet between 100-500, 
        /// </summary>
        public void EnterPlayersName()
        {
            foreach (var player in PlayerList)
            {
                if (Name.All(char.IsLetter) && Name != null)
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Welcome to blackjack " + Name);
                    Console.WriteLine(" --------------------------- ");
                    Console.WriteLine("You wanna play? yes or no ");
                    Console.WriteLine("---------------------------");
                    string answer = WannaPlayYesOrNo();
                    if (answer.All(char.IsLetter) && answer != null && answer == "yes")
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Bet between 100-500 kr");
                        Console.WriteLine("---------------------------");

                        SetBet(Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (answer.All(char.IsLetter) && answer != null && answer == "No")
                    {
                        Console.Clear();
                    }
                    if (answer.All(char.IsDigit))
                    {
                        Console.Clear();
                        EnterPlayersName();
                    }
                }
            }
        }
        private void EnterName()
        {
            Name = Console.ReadLine();
        }
        private static string WannaPlayYesOrNo()
        {
            return Console.ReadLine();
        }
        public void SetBet(int bet)
        {
            Bet = bet;
            if (Bet >= 100 && Bet <= 500)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Your bet - " + Bet);
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.Clear();
                EnterPlayersName();
            }
        }
    }
}
