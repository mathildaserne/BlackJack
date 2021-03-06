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
        //Dealer dealer; //Dealer har en instans av sig själv :-O
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
            int sum = 0;
            //var players = new Player(deck.cards.ElementAt(0));
            //Assign player and dealer for each index of card 0, 1, 
            //Reapet dealing of cards until reached a status player 5 dealer 5 
            // Count points of each players card
            //first set of cards to player and dealer
            var playerCard  = deck.cards.ElementAt(0);
            Console.WriteLine("Players card " + playerCard);
            deck.cards.RemoveAt(0);
            var dealerCard = deck.cards.ElementAt(1);
            Console.WriteLine("Dealers card " + dealerCard);
            deck.cards.RemoveAt(1);
            player.cards.Add(playerCard);
            cards.Add(dealerCard);

            sum = playerCard.Points;
            //player.cards.Add(playerCard.Points);
            Console.WriteLine(sum);
            //Console.WriteLine(playerCard.Points); 

            //second card for player and dealer 
            playerCard = deck.cards.ElementAt(2);
            Console.WriteLine("Players second card " + playerCard);
            deck.cards.RemoveAt(2);
            dealerCard = deck.cards.ElementAt(3);
            Console.WriteLine("Dealers other card " + dealerCard);
            deck.cards.RemoveAt(3);
            player.cards.Add(playerCard);
            cards.Add(dealerCard);


            //sum = playerCard + playerCard;
            Console.WriteLine(playerCard.Points);
            Console.WriteLine(sum + sum);

            //PlayerPoints == Sum{ deck.cards.ElementAt(1) + deck.cards.ElementAt(2)};

            

            // Efter removeAt så kommer kortet som var i position 0 att försvinna
            // och kortet i position 1 kommer att hamna på position 0

            //return card;
            // give one card to player
            // give one card to dealer

        }
        //internal
        public Status CheckForWinner()
        {
            
            /*
            // Collect points of player and dealer cards 

            if (PlayerPoints == 21)
            {
                Console.WriteLine("Congratulations you got " + Status.BlackJack);
            }
            else if (PlayerPoints > 21)
            {
                Console.WriteLine("You just got busted " + Status.Bust);
            }
            else if (PlayerPoints <21 && PlayerPoints > DealerPoints)
            {
                Console.WriteLine("Player has won " + Status.Win);
            }
            else if (DealerPoints == 21)
            {
                Console.WriteLine("Congratulations you got " + Status.BlackJack);
            }
            else if (DealerPoints > 21)
            {
                Console.WriteLine("You just got busted " + Status.HouseBust);
            }
            else if (DealerPoints <21 && DealerPoints > PlayerPoints)
            {
                Console.WriteLine("House has won " + Status.HouseWins);
            }
            return 0;
            // Help
            // else if (PlayerPoints == DealerPoints)*/

            return 0;
           //throw new NotImplementedException();
        }
    }
}
