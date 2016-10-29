using System;
namespace SCRUMFuncPrime
{
        public interface IAssessmentService
        {
            long GetCredit(String socialSecurityNumber);
        }

        public class SesameCreditAssessmentService : IAssessmentService
        {
            public long GetCredit(String socialSecurityNumber)
            {
                int value = (new Random().Next() * 1000);
                System.Threading.Thread.Sleep(value);

                if (new Random().Next() > 0.66)
                {
                    throw new TimeoutException();
                }
                return value;
            }
        }
}
