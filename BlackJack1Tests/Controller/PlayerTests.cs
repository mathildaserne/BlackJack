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
        public void SetBetTest_AtThreeHundred()
        {
            ///<summary>
            /// Test fails when in the radar of bet, success when passed
            ///</summary>
            var testbet = 300;
            var helper = new Player();
            helper.SetBet(testbet);
            var expected = 300;
            Assert.AreEqual(testbet, expected);
        }
        [TestMethod()]
        public void SetBetTest_AtFiveHundred()
        {
            ///<summary>
            /// Test fails when in the radar of bet, success when passed
            ///</summary>
            var testbet = 500;
            var helper = new Player();
            helper.SetBet(testbet);
            var expected = 500;
            Assert.AreEqual(testbet, expected);
        }
    }
}