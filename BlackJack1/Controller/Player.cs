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
        BlackJack = 21
    }
    public class Player
    {
        public Status Status { get; set; } = Status.Nothing;
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
                if (answer == "yes")
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Bet between 100-500 kr");
                    Console.WriteLine("---------------------------");
                    Bet = Convert.ToInt32(Console.ReadLine());

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
                /*else if (answer == "")
                {
                    Console.WriteLine("Do you want to exit? ");
                    var answers = Console.ReadLine();
                    if (answers == "y")
                    {
                        Console.Clear();
                    }
                    else if (answers == "n")
                    {
                        EnterPlayersName();
                    }
                }*/
            }
            if (Name.All(char.IsDigit))
            {
                Console.Clear();
                EnterPlayersName();
            }
        }        
    }
}
