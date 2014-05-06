using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.Implement  an UnpassableBlock.

namespace AcademyPopcorn
{
    class UnpassableBlock: Block
    {
        public UnpassableBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        { 
        }

        public override string GetCollisionGroupString()
        {
            return base.GetCollisionGroupString();
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "UnpassableBall";
        }
    }
}
