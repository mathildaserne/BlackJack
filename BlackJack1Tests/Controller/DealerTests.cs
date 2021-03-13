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
            dealer.Players = new List<Player>();
            dealer.Players.Add(new Player { Name = "TestPlayer" });
            dealer.PrepareDeck(true);
            dealer.Players[0].cards.AddRange(new List<Card>()
            {
                new Card() { Suit = "♥", Value = 1, Points = 1 },
                new Card() { Suit = "♥", Value = 10, Points = 10 }
            });
            var actual = dealer.CheckForWinner(dealer.Players[0]);
            var expected = Status.HouseBust;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckForWinnerWhenCardValueBlackJack_Test()
        {
            var dealer = new Dealer();
            dealer.Players = new List<Player>();
            dealer.Players.Add(new Player { Name = "TestPlayer" });
            dealer.PrepareDeck(true);
            dealer.Players[0].cards.AddRange(new List<Card>()
            {
                new Card() { Suit = "♥", Value = 10, Points = 10 },
                new Card() { Suit = "♥", Value = 10, Points = 10 },
                new Card() { Suit = "♥", Value = 1, Points = 1 }
            });
            var actual = dealer.CheckForWinner(dealer.Players[0]);
            var expected = Status.BlackJack;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckForWinnerWhenCardValueBust_Test()
        {
            var dealer = new Dealer();
            dealer.Players = new List<Player>();
            dealer.Players.Add(new Player { Name = "TestPlayer" });
            dealer.PrepareDeck(true);
            dealer.Players[0].cards.AddRange(new List<Card>()
            {
                new Card() { Suit = "♥", Value = 1, Points = 1 }
            });

            var actual = dealer.CheckForWinner(dealer.Players[0]);
            var expected = Status.HouseBust;
            Assert.AreEqual(expected, actual);
        }
    }
}