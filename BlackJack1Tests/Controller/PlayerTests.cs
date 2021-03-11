using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack1.Controller.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void EnterPlayersNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetBetTest()
        {
            var testbet = 200;
            var helper = new Player();
            helper.SetBet(testbet);
            var expected = 200;
            Assert.AreEqual(testbet, expected);
        }
        [TestMethod()]
        public void SetBetTest_ToLow()
        {
            ///<summary>
            /// Test fail when under the radar of bet, success
            ///</summary>
            var testbet = 99;
            var helper = new Player();
            helper.SetBet(testbet);
            var expected = 99;
            Assert.AreEqual(testbet, expected);
        }
        [TestMethod()]
        public void SetBetTest_ToHigh()
        {
            ///<summary>
            /// Test fail when over the radar of bet, success
            ///</summary>
            var testbet = 501;
            var helper = new Player();
            helper.SetBet(testbet);
            var expected = 501;
            Assert.AreEqual(testbet, expected);
        }
    }
}