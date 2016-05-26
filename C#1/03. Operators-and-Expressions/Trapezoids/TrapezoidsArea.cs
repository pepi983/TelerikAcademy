using System;
using System.Globalization;

    class TrapezoidsArea
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.0000000}", area));
        
    }
    }

