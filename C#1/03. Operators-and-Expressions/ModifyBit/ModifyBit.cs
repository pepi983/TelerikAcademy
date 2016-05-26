using System;

    class ModifyBit
    {
        static void Main()
        {
        ulong N = ulong.Parse(Console.ReadLine());
        int P =int.Parse(Console.ReadLine());
        int v = ushort.Parse(Console.ReadLine());

        ulong mask = (ulong)1 << P;
        
        

        if(v == 1)
        {
            ulong a = N | mask;
            Console.WriteLine(a);

        }
        else
        {
            ulong b = ~(mask) & N;
            Console.WriteLine(b);

        }
        }
    }

