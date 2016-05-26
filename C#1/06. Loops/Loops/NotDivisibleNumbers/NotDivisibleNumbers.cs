using System;


namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if( (i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
