using System;

    class FourDigits
    {
        static void Main()
        {
        int digits = int.Parse(Console.ReadLine());
        int a = (digits / 1000) % 10;
        int b = (digits / 100) % 10;
        int c = (digits / 10) % 10;
        int d = digits % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
    }

