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
            if (n > 1)
            {
                if (n%2 == 0)
                {
                    primes.Add(2);
                    n /= 2;
                }
                if(n > 1)
                    primes.Add(n);
            }
            return primes;
        }
    }
}
