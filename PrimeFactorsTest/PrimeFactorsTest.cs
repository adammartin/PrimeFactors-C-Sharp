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
            PrimeFactors.Primes(2).Should().Equal(new List<int> {2});
        }

        [Fact]
        public void TestThree()
        {
            PrimeFactors.Primes(3).Should().Equal(new List<int> {3});
        }

        [Fact]
        public void TestFour()
        {
            PrimeFactors.Primes(4).Should().Equal(new List<int> {2, 2});
        }

        [Fact]
        public void TestSix()
        {
            PrimeFactors.Primes(6).Should().Equal(new List<int> {2, 3});
        }

        [Fact]
        public void TestEight()
        {
            PrimeFactors.Primes(8).Should().Equal(new List<int> {2, 2, 2});
        }

        [Fact]
        public void TestNine()
        {
            PrimeFactors.Primes(9).Should().Equal(new List<int> {3, 3});
        }
    }
}
