using System;
using System.Numerics;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            int A;
            BigInteger odd = 1;
            BigInteger even = 1;

            if (N == 1)
            {
                Console.WriteLine("no 1 0");
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    if (i % 2 == 0)
                    {
                        A = Math.Abs(int.Parse(input[i]));
                        odd *= A;
                    }
                    else
                    {
                        A = Math.Abs(int.Parse(input[i]));
                        even *= A;
                    }
                }

                if (odd == even)
                {
                    Console.WriteLine("yes {0}", odd);
                }
                else
                {
                    Console.WriteLine("no {0} {1}", odd, even);
                }
            }

        }

    }
}
