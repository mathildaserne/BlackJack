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
        public void GenerateDeckTest()
        {
            var deck = new Deck();
            List<Deck> d = new List<Deck>();
            deck.cards = deck.cards.OrderBy(emp => Guid.NewGuid()).ToList();
            var actual = deck.cards;
            var expected = deck.cards;
            Assert.AreEqual(expected, actual);
        }
    }
}