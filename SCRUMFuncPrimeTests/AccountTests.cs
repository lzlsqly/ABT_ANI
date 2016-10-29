using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            Account account = Account.OpenDebitAccount();
            account.Deposit(100);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod()]
        public void WithDrawTest()
        {
            Account account = Account.OpenDebitAccount();
            account.Deposit(200);
            account.Withdraw(100);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod()]
        public void WithDraw300Test()
        {
            Account account = Account.OpenDebitAccount();
            account.Deposit(200);
            try
            {
                account.Withdraw(300);
            }
            catch (InsufficientFundsException)
            {
                Assert.AreEqual(200, account.Balance);
            }
        }

        [TestMethod()]
        public void DibitAmmountTest()
        {
            DibitAccount account = new DibitAccount();
            account.Deposit(200);
            try
            {
                account.Withdraw(300);
            }
            catch (InsufficientFundsException)
            {
                Assert.AreEqual(200, account.Balance);
            }
        }

        [TestMethod()]
        public void CreditAmmountTest()
        {
            CreditAccount account =new CreditAccount();
            account.Deposit(200);
            account.Withdraw(300);
            Assert.AreEqual(-100, account.Balance);
        }

    }
}