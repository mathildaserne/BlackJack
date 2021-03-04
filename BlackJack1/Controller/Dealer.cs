using System;
using System.Collections.Generic;
using System.Text;
using BlackJack1.View;

namespace BlackJack1.Controller
{
    class Dealer
    {
        Player player;
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
               
            // give one card to player
            // give one card to dealer
        }

        internal Status CheckForWinner()
        {
            throw new NotImplementedException();
        }
    }
}
