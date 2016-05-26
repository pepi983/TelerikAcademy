using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            int sum = 0;
            int maxSum = int.MinValue;


            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                sum += array[i];

                if(sum > maxSum)
                {
                    maxSum = sum;
                }

                if (sum < 0)
                {
                    sum = 0;
                }
            }


            Console.WriteLine(maxSum);

        }
    }
}
