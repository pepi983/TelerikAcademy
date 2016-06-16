namespace _1_4.Point
{
    using System;
    public static class CalculateDistance
    {
        public static double PointsDistance(Point3D firstPoint, Point3D secondPoint)
        {
            decimal x = (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X);
            decimal y = (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y);
            decimal z = (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Y);

            double distance = Math.Sqrt(Convert.ToDouble(x + y + z));

            return distance;
        }
    }
}
