using System.Runtime.CompilerServices;
using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    public class CreditAccount:Account
    {
        public CreditAccount(SCRUMFuncPrime.SesameCreditAssessmentService service) : base(service)
        {

        }

        public new void Withdraw(long amount)
        {
            if (this.Service.GetCredit("") + this.Balance < amount)
                throw new InsufficientFundsException();
            base.Withdraw(amount);
        }
    }
}