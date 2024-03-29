﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack1.Controller
{
    public class Dealer
    {
        ///<list>
        /// List type Player
        /// </list>
        public List<Player> Players = new List<Player>();
        Deck deck;
        
        ///<list>
        /// List type Card
        /// </list>
        public List<Card> cards = new List<Card>();
        /// <summary>
        /// List for dealer's hand
        /// </summary>

        ///<summary
        /// Prepare the deck and get the decision of how many players 
        ///</summary>
        public void PrepareDeck(bool test = false)
        {
            try
            {
                deck = new Deck();
                /// <summary>
                /// New deck
                /// </summary>
                Console.WriteLine("Write amount of players");
                Console.WriteLine("---------------------------");
                int TotalPlayers = 1;
                if (!test)
                    TotalPlayers = Convert.ToInt32(Console.ReadLine());

                Players = new List<Player>();

                for (int index = 0; index < TotalPlayers; index++)
                {
                    Console.WriteLine("Enter player {0}'s name:", index + 1);
                    Players.Add(new Player()
                    {
                        Name = "Player" + (index + 1)
                    });
                }

                /// <summary>
                /// New player
                /// </summary>
                deck.GenerateDeck();
                /// <summary>
                /// Gets a new shuffled deck
                /// </summary>
                if (test == false)
                {
                    for (int i = 0; i < Players.Count; i++)
                    {
                        //Players[i].EnterPlayersName();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
        /// <summary>
        /// Dealing of cards for dealer, and player(s)
        /// </summary>
        /// <param name="currentPlayer"></param>
        public void DealingOfCards(int currentPlayer)
        {
            try
            {
                int firstcard = 0;
                int secondcard = 0;
                int thirdcard = 0;
                int sumofcards;

                int dfirstcard = 0;
                int dsecondcard = 0;
                int dthirdcard = 0;
                int dsumofcards;

                /// <summary>
                /// Deals first set of cards for player and house
                /// </summary>
                    var playerCard = deck.cards.ElementAt(0);
                    Console.WriteLine(Players[currentPlayer].Name + "'s card " + playerCard);
                    firstcard = playerCard.Points;
                    deck.cards.RemoveAt(0);
                    Players[currentPlayer].cards.Add(playerCard);

                    sumofcards = playerCard.Points;
                    Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);

                    var dealerCard = deck.cards.ElementAt(1);
                    Console.WriteLine("Dealers card " + dealerCard);
                    dfirstcard = dealerCard.Points;
                    deck.cards.RemoveAt(1);
                    cards.Add(dealerCard);
                    dsumofcards = dealerCard.Points;
                    Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);

                    /// <summary>
                    /// Deals second set of cards for player and house
                    /// </summary> 
                    playerCard = deck.cards.ElementAt(2);
                    Console.WriteLine(Players[currentPlayer].Name + "'s second card " + playerCard);
                    secondcard = playerCard.Points;
                    deck.cards.RemoveAt(2);
                    Players[currentPlayer].cards.Add(playerCard);
                    sumofcards = firstcard + secondcard;
                    Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);

                    dealerCard = deck.cards.ElementAt(3);
                    Console.WriteLine("Dealers second card " + dealerCard);
                    dsecondcard = dealerCard.Points;
                    deck.cards.RemoveAt(3);
                    cards.Add(dealerCard);
                    dsumofcards = dfirstcard + dsecondcard;
                    Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);

                    Console.WriteLine(Players[currentPlayer].Name + " - You have two options hit or exit");
                    Console.WriteLine("---------------------------");

                    /// <summary>
                    /// Third set of cards for player and house if wanted
                    /// </summary>
                    string answer = HitOrExit();
                    if (answer.All(char.IsLetter) && answer != null && answer == "hit")
                    {
                        var tip = new Tips();
                        tip.Surrender();
                        Console.WriteLine("---------------------------");
                        playerCard = deck.cards.ElementAt(4);
                        Console.WriteLine(Players[currentPlayer].Name + "'s third card " + playerCard);
                        thirdcard = playerCard.Points;
                        deck.cards.RemoveAt(4);

                        Players[currentPlayer].cards.Add(playerCard);
                        sumofcards = firstcard + secondcard + thirdcard;
                        Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);

                        dealerCard = deck.cards.ElementAt(5);
                        Console.WriteLine("Dealers third card " + dealerCard);
                        dthirdcard = dealerCard.Points;
                        deck.cards.RemoveAt(5);
                        cards.Add(dealerCard);
                        dsumofcards = dfirstcard + dsecondcard + dthirdcard;
                        Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);
                    }
                    else if (answer.All(char.IsLetter) && answer != null && answer == "Exit")
                    {
                        Console.Clear();
                    }
                    else if (answer.All(char.IsDigit))
                    {
                        Console.Clear();
                    }
                
            }
            catch (ArgumentOutOfRangeException)
            { }
        }
        private static string HitOrExit()
        {
            return Console.ReadLine();
        }
        public void CheckForWinner()
        {
            for (int i = 0; i < Players.Count; i++)
            {
                var status = CheckForWinner(Players[i]);
                Players[i].Status = status;
            }
        }
        public Status CheckForWinner(Player player)
        {
            /// <summary>
            /// Checks status for player and dealer, depending on sum points of cards
            /// </summary>
            var points = 0;
            foreach (var card in player.cards)
            {
                points += card.Points;
            }
            var dealerpoints = 0;
            foreach (var card in cards)
            {
                dealerpoints += card.Points;
            }
            if (points == 21 || dealerpoints == 21)
            {
                var status = Status.BlackJack;
                return status;
            }
            else if (points > 21 && dealerpoints < 21)
            {
                var status = Status.Bust;

                status = Status.HouseWins;

                return status;
            }
            else if (dealerpoints > 21 && points < 21)
            {
                var status = Status.HouseBust;

                status = Status.Win;

                return status;
            }
            else if (points < 21 && points > dealerpoints)
            {
                var status = Status.Win;

                status = Status.HouseBust;

                return status;
            }
            else if (dealerpoints < 21 && dealerpoints > points)
            {
                var status = Status.HouseWins;

                status = Status.Bust;

                return status;
            }
            else if (points > 21 && dealerpoints > 21)
            {
                var status = Status.HouseBust;

                status = Status.Bust;

                return status;
            }
            else if (points == dealerpoints)
            {
                var status = Status.Nothing;
                return status;
            }
            return 0;

        }
    }
}
