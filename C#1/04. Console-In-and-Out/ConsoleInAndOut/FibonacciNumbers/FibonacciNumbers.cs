using System;


namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 1;
            Console.Write("0");
            

            for (int i=1 ; i < N; i++)
            {
                Console.Write(", {0}", a);
                long temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
