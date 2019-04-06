using System;
using System.Numerics;

namespace DiffieHellman.Lib
{
    public class DHLib
    {
        public BigInteger GenerateLargestPrimeNumberLessThanInput(BigInteger n)
        {

            return BigInteger.One;
        }


        public static bool IsPrime(BigInteger number)
        {
            if (number == 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }

            for (int i = 3; (BigInteger.Pow(i,2)) <= number; i += 2)
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
