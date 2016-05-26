using System;


namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            int sequence = 1;
            int maxSequence = 1;

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < N; i++)
            {
                if(array[i] > array[i - 1])
                {
                    sequence++;
                    if(sequence > maxSequence)
                    {
                        maxSequence = sequence;
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
