
using System.Collections;

namespace SCRUMFuncPrime
{
   public static class ScrumPrime
    {
        public static ArrayList PrimeBreak(int n)
        {

            ArrayList result = new ArrayList();
            if (n < 2)
                return result;
            for (int i = 2; i < n; i++)
            {
                while (n % i == 0 && n >i)
                {
                    result.Add(i);
                    n = n / i;
                }
            }
            result.Add(n);

            return result;

        }

    }
}
