using System;


namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            int br = 1;
            int maxBr = 1;
            int number = 0;

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = 1; i < N; i++)
            {
                if(array[i] == array[i - 1])
                {
                    br++;

                    if (br > maxBr)
                    {
                        number = array[i];
                        maxBr = br;
                    }
                }
                else
                {
                    br = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", number, maxBr);

        }
    }
}
