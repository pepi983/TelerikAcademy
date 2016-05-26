using System;
using System.Globalization;

    class Rectangles
    {
        static void Main(string[] args)
        {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        string a = String.Format(CultureInfo.InvariantCulture, "{0:0.00}", area);
        string b = String.Format(CultureInfo.InvariantCulture, "{0:0.00}", perimeter);
        
        Console.WriteLine("{0} {1}", a, b);
    }
    }
