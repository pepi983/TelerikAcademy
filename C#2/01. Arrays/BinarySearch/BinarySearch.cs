using System;
using BinarySearch;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];


            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int X = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int left = 0;
            int right = N;
            int result = -1;




            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == X)
                {
                    result = middle;
                    break;
                }
                else if (array[middle] > X)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }


            if (result != -1)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("-1");
            }



        }
    }
}
