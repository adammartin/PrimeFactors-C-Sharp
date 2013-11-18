using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    public class PrimeFactors
    {
        public static List<int> Primes(int n)
        {
            var primes = new List<int>();
            int candidate = 2;
            while (n > 1)
            {
                while (n%candidate == 0)
                {
                    primes.Add(candidate);
                    n /= candidate;
                }
                candidate++;
            }
            if (n > 1)
                primes.Add(n);

            return primes;
        }
    }
}
