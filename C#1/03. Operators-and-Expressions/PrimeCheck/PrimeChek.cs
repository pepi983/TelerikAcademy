using System;

class PrimeChek
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool P = true;
        if (N <= 1 || N > 100)
        {
            Console.WriteLine("false");

        }

        else
        {
            double sqrt = Math.Sqrt(N);
            for (int i = 2; i <= sqrt; i++)
            {
                if (N % i == 0)
                {
                    P = false;
                }
            }
            if (P)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


        }
    }
}

