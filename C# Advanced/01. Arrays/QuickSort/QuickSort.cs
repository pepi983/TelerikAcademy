using System;


namespace QuickSort
{
    class QuickSort
    {
        private static int[] Quick(int[] a, int left, int right)
        {
            int i = left;
            int j = right;
            int pivotValue = ((left + right) / 2);
            int x = a[pivotValue];
            int w = 0;
            while (i <= j)
            {
                while (a[i] < x)
                {
                    i++;
                }
                while (x < a[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    w = a[i];
                    a[i++] = a[j];
                    a[j--] = w;
                }
            }
            if (left < j)
            {
                Quick(a, left, j);
            }
            if (i < right)
            {
                Quick(a, i, right);
            }
            return a;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int left = 0;
            int right = N - 1;

            array = Quick(array, left, right);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
