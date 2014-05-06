using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evclidian3DSpace
{
    static class PathStorage
    {
        public static void SavePathFromFile(Path savePath)
        {
            using (StreamWriter writer = new StreamWriter(@"../../savedPath.txt"))
            {
                foreach (var p in savePath.pathOfPoint)
                {
                    writer.WriteLine(String.Format("[{0},{1},{2}]", p.PointX, p.PointY, p.PointZ));
                }
            }
        }

        public static List<Path> LoadPathFromFile()
        {
            Path loadingPath = new Path();
            List<Path> pathsLoaded = new List<Path>();
            try
            {
                Path loadPath = new Path();
                List<Path> pathsLoad = new List<Path>();
                using (StreamReader reader = new StreamReader(@"../../savedPath.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (line != "-")
                        {
                            Point3D point = new Point3D();
                            string[] points = line.Split(new char[] { '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
                            point.PointX = int.Parse(points[0]);
                            point.PointY = int.Parse(points[1]);
                            point.PointZ = int.Parse(points[2]);
                            loadPath.AddPoint(point);
                        }
                        else
                        {
                            pathsLoaded.Add(loadPath);
                            loadPath = new Path();
                        }

                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!!!");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally { }
            return pathsLoaded;
        }
    }
}
