using System;

    class Bit
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        int mask = number >> 3;
        int a = mask & 1;
        Console.WriteLine(a);
        }
    }

// int number = int.Parse(Console.ReadLine());
// int mask = 1 << 3;
// int Nmask = mask & number;
// int a = Nmask >> 3;
// Console.WriteLine(a);