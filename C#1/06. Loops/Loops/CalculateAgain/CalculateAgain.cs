using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger result = 1;

            for(BigInteger i = 1; i <= N; i++)
            {
                if(i <= K)
                {
                    factorialK *= i;
                }
                factorialN *= i;

            }
            result = factorialN / factorialK;
            Console.WriteLine(result);
        }
    }
}
