using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack1.View;

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
        public string Name { get; set; }  =  "";
        public double Bet { get; set; }  =  0;
        public int PlayerPoints { get; set; } = 0; // ?
        public int DealerPoints { get; set; } = 0; // ?
        public List<Card> cards { get; set; } = new List<Card>(); // spelarens hand

        public void EnterPlayersName()
        {
            Console.WriteLine("Enter your name: ");
            Console.WriteLine("---------------------------");
            Name = Console.ReadLine();

            if (Name.All(char.IsLetter) && Name != null)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Welcome to blackjack " + Name);
                Console.WriteLine(" --------------------------- ");
                Console.WriteLine("You wanna play? yes or no ");
                Console.WriteLine("---------------------------");
                var answer = Console.ReadLine();
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
