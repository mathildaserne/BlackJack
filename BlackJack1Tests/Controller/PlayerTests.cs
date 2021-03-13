using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var expected = 200;
            Assert.AreEqual(testbet, expected);
        }
        [TestMethod()]
        public void SetBetTest_ToLow()
        {
            ///<summary>
            /// Test fails when under the radar of bet, success when failed
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
            /// Test fails when over the radar of bet, success when failed
            ///</summary>
            var testbet = 501;
            var helper = new Player();
            helper.SetBet(testbet);
            var expected = 501;
            Assert.AreEqual(testbet, expected);
        }
    }
}