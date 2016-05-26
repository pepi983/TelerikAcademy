using System;


namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool isEqual = true;

            for (int i = 0; i < n; i++)
            {
                if(array1[i] != array2[i])
                {
                    isEqual = false;
                }
            }

            if(isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
