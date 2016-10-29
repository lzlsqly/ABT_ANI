using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    public class DibitAccount:Account
    {
        public  DibitAccount() : base()
        {

        }

        public new void Withdraw(long amount)
        {
            bool insufficientFunds = this.Balance < amount;
            
            if ( insufficientFunds)
            {
                throw new InsufficientFundsException();
            }
            base.Withdraw(amount);
        }
    }
}