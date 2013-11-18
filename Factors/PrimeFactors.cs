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
            for (var candidate = 2; n > 1; candidate++)
                for (;n%candidate == 0; n /= candidate)
                    primes.Add(candidate);
            return primes;
        }
    }
}
