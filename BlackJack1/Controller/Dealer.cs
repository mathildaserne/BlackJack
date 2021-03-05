using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;
using System.Linq;

namespace BlackJack1.Controller
{
    public class Dealer
    {
        Dealer dealer;
        Player player;
        public int PlayerPoints { get; set; } = 0; // ?
        public int DealerPoints { get; set; } = 0; // 

        List<Card> cards = new List<Card>(); // dealer's hand

        public void PrepareDeck()
        {
            Deck deck = new Deck(); // new deck
            player  =  new Player(); // new player
            deck.GenerateDeck(); // Gets a new shuffled deck
            player.EnterPlayersName();
        }
        
        public void DealingOfCards()
        {
            Deck deck = new Deck();
            player = new Player();
            dealer = new Dealer();

            //var players = new Player(deck.cards.ElementAt(0));
            
            //Assign player and dealer for each index of card 0, 1, 
            //Reapet dealing of cards until reached a status player 5 dealer 5 
            // Count points of each players card
            Console.WriteLine("halååååååååååå" + deck.cards.ElementAt(0)); 
            deck.cards.RemoveAt(0);
            Console.WriteLine("halååååååååååå" + deck.cards.ElementAt(1));
            deck.cards.RemoveAt(1);

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
