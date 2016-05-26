using System;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            

           BigInteger factorialN2 = 1;
           BigInteger factorialN1 = 1;
           BigInteger factorialN = 1;
           BigInteger result = 0;
           
           
           
           for (int i = 1; i <= N * 2; i++)
           {
               
               factorialN2 = factorialN2 * i; 
           }
           for(int j = 1; j <= N + 1; j++)
            {
                factorialN1 = factorialN1 * j; 
            }
           for(int k = 1; k <= N; k++)
            {
                factorialN = factorialN * k; 
            }
            result = (factorialN2 / (factorialN1 * factorialN));
          
           Console.WriteLine(result);
       }
    }
}
