using System;
using System.Numerics;


namespace Calculate3_
{
    class Calculate3
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger value = N - K;
            BigInteger factorialValue = 1;
            BigInteger result = 0;

            for(BigInteger i = 1; i <= N; i++)
            {
                if(i <= K)
                {
                    factorialK *= i;
                }
                if(i <= value)
                {
                    factorialValue *= i;
                }
                factorialN *= i;
            }
            result = factorialN / (factorialK * factorialValue);
            Console.WriteLine(result);


        }
    }
}
