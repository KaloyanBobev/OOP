using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootPlayerRacketEngine:Engine
    {
        public ShootPlayerRacketEngine(IRenderer renderer, IUserInterface userInterface, int sleepTimer)
            : base(renderer, userInterface, sleepTimer)
        { 
        }

        public void ShootPlayerRacket() //4.Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
        {
            if (this.playerRacket is ShootingRacket)
            {
                (this.playerRacket as ShootingRacket).Shoot();
            }
        }
    }
}
