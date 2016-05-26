using System;
using System.Numerics;

namespace _10.NFactorial
{
    class NFactorial
    {
        static BigInteger ArrayFactorial(int[] array)
        {
            BigInteger factorial = 1;

            for (int i = 0; i < array.Length; i++)
            {
                factorial *= array[i];
            }

            return factorial;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine(ArrayFactorial(array));
        }
    }
}
