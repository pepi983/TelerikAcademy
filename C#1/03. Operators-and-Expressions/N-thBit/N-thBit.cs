using System;

    class N_ThbBt
    {
        static void Main()
        {
        long N = long.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());
        long mask = N >> P;
        long Nmask = mask & 1;
        Console.WriteLine(Nmask);
    }
    }

