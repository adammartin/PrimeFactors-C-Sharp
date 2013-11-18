using System.Linq;
using FluentAssertions;
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
            PrimeFactors.Primes(1).Should().Equal(new List<int>());
        }

        [Fact]
        public void TestTwo()
        {
            PrimeFactors.Primes(2).Should().Equal(new List<int> { 2 });
        }
    }
}
