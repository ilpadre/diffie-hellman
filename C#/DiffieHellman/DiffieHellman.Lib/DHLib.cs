using System;
using System.Numerics;
using System.Security.Cryptography;

namespace DiffieHellman.Lib
{
    public class DHLib
    {
        private static readonly BigInteger ONE = 1;
        private static readonly BigInteger TWO = 2;
        private static readonly BigInteger MINUS_ONE = -1;
        private static readonly int PRIME_LENGTH = 1000000;

        public static BigInteger GenerateLargeRandomPrime()
        {
            BigInteger p = RandomInteger(); 
            while (IsPrime(p) == false) 
            {
                Console.WriteLine();
                p = RandomInteger();

            }

            return p;
        }

        public static BigInteger RandomInteger() 
        {
            var rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[PRIME_LENGTH / 8];
            rng.GetBytes(bytes);

            BigInteger p = new BigInteger(bytes);

            return p;
        }

        public static BigInteger FindLargestPrimeLTEInput(BigInteger n)
        {
            if (n < 2)
            {
                return -1;
            }

            if (IsPrime(n))
            {
                return n;
            }

            if (n % 2 == 0)
            {
                n--;
            }

            for (BigInteger i = n; i > 0; i--)
            {
                if (IsPrime(i))
                {
                    return i;
                }
            }

            return 2;
        }

    
        public static bool IsPrime(BigInteger number)
        {
            if (number <= ONE)
            {
                return false;
            }

            for (BigInteger i = 2; (BigInteger.Pow(i,2)) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
