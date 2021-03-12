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
        public Status Status { get; set; } = new Status(); //= Status.Nothing;
        public string Name { get; set; } = "";
        public int Bet { get; set; } = 0;
        //public int PlayerPoints { get; set; } = 0; // ?
        //public int DealerPoints { get; set; } = 0; // ?
        public List<Card> cards { get; set; } = new List<Card>(); // spelarens hand
        public List<Player> PlayerList { get; set; }

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
