// 3.Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evclidian3DSpace
{
    class CalcDistance
    {
        public static double CalculateDistance(Point3D pointOne, Point3D pointTwo)
        {
            double result = Math.Sqrt((pointOne.PointX - pointTwo.PointX) * (pointOne.PointX - pointTwo.PointX) +
            (pointOne.PointY - pointTwo.PointY) * (pointOne.PointY - pointTwo.PointY) + (pointOne.PointZ - pointTwo.PointZ) * (pointOne.PointZ - pointTwo.PointZ));
            return result;
        }

    }
}
