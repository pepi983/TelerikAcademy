using System;
using System.Linq;

namespace _11.AddingPolynomials
{
    class AddingPolynomials
    {

        static int[] SumOfPolinoms(int[] array1, int[] array2, int arraySize)
        {
            int[] polinomsSum = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                polinomsSum[i] = array1[i] + array2[i];
            }

            return polinomsSum;
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] firstPolynomials = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] secondPolynomials = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            int[] array = SumOfPolinoms(firstPolynomials, secondPolynomials, N);

            for (int i = 0; i < N; i++)
            {
                if(i == N - 1)
                {
                    Console.Write("{0}", array[i]);
                }
                else
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }
    }
}
