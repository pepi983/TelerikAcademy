using System;

class BitExchange
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());

        uint mask;
        uint setBit;
        uint N1 = N;


        for (int i = 3; i <= 5; i++)
        {
            mask = N >> i;
            mask = mask & 1;
            setBit = (uint)1 << (i + 21);

            if (mask == 1)
            {
                N = N | setBit;
            }
            else
            {
                N = N & (~setBit);
            }

        }

        for (int i = 24; i <= 26; i++)
        {
            mask = N1 >> i;
            mask = mask & 1;
            setBit = (uint)1 << (i - 21);

            if (mask == 1)
            {
                N = N | setBit;
            }
            else
            {
                N = N & (~setBit);
            }

        }

        Console.WriteLine(N);

    }
}
