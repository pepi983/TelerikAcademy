using System;


namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()                                       // Sieve of Eratosthenes algorithm
        {
            int N = int.Parse(Console.ReadLine());

            bool[] array = new bool[N + 1];

            for (int i = 2; i <= N; i++)
            {
                array[i] = true;
            }


            for (int i = 0; i <= Math.Sqrt(N); i++)
            {
                if(array[i])
                {
                    for (int j = i * i; j <= N; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            for (int i = N; i >= 0; i--)
            {
                if(array[i])
                {
                    Console.WriteLine(i);
                    
                }
            }

        }
    }
}
