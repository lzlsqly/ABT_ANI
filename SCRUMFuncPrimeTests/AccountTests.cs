using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    [TestClass()]
    public class AccountTests
    {

        private SesameCreditAssessmentService service ;

        [TestInitialize]
        public void before()
        {
            service = new SesameCreditAssessmentService();
        }

        [TestMethod()]
        public void DepositTest()
        {
            Account account = Account.OpenDebitAccount(service);
            account.Deposit(100);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod()]
        public void WithDrawTest()
        {
            Account account = Account.OpenDebitAccount(service);
            account.Deposit(200);
            account.Withdraw(100);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod()]
        public void WithDraw300Test()
        {
            Account account = Account.OpenDebitAccount(service);
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
            DibitAccount account = new DibitAccount(service);
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
        public void CreditWithdraw300Test()
        {
            CreditAccount account = new CreditAccount(service);
            account.Deposit(200);
            account.Withdraw(300);
            Assert.AreEqual(-100, account.Balance);
        }

        [TestMethod()]
        public void CreditWithdraw2000Test()
        {
            CreditAccount account = new CreditAccount(service);
            account.Deposit(200);
            try
            {
                account.Withdraw(2000);
            }
            catch (InsufficientFundsException)
            {
                Assert.AreEqual(200, account.Balance);
            }
        }
    }

}