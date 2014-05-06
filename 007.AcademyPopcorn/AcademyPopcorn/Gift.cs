using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11.Implement a Gift class. It should be a moving object, which always falls down. The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket. You must NOT edit any existing .cs file. 


namespace AcademyPopcorn
{
    class Gift:MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft, char[,] body)
            : base(topLeft, body, new MatrixCoords(1, 1))
        { 
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Racket.CollisionGroupString;
        }

        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.ProduceObjects();
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<ShootingRacket> rackets = new List<ShootingRacket>();

                // replace the ordinary racket with a shooting one
                ShootingRacket shootingRacket = new ShootingRacket(
                    new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col), 6);
                rackets.Add(shootingRacket);

                return rackets;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}