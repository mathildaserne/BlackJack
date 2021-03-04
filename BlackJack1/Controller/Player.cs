﻿using System;
using System.Collections.Generic;
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
    }

    class Player
    {
        public Status Status { get; set; } = Status.Nothing;
        public string Name { get; set; }  =  "";
        public int Bet { get; set; }  =  0;
        public List<Card> cards { get; set; } = new List<Card>(); // spelarens hand

        public void EnterPlayersName()
        {
            Console.WriteLine("Enter your name: ");
            var Name = Console.ReadLine();
            if (Name!= null)
            {
                Console.WriteLine("Welcome to blackjack");
                //Console.WriteLine("Which table? ");
                var answer = "table1";  //  Console.ReadLine();
                if (answer == "table1")
                {
                    Console.WriteLine("Bet between 100-500 kr");
                    Bet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bet - " + Bet);
                }
                else if (answer == "table2")
                {

                }
            }
        }        
    }
}
