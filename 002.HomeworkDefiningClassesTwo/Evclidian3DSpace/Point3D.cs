using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evclidian3DSpace
{
    public struct Point3D
    {
        private static readonly Point3D center =new Point3D (0,0,0);
        public static int pointX = 0;
        public static int pointY = 0;
        public static int pointZ = 0;

        public int PointX { get; set; }
        public int PointY { get; set; }
        public int PointZ { get; set; }
     

        public Point3D(int pointX, int pointY, int pointZ)
            : this()
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
          
        }
       
        public override string ToString()
        {
            StringBuilder coordinate = new StringBuilder();
            coordinate.AppendFormat("Point X is:{0}\n",this.PointX.ToString());
            coordinate.AppendFormat("Point Y is:{0}\n", this.PointY.ToString());
            coordinate.AppendFormat("Point Z is:{0}\n", this.PointZ.ToString());


            return coordinate.ToString();
        }
    }
}
