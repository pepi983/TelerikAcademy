using System;

    class ThirdDigit
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        N = (N / 100) % 10;
        bool P = N == 7;
       
            if (P)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false {0}", N);
            }
        
        }
    }

