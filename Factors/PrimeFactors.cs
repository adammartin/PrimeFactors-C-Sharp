using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    public class PrimeFactors
    {
        public static List<int> Primes(int p)
        {
            var primes = new List<int>();
            if(p > 1)
                primes.Add(p);
            return primes;
        }
    }
}
