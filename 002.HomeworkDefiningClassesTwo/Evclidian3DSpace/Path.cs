using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evclidian3DSpace
{
    public class Path
    {
        public List <Point3D> pathOfPoint= new List<Point3D>();
        public List<Point3D> PathOfPoint
        {
            get
            {
                return this.pathOfPoint; 
            }
            set
            {
                this.pathOfPoint = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.PathOfPoint.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.PathOfPoint.Remove(point);
        }

        public void ClearAllPoint()
        {
            this.PathOfPoint.Clear();
        }
    }
}
