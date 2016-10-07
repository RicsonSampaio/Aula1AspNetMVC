using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            //double expected = 9.0;
            var account = currentBalance + withdrawal;
            // act
            //account.Withdraw(withdrawal);
            //double actual = account.Balance;
            // assert
            Assert.AreEqual(account, 18.0);
        }
    }
}
