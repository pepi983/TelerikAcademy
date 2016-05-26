using System;


namespace Calculate_
{
    class Calculate
    {
        static void Main()
        {
            ulong  N = ulong.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double S = 1;
            ulong factorial = 1;
            
            
                for (ulong i = 1; i <= N; i++)

                {
                    factorial *= i;
                    S += factorial / Math.Pow(x, i);
                }

                Console.WriteLine("{0:0.00000}", S);
            
        }
        
    }
}
