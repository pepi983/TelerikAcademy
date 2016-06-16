namespace _1_4.Point
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D zeroPoint = new Point3D(0m, 0m, 0m);

        public Point3D(decimal x, decimal y, decimal z) // Only 1 constructor because empty constructor is default for struct
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }

        public static Point3D ZeroPoint
        {
            get
            {
                return zeroPoint;
            }
        }

        // For StreamReader
        public static Point3D Parse(string text)
        {
            var result = text.Split(new[] { " ", ",", "{", "}" }, StringSplitOptions.RemoveEmptyEntries);
            return new Point3D(decimal.Parse(result[0]), decimal.Parse(result[1]), decimal.Parse(result[2]));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
        }
    }
}
