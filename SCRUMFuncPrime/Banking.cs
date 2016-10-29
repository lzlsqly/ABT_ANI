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

        public SesameCreditAssessmentService Service
        {
            get;
            private set;
        }

        protected Account(SesameCreditAssessmentService service)
        {
            this.Service = service;
        }

        public static Account OpenDebitAccount(SesameCreditAssessmentService service)
        {
            return new Account(service);
        }

        public static Account OpenAccount(SesameCreditAssessmentService service)
        {
            return new Account(service);
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