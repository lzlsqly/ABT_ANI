using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUMFuncPrime
{
   public static class SCRUMPrime
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
