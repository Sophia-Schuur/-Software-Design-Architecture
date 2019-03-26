using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    class CreateZombies
    {
        public bool isRunning = false;
        private GameObjectManager gameObjectManager;

        public bool IsRunning { get { return isRunning; } }

        public CreateZombies(GameObjectManager gameObjectManager)
        {
            this.isRunning = true;
            this.gameObjectManager = gameObjectManager;
        }

        public void Tick()
        {
            Console.Write("\n  Input Zombie type integer:  ");
            var accessoryType = Console.ReadLine();

            if (accessoryType == "q")
            {
                Stop();
                return;
            }

            if (accessoryType != "1" && accessoryType != "2" && accessoryType != "3" && accessoryType != "4")
            {
                Console.WriteLine(" [!] - INVALID INPUT. Input an integer between 1-4 or 'q' to stop adding zombies.");
                return;
            }
            gameObjectManager.AddZombie(AccessoryFactory.CreateZombie(accessoryType));
            gameObjectManager.PrintZombies();
        }
        public void Update()
        {
            if (isRunning)
            {
                Tick();
            }
        }
        public void Run()
        {
            isRunning = true;
        }
        public void Stop()
        {
            isRunning = false;
        }
    }
}
