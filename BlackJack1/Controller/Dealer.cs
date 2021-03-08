using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;
using System.Linq;
using System.IO;

namespace BlackJack1.Controller
{
    public class Dealer
    {
        Player player;
        Deck deck;
        public int PlayerPoints { get; set; } = 0; // ?
        public int DealerPoints { get; set; } = 0; // 

        List<Card> cards = new List<Card>(); // list for dealer's hand

        public void PrepareDeck()
        {
            deck = new Deck(); // new deck
            player =  new Player(); // new player
            deck.GenerateDeck(); // Gets a new shuffled deck
            player.EnterPlayersName();
        }
        public void DealingOfCards()
        {
            int firstcard = 0;
            int secondcard = 0;
            int thirdcard = 0;
            int sumofcards;

            int dfirstcard = 0;
            int dsecondcard = 0;
            int dthirdcard = 0;
            int dsumofcards;
            
            // reach status for every deal of cards

            //first set of cards for player and dealer
            var playerCard  = deck.cards.ElementAt(0);
            Console.WriteLine("Player card " + playerCard);
            firstcard = playerCard.Points;
            deck.cards.RemoveAt(0);
            player.cards.Add(playerCard);
            sumofcards = playerCard.Points;
            Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);

            var dealerCard = deck.cards.ElementAt(1);
            Console.WriteLine("Dealers card " + dealerCard);
            dfirstcard = dealerCard.Points;
            deck.cards.RemoveAt(1);
            cards.Add(dealerCard);
            dsumofcards = dealerCard.Points;
            Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);

            //second card for player and dealer 
            playerCard = deck.cards.ElementAt(2);
            Console.WriteLine("Players second card " + playerCard);
            secondcard = playerCard.Points;
            deck.cards.RemoveAt(2);
            player.cards.Add(playerCard);
            sumofcards = firstcard + secondcard;
            Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);

            dealerCard = deck.cards.ElementAt(3);
            Console.WriteLine("Dealers second card " + dealerCard);
            dsecondcard = dealerCard.Points;
            deck.cards.RemoveAt(3);
            cards.Add(dealerCard);
            dsumofcards = dfirstcard + dsecondcard;
            Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);

            /*sumofcards = firstcard + secondcard;
            Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);
            dsumofcards = dfirstcard + dsecondcard;
            Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);*/

            Console.WriteLine("You have two options hit or exit");
            Console.WriteLine("---------------------------");

            var answer = Console.ReadLine();
            if (answer == "hit")
            {
                Console.WriteLine("---------------------------");
                playerCard = deck.cards.ElementAt(4);
                Console.WriteLine("Player third card " + playerCard);
                thirdcard = playerCard.Points;
                deck.cards.RemoveAt(4);
                player.cards.Add(playerCard);
                sumofcards = firstcard + secondcard + thirdcard;
                Console.WriteLine(" --------------------------- SCOREBOARD PLAYER " + sumofcards);

                Console.WriteLine("---------------------------");
                dealerCard = deck.cards.ElementAt(5);
                Console.WriteLine("Dealers third card " + dealerCard);
                dthirdcard = dealerCard.Points;
                deck.cards.RemoveAt(5);
                cards.Add(dealerCard);
                dsumofcards = dfirstcard + dsecondcard + dthirdcard;
                Console.WriteLine(" --------------------------- SCOREBOARD DEALER " + dsumofcards);

            }

            // Efter removeAt så kommer kortet som var i position 0 att försvinna
            // och kortet i position 1 kommer att hamna på position 0

            //return card;
            // give one card to player
            // give one card to dealer
        }
        //internal
        public Status CheckForWinner()
        {
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
            else if (points >21)
            {
                var status = Status.Bust;
                return status;
            }
            else if (dealerpoints >21)
            {
                var status = Status.HouseBust;
                return status;
            }
            else if (points <21 && points > dealerpoints)
            {
                var status = Status.Win;
                return status;
            }
            else if (dealerpoints <21 && dealerpoints > points)
            {
                var status = Status.HouseWins;
                return status;
            }
            else if (points >21 && dealerpoints >21)
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
