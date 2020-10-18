using BankAccount.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBalanceGreaterThanAmountToWithdraw()
        {
            double amount = -100;
            Account account = new Account
            {
                Owner_Name = "aditya",
                Balance = 1000
            };
            Assert.AreEqual(900, Account.CalculateBalance(account.Balance, amount));
        }
        [TestMethod]
        public void TestThrowsExceptionAsBalanceInsufficient()
        {
            double amount = -1000;
            double balance = 122;
            Assert.ThrowsException<Exception>(() => Account.CalculateBalance(balance, amount));
        }
    }
}
