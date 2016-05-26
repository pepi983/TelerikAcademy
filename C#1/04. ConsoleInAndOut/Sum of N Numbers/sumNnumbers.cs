using System;

namespace Sum_of_N_Numbers
{
    class sumNNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;

            for(int i=1; i <= N; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum = sum + num;
            }

            Console.WriteLine(sum);

        }
    }
}
