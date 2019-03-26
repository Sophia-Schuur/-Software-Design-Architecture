using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    class Demo
    {
        private GameEventManager gameEventManager;
        private GameObjectManager gameObjectManager;

        public bool isRunning = false;
        public bool IsRunning { get { return isRunning; } }

        public Demo(GameObjectManager gameObjectManager, GameEventManager gameEventManager)   //constructor
        {
            this.gameObjectManager = gameObjectManager;
            this.gameEventManager = gameEventManager;
        }

        public void Tick(int damageValue)
        {
            gameObjectManager.CheckEmpty();
            Console.WriteLine("\n Select an attack: \n  (1) Peashooter\n  (2) Watermelon\n  (3) Magnet-shrooms\n");

            var inp = Console.ReadLine();

            if (inp == "q")
                    Stop();
            gameEventManager.SimulateCollisionDetection(Int32.Parse(inp));
            gameObjectManager.Update();
            gameObjectManager.PrintZombies();
            gameObjectManager.CheckEmpty();
        }
        public void Update(int damageValue)
        {
            if (isRunning)
            {
                Tick(damageValue);
            }
        }
        public void Run()
        {
            isRunning = true;
        }
        public void Stop()
        {
            isRunning = false;
            Console.WriteLine("\nExiting.");
            Environment.Exit(0);
        }
    }
}
