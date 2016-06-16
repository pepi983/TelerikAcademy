namespace _1_4.Point
{
    class StartUp
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 1, 1);

            Path points = new Path();

            points.AddPoint(Point3D.ZeroPoint);
            points.AddPoint(point);
           
            PathStorage.SavePath(points, "paths");

            System.Console.WriteLine(PathStorage.LoadPath("paths"));
        }
    }
}
