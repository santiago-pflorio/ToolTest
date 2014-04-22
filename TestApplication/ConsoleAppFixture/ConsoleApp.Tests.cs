using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace ConsoleAppFixture
{
    [TestClass]
    public class ConsoleAppTests
    {
        [TestMethod]
        public void Debit_WhenAmountIsGreaterThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, BankAccount. DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }
}
