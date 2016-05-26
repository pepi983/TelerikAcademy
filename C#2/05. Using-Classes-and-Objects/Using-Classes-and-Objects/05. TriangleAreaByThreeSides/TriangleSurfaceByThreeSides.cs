using System;

namespace _05.TriangleAreaByThreeSides
{
    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double S = (a + b + c) / 2;  // Semiperimeter
            double surface = Math.Sqrt(S * (S - a) * (S - b) * (S - c));

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
