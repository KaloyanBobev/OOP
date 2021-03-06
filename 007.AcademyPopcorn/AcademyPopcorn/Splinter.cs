﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    class Splinter: MovingObject
    {
        public Splinter(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { '~' } }, speed)
        { 
        }

        public override void Update()
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Block.CollisionGroupString;
        }
    }
}
