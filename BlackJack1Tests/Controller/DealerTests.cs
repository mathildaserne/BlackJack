using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BlackJack1.Controller.Tests
{
    [TestClass()]
    public class DealerTests
    {
        [TestMethod()]
        public void CheckForWinnerWhenCardValue11_Test()
        {
            var dealer = new Dealer();
            dealer.PrepareDeck(true);
            dealer.player.cards.AddRange(new List<Card>()
            {
                new Card() { Suit = "♥", Value = 1, Points = 1 },
                new Card() { Suit = "♥", Value = 10, Points = 10 }
            });
            var actual = dealer.CheckForWinner();
            var expected = Status.HouseBust;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckForWinnerWhenCardValueBlackJack_Test()
        {
            var dealer = new Dealer();
            dealer.PrepareDeck(true);
            dealer.player.cards.AddRange(new List<Card>()
            {
                new Card() { Suit = "♥", Value = 10, Points = 10 },
                new Card() { Suit = "♥", Value = 10, Points = 10 },
                new Card() { Suit = "♥", Value = 1, Points = 1 }
            });
            var actual = dealer.CheckForWinner();
            var expected = Status.BlackJack;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckForWinnerWhenCardValueBust_Test()
        {
            var dealer = new Dealer();
            dealer.PrepareDeck(true);
            dealer.player.cards.AddRange(new List<Card>()
            {
                new Card() { Suit = "♥", Value = 1, Points = 1 }
            });

            var actual = dealer.CheckForWinner();
            var expected = Status.HouseBust;
            Assert.AreEqual(expected, actual);
        }
    }
}