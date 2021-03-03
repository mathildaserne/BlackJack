using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    class Player
    {
        public enum Status
        {
            Win,
            Bust,
            Nothing
        }

        public static void EnterPlayersName()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            if (name!= null)
            {
                Console.WriteLine("Welcome to blackjack");
                Console.WriteLine("Which table? ");
                var answer = Console.ReadLine();
                if (answer == "table1")
                {
                    Console.WriteLine("Bet between 100-500 kr");
                    var bet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bet - " + bet);
                }
                else if (answer == "table2")
                {

                }
            }
        }        
    }
}
