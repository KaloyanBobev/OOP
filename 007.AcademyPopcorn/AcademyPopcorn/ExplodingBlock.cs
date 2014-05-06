using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10. Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. You must NOT edit any existing .cs file. 

namespace AcademyPopcorn
{
    class ExplodingBlock: Block
    {
       
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<Splinter> splinters = new List<Splinter>();

                splinters.Add(new Splinter(this.TopLeft, new MatrixCoords(-1, -1)));
              
                splinters.Add(new Splinter(this.TopLeft, new MatrixCoords(-1, 1)));
                
                splinters.Add(new Splinter(this.TopLeft, new MatrixCoords(0, 1)));
                
                splinters.Add(new Splinter(this.TopLeft, new MatrixCoords(1, 0)));

                return splinters;
            }
            else
            {
                return base.ProduceObjects();
            }
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.ProduceObjects();
        } 
    }
}
