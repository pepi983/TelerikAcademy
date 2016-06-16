namespace _1_4.Point
{
    using System.IO;
    
    public class PathStorage
    {
        public static void SavePath(Path path, string fileName) 
        {
            StreamWriter writer = new StreamWriter("..//..//" + fileName + ".txt");

            using (writer)
            {
                for (int i = 0; i < path.PointList.Count; i++)
                {
                    writer.WriteLine(path.PointList[i]);
                }
            }
        }

        public static Path LoadPath(string fileName)
        {
            Path path = new Path();
            StreamReader reader = new StreamReader("..//..//" + fileName + ".txt");

            using (reader)
            {
                while (reader.EndOfStream == false)
                {
                    string nextPointTxt = reader.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);   
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
    }
}
