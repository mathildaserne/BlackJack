using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack1.Controller.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void DeckTest_ShuffleCards()
        {
            var deck = new Deck();
            deck.GenerateDeck(1);
            var actual = deck.cards.Count();

            var cardOne = new Card() { Suit = ":spades:", Value = 1, Points = 1 };
            var cardTwo = new Card() { Suit = ":spades:", Value = 2, Points = 2 };
            var cardThree = new Card() { Suit = ":spades:", Value = 3, Points = 3 };

            Assert.AreNotEqual(cardOne.ToString(), deck.cards[0].ToString());
            Assert.AreNotEqual(cardTwo.ToString(), deck.cards[1].ToString());
            Assert.AreNotEqual(cardThree.ToString(), deck.cards[2].ToString());

        }
        [TestMethod()]
        public void DeckTest_AmountOfCards()
        {
            var deck = new Deck();
            deck.GenerateDeck(1);
            var actual = deck.cards.Count();
            var expected = 52;
            Assert.AreEqual(expected, actual);
        }
    }
}