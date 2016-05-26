using System;
using System.Numerics;

namespace Trailing0inN_
{
    class Trailing0inN
    {
        static void Main()
        {
   


            int N = int.Parse(Console.ReadLine());

            int br = 0;
            int k = 0;

            while(Math.Pow(5, k) < N)
            {

                k++;
                br += N / (int)(Math.Pow(5, k));
            }
            Console.WriteLine(br);
        }
    }
}


// this is slow but true
           //    BigInteger N = BigInteger.Parse(Console.ReadLine());
           //    
           //    BigInteger br = 0;
           //    BigInteger factorialN = 1;
           //    
           //    for (BigInteger i = 1; i <= N; i++)
           //    {
           //        factorialN *= i;
           //    }
           //    
           //    while (factorialN % 10 == 0)
           //    {
           //    
           //        br += 1;
           //        factorialN /= 10;
           //    }
           //    Console.WriteLine(br);
    
