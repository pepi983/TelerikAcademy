using System;


namespace Circle
{
    class AreaAndPerimeter
    {
        static void Main()
        {
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal Pi = (decimal)Math.PI;
            decimal perimeter = 2 * Pi * radius;
            decimal area = Pi * radius * radius;
            
            Console.WriteLine("{0:F2} {1:0.00}", perimeter, area);
        }
    }
}
