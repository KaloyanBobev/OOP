using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
                Block currBlock2 = new Block(new MatrixCoords(startRow + 2, i));
                engine.AddObject(currBlock2);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
          //  engine.AddObject(theBall);
            //7.Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.

           // MeteoriteBall theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1), 3);
           // engine.AddObject(MatrixCoords);

            //9.Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file

            UnstoppableBall unstopBall=new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            engine.AddObject(unstopBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //add side walls
            /*1.The AcademyPopcorn class contains an IndestructibleBlock class. Use it to create side and ceiling walls to the game.
             * You can ONLY edit the AcademyPopcornMain.cs file. */

            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock leftWallBlock = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(leftWallBlock);
                IndestructibleBlock rightWallBlock = new IndestructibleBlock(new MatrixCoords(row,WorldCols-1));
                engine.AddObject(rightWallBlock);
               
            }

            for (int row = 0; row < WorldCols; row++)
            {
                 IndestructibleBlock topper = new IndestructibleBlock(new MatrixCoords(0, row));
                engine.AddObject(topper);
               // IndestructibleBlock bottem = new IndestructibleBlock(new MatrixCoords(WorldRows-2, row));
               // engine.AddObject(bottem);
            }

             for (int i = 1; i < WorldCols; i+=5)
            {
                ExplodingBlock explosion = new ExplodingBlock(new MatrixCoords(3, i));
                engine.AddObject(explosion);
            }

            for (int i = 1; i < WorldCols; i += 5)
            {
                GiftBlock giftBlock = new GiftBlock(new MatrixCoords(4, i));
                engine.AddObject(giftBlock);
            }
            
            ShootingRacket shoot = new ShootingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(shoot);

        
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
