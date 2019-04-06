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
        public void TestThatOneIsNotPrime()
        {
            var IsOnePrime = DHLib.IsPrime(1);
            Assert.AreEqual(false, IsOnePrime);
        }

        [Test]
        public void TestThatTwoIsPrime()
        {
            var IsTwoPrime = DHLib.IsPrime(2);
            Assert.AreEqual(true, IsTwoPrime);
        }

        [Test]
        public void TestThatLargerNumberIsPrime()
        {
            BigInteger bigNum = 9601;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(true, isBigNumPrime);
        }

        [Test]
        public void TestThatLargerNumberIsNotPrime()
        {
            BigInteger bigNum = 9602;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(true, isBigNumPrime);
        }

        [Test]
        public void TestThatMuchLargerNumberIsPrime()
        {
            BigInteger bigNum = 5915587277;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(true, isBigNumPrime);
        }

        [Test]
        public void TestThatMuchLargerNumberIsNotPrime()
        {
            BigInteger bigNum = 5915587278;
            var isBigNumPrime = DHLib.IsPrime(bigNum);
            Assert.AreEqual(false, isBigNumPrime);
        }
    }
}