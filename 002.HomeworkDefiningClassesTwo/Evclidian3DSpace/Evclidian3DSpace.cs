
// 1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evclidian3DSpace
{
    class Evclidian3DSpace
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(1, 2, 3);
            Point3D secondPoint = new Point3D(-1, 2, -8);
            Point3D thirdPoint = new Point3D(9, 7, 8);

            Console.WriteLine(firstPoint.ToString());
            Console.WriteLine(secondPoint.ToString());
            Console.WriteLine(thirdPoint.ToString());

            Console.WriteLine(CalcDistance.CalculateDistance(firstPoint,secondPoint));

            Path p = new Path();
            p.AddPoint(new Point3D(1, 1, 1));
            p.AddPoint(new Point3D(2, 2, 2));
            p.AddPoint(new Point3D(5, 7, 9));
           

            PathStorage.SavePathFromFile(p);
            PathStorage.LoadPathFromFile(); 

           
        }
    }
}
