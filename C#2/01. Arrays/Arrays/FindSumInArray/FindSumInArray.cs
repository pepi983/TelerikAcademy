using System;
using System.Collections.Generic;

namespace FindSumInArray
{
    class FindSumInArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            List<int> numbers = new List<int>();

            int sum = 0;
            

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {

                    sum += array[j];
                    if (sum == S)
                    {
                        numbers.Add(array[j]);
                        break;
                    }
                    else if (sum < S)
                    {
                        numbers.Add(array[j]);
                    }
                    else
                    {
                        numbers.Clear();
                        sum = array[j];
                        numbers.Add(array[j]);
                    }
                }

                if (sum == S)
                {
                    break;
                }
                sum = 0;
                numbers.Clear();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i == numbers.Count - 1)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write("{0}, ", numbers[i]);
                }
            }

        }
    }
}
