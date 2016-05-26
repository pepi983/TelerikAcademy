using System;

    class BitSwap
    {
        static void Main()
        {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        uint mask;
        int a;

        // promenlivi za vtoriq change       
        int q1 = q;
        uint n1 = n;

        // smenqme q-tiq bit s p-tiq
        q = q - 1;
        int br = p + k - 1;

        for(int i = p; i <= br; i++)
        {
            q = q + 1;
            mask = n >> i;
            mask = mask & 1;
            a = 1 << q;
            if (mask == 1)
            {
                n = n | (uint)a;
            }
            else
            {
                n = n & (uint)(~a);
            }

        }

        // smenqme p-tiq bit s q-tiq
        p = p - 1;
        int br1 = q1 + k - 1;

        for(int i = q1; i <= br1; i++)
        {
            p = p + 1;
            mask = n1 >> i;
            mask = mask & 1;
            a = 1 << p;
            if (mask == 1)
            {
                n = n | (uint)a;
            }
            else
            {  
                n = n & (uint)(~a);
            }

        }


        Console.WriteLine(n);


    }
}



