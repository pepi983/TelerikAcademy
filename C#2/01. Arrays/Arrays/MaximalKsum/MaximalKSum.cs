using System;

namespace MaximalKsum
{
    class MaximalKSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];



            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxNumber = array[0];
            int sum = 0;
            int checkMax = 0;


            for (int i = 0; i < K; i++)
            {

                for (int j = 1; j < N; j++)
                {
                    if (checkMax == array[j])
                    {
                        array[j] = Int32.MinValue;
                        checkMax = Int32.MinValue;
                    }

                    if (array[j] > maxNumber)
                    {
                        maxNumber = array[j];
                    }
                }

                sum += maxNumber;
                checkMax = maxNumber;

                if (checkMax == array[0])
                {
                    array[0] = Int32.MinValue;
                    checkMax = Int32.MinValue;
                }

                maxNumber = array[0];


            }
            Console.WriteLine(sum);

        }
    }
}

//int length = int.Parse(Console.ReadLine());
//int maxSumLength = int.Parse(Console.ReadLine());

//int[] arr = new int[length];
//int maxSum = 0;

//        for (int i = 0; i<length; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        Array.Sort(arr);
//        Array.Reverse(arr);

//        for (int i = 0; i<maxSumLength; i++)
//        {
//            maxSum += arr[i];
//        }

//        Console.WriteLine(maxSum);
