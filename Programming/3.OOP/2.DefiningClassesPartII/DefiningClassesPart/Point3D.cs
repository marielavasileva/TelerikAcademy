using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DefiningClassesPartII
{
    public class Point
    {
        static class DistancePoint
        {


            public static double Calculate(Point3D a, Point3D b)
            {
                int x = b.X - a.X;
                int y = b.Y - a.Y;
                int z = b.Z - a.Z;

                return Math.Sqrt(x * x + y * y + z * z);
            }
        }


        public struct Point3D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public static readonly Point3D values;

            public Point3D(int x, int y, int z)
                : this()
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            private static Point3D Values
            {
                get { return values; }
               

            }
            public override string ToString()
            {
                string info = " " + X + " " + Y + " " + Z;
                return info;
            }


        }

        public class Path
        {
            private List<Point3D> points;
            public Path()
            {
                points = new List<Point3D>();
            }
            public List<Point3D> Points
            {
                get
                {
                    return this.points;
                }
                set
                {
                    this.points = value;
                }

            }

            public void Add(Point3D point)
            {
                this.points.Add(point);
            }
        }


        static class PathStorage
        {
            public static Path AddPath(string pathFile)
            {
                Path pointsPath = new Path();

                try
                {
                    
                    StreamReader reader = new StreamReader(pathFile);

                    using (reader)
                    {
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            pointsPath.Add(ParseLinePoint(line));

                            line = reader.ReadLine();
                        }
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
                Console.WriteLine("Reading  successful");
                return pointsPath;
            }

            public static void SavePaths(Path pathToFile)
            {
                try
                {

                    StreamWriter writer = new StreamWriter(@"../../savedPaths.txt", false);
                    List<Point3D> path = pathToFile.Points;
                    using (writer)
                    {
                        for (int i = 0; i < path.Count; i++)
                        {
                            string point = path[i].ToString();
                            writer.WriteLine(point.Trim(new char[] { '{', '}' }));
                        }
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
                Console.WriteLine("Save successful!");
            }

            private static Point3D ParseLinePoint(string line)
            {
                string[] splited = line.Split();
                Point3D point = new Point3D();
                point.X = int.Parse(splited[0]);
                point.Y = int.Parse(splited[1]);
                point.Z = int.Parse(splited[2]);
                return point;
            }
        }

        static void Main(string[] args)
        {
            Path sequenceOfPoints = new Path();
            
            sequenceOfPoints = PathStorage.AddPath(@"../../paths.txt");

           
            PathStorage.SavePaths(sequenceOfPoints);

            
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Testing distance ");
            Point3D point1 = new Point3D();
            point1.X = 1;
            point1.Y = 2;
            point1.Z = 0;
            Console.WriteLine("Point 1: {0}", point1);
            Console.WriteLine("Point 2: {0}", Point3D.values);
            Console.WriteLine("Distance between {0} and {1} is {2:F2}", point1, Point3D.values, DistancePoint.Calculate(point1, Point3D.values));

        }
    }
}



//static class PathStorage
//{
//    private static string inputFile = @"..\..\Input.txt";
//    private static string outputFile = @"..\..\Result.txt";

//    public static Path Load()
//    {
//        using (StreamReader sr = new StreamReader(inputFile))
//        {
//            int lineNumber = 0;
//            string line = sr.ReadLine();
//            Path path = new Path();

//            while (line != null)
//            {
//                lineNumber++;
//                string[] pointCoord = line.Split(' ');
//                Point3D point = new Point3D(
//                                            double.Parse(pointCoord[0]),
//                                            double.Parse(pointCoord[1]),
//                                            double.Parse(pointCoord[2]));
//                path.Points.Add(point);
//                line = sr.ReadLine();
//            }

//            return path;
//        }
//    }

//    public static void Save(Path path)
//    {
//        using (StreamWriter sw = new StreamWriter(outputFile))
//        {
//            foreach (Point3D point in path.Points)
//            {
//                sw.WriteLine(point);
//            }
//        }
//    }
//}