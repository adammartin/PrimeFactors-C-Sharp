using System.Linq;
using Xunit;
using Factors;
using System.Collections.Generic;

namespace PrimeFactorsTest
{
    public class PrimeFactorsTest
    {
        [Fact]
        public void TestOne()
        {
            Assert.Equal(0, PrimeFactors.Primes(1).Count);
        }

        [Fact]
        public void TestTwo()
        {
            Assert.Equal(new List<int>{2}, PrimeFactors.Primes(2));
        }

    }
}
