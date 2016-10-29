using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    public class DibitAccount:Account
    {
        public  DibitAccount(SesameCreditAssessmentService service) : base(service)
        {

        }

        public new void Withdraw(long amount)
        {
            bool insufficientFunds = this.Balance < amount;
            
            if (insufficientFunds)
            {
                throw new InsufficientFundsException();
            }
            base.Withdraw(amount);
        }
    }
}