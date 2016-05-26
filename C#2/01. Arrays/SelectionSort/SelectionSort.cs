﻿using System;


namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
