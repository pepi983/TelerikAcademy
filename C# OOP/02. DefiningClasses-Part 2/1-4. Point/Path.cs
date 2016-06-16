namespace _1_4.Point
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Path
    {
        public Path()
        {
            this.PointList = new List<Point3D>();
        }

        public List<Point3D> PointList { get; set; }

        public void AddPoint(Point3D point)
        {
            this.PointList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.PointList.Remove(point);
        }

        public override string ToString()
        {
            var toString = new StringBuilder();

            foreach (var point in this.PointList)
            {
                toString.AppendFormat("{0}{1}", point, Environment.NewLine);
            }

            return toString.ToString();
        }
    }
}
