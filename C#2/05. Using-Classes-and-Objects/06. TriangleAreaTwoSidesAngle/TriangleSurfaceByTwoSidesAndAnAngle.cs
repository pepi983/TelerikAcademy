using System;


namespace _06.TriangleAreaTwoSidesAngle
{
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double radians = Math.PI * angle / 180.0;
            double surface = (a * b * Math.Sin(radians)) / 2;
            
            Console.WriteLine("{0:f2}", surface);

        }
    }
}
