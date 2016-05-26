using System;
using System.Globalization;

    class PointCircle
    {
        static void Main()
        {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double DISTANCE = Math.Sqrt((x * x) + (y * y));
        string z = String.Format(CultureInfo.InvariantCulture, "{0:0.00}", DISTANCE);

        if (DISTANCE <= 2)
        {
            Console.WriteLine("yes {0}", z);
        }
        else
        {
            Console.WriteLine("no {0}", z);

        }
    }
    }

