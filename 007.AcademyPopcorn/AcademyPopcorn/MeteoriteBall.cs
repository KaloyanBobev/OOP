using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*6.Implement a MeteoriteBall. It should inherit the Ball class and should leave a 
 *  trail of TrailObject objects. Each trail objects should last for 3 "turns". 
 *  Other than that, the Meteorite ball should behave the same way as the normal ball. You must NOT edit any existing .cs file.*/

namespace AcademyPopcorn
{
    class MeteoriteBall:Ball
    {

        private char[,] trailObjBody = new char[,] { { '@' } };
        private int trailObjLifeTime;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int trailObjLifeTime)
            : base(topLeft, speed)
        {
            this.trailObjLifeTime = trailObjLifeTime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> trail = new List<TrailObject>();
            TrailObject trailObj=new TrailObject(this.TopLeft,this.trailObjBody,this.trailObjLifeTime);
            trail.Add(trailObj);

            return trail;
        }
    }
}
