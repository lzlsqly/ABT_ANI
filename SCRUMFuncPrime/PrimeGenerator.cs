using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUMFuncPrime
{
    public static class PrimeGenerator
    {
        public static int[] GeneratePrimes(int maxValue)
        {
            if (maxValue < 2)
                return new int[0];
            var isprime = new bool[maxValue];

            SetmaxValueArray(maxValue, isprime);

            SievePrime(maxValue, isprime);

            return Primes(maxValue, isprime); ;
        }

        private static void SievePrime(int maxValue, bool[] isprime)
        {
            for (var i = 2; i < Math.Sqrt(maxValue) + 1; i++)
            {
                for (var j = 2 * i; j < maxValue; j += i)
                {
                    isprime[j] = false;
                }
            }
        }

        private static int[] Primes(int maxValue, bool[] isprime)
        {
            var primeCount = 0;
            for (var i = 0; i < maxValue; i++)
            {
                if (isprime[i])
                    primeCount++; 
            }

            var primes = new int[primeCount];
            
            for (int i = 0, j = 0; i < maxValue; i++)
            {
                if (isprime[i])
                    primes[j++] = i;
            }
            return primes;
        }

        private static void SetmaxValueArray(int maxValue, bool[] isprime)
        {
            for (int i = 0; i < maxValue; i++)
            {
                isprime[i] = true;
            }
            isprime[0] = isprime[1] = false;
        }
    }
}

