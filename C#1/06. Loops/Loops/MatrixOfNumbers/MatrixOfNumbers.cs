using System;


namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int br;

            for(int i = 1; i <= N; i++)
            {
                br = i;
                for(int j = 1; j <= N; j++)
                {
                    Console.Write("{0} ", br);
                    br++;
                }
                Console.WriteLine();
            }
        }
    }
}
