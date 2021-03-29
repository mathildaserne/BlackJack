using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BlackJack1.Controller.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void SetBetTest_RightAmount()
        {
            ///<summary
            /// Test passes when bet is between 100-500, success when passed
            /// </summary>
            var testbet = 200;
            var helper = new Player();
            helper.SetBet(testbet);
            var actual = helper.Bet;
            var expected = 200;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetBetTest_AtThreeHundred()
        {
            ///<summary>
            /// Test passes when in the radar of bet, success when passed
            ///</summary>
            var testbet = 300;
            var helper = new Player();
            helper.SetBet(testbet);
            var actual = helper.Bet;
            var expected = 300;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetBetTest_AtFiveHundred()
        {
            ///<summary>
            /// Test passes when in the radar of bet, success when passed
            ///</summary>
            var testbet = 500;
            var helper = new Player();
            helper.SetBet(testbet);
            var actual = helper.Bet;
            var expected = 500;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetBetTest_ToNegavtiveValue()
        {
            ///<summary>
            /// Test throws exception when bet is negative value, sucess when passed
            ///</summary>
            var testbet = -500;
            var helper = new Player();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                helper.SetBet(testbet)
            );
        }
    }
}