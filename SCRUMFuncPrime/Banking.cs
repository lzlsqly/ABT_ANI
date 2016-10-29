using System;

namespace SCRUMFuncPrime
{
    public class Account
    {
        public long Balance
        {
            get;
            private set;
        }

        protected Account()
        {
        }

        public static Account OpenDebitAccount()
        {
            return new Account();
        }

        public static Account OpenAccount()
        {
            return new Account();
        }

        public void Deposit(long amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(long amount)
        {
            this.Balance -= amount;
        }
    }

    public class InsufficientFundsException : Exception
    {
    }
}