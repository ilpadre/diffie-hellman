using System.Numerics;
using NUnit.Framework;
using DiffieHellman.Lib;

namespace DiffieHellmanTests
{
    public class DHTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPrime_GivenThatOneIsNotPrime_ReturnsFalse()
        {
            var IsOnePrime = DHLib.IsPrime(1);
            Assert.AreEqual(false, IsOnePrime);
        }

        [Test]
        public void IsPrime_GivenThatTwoIsPrime_ReturnsTrue()
        {
            var IsTwoPrime = DHLib.IsPrime(2);
            Assert.AreEqual(true, IsTwoPrime);
        }

        [Test]
        public void IsPrime_GivenThatSevenIsPrime_ReturnsTrue()
        {
            var IsTwoPrime = DHLib.IsPrime(7);
            Assert.AreEqual(true, IsTwoPrime);
        }

        [Test]
        public void IsPrime_GivenThat9601IsPrime_ReturnsTrue()
        {
            BigInteger bigNum = 9601;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(true, isBigNumPrime);
        }

        [Test]
        public void IsPrime_GivenThat9602IsNotPrime_ReturnsFalse()
        {
            BigInteger bigNum = 9602;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.IsFalse(isBigNumPrime);
        }

        [Test]
        public void IsPrime_GivenThat5915587277IsPrime_ReturnsTrue()
        {
            BigInteger bigNum = 5915587277;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(true, isBigNumPrime);
        }

        [Test]
        public void IsPrime_GivenThat5915587278IsNotPrime_ReturnsFalse()
        {
            BigInteger bigNum = 5915587278;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(false, isBigNumPrime);
        }

        [Test]
        public void FindLargestPrimeLessThanInput_GivenThatInputIs10_Returns7()
        {
            BigInteger input = 10;
            BigInteger expected = 7;
            var prime = DHLib.FindLargestPrimeLTEInput(input);
            Assert.IsTrue(DHLib.IsPrime(prime));
            Assert.AreEqual(expected, prime);
        }

        [Test]
        public void FindLargestPrimeLessThanInput_GivenThatInputIs1_ReturnsMinus1()
        {
            BigInteger input = 1;
            BigInteger expected = -1;
            var prime = DHLib.FindLargestPrimeLTEInput(1);
            Assert.IsFalse(DHLib.IsPrime(prime));
            Assert.AreEqual(expected, prime);
        }

        [Test]
        public void FindLargestPrimeLessThanInput_GivenThatInputIsNegative_ReturnsMinus1()
        {
            BigInteger input = -7;
            BigInteger expected = -1;
            var prime = DHLib.FindLargestPrimeLTEInput(input);
            Assert.IsFalse(DHLib.IsPrime(prime));
            Assert.AreEqual(expected, prime);
        }

        [Test]
        public void FindLargestPrimeLessThanInput_GivenThatInputIsPrime_ReturnsInput()
        {
            BigInteger input = 5915587277;
            BigInteger expected = 5915587277;
            var prime = DHLib.FindLargestPrimeLTEInput(input);
            Assert.IsTrue(DHLib.IsPrime(prime));
            Assert.AreEqual(expected, prime);
        }

        [Test]
        public void FindLargestPrimeLessThanInput_GivenThatInputIs7432_Returns7417()
        {
            BigInteger input = 7432;
            BigInteger expected = 7417;
            var prime = DHLib.FindLargestPrimeLTEInput(input);
            Assert.IsTrue(DHLib.IsPrime(prime));
            Assert.AreEqual(expected, prime);
        }

        [Test]
        public void FindLargestPrimeLessThanInput_GivenThatInputIs1979339338_Returns1000000801()
        {
            BigInteger input = 1979339338;
            BigInteger expected = 1979339333;
            var prime = DHLib.FindLargestPrimeLTEInput(input);
            Assert.IsTrue(DHLib.IsPrime(prime));
            Assert.AreEqual(expected, prime);
        }

        [Test]
        public void GenerateLargeRandomPrime_Executes_ReturnsLargeRandomPrime()
        {
            BigInteger p = DHLib.GenerateLargeRandomPrime();
            Assert.IsTrue(DHLib.IsPrime(p));
        }
    }
}