using System;
using System.Globalization;

    class MoonGravity
    {
        static void Main()
        {
        double W = double.Parse(Console.ReadLine());
        double a = W * 0.17;
        Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.000}",a));
        }
    }

