using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Engine
    {
        // 2.The Engine class has a hardcoded sleep time (search for "System.Threading.Sleep(500)". Make the sleep time a field in the 
        // Engine and implement a constructor, which takes it as an additional parameter.

        
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;
        public Racket playerRacket;
        private int sleepTimer;

        public int SleepTimer
        {
            get { return this.sleepTimer; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The time will be positive number");
                }
                else
                {
                    this.sleepTimer = value;
                }
            }
        }

        public Engine(IRenderer renderer, IUserInterface userInterface,int sleepTimer)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.sleepTimer = sleepTimer;
        }

        public Engine(IRenderer renderer, IUserInterface userInterface):this (renderer,userInterface,200) 
        {
        }
        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Racket)
                {
                    AddRacket(obj);

                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddRacket(GameObject obj)
            //3.Search for a "TODO" in the Engine class, regarding the AddRacket method. Solve the problem mentioned there.
            //There should always be only one Racket. Note: comment in TODO not completely correct

        {
            //TODO: we should remove the previous racket from this.allObjects
            RemovePreviosRacket();
            this.playerRacket = obj as Racket;
            this.AddStaticObject(obj);
        }

        private void RemovePreviosRacket()
        {
            this.staticObjects.RemoveAll(obj => obj is Racket);
            this.allObjects.RemoveAll(obj => obj is Racket);
        }

        public virtual void MovePlayerRacketLeft()
        {
            this.playerRacket.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {
            this.playerRacket.MoveRight();
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(this.sleepTimer);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}
