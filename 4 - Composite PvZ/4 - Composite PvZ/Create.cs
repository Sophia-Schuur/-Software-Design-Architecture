using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ
{
    class Create
    {
        public bool isRunning = false;
        private List<Zombie> zombies;
        private int damage = 25;
        private Printing printing;

        public bool IsRunning { get { return isRunning; } }

        public Create(ref List<Zombie> zombies)
        {
            this.isRunning = true;
            this.zombies = zombies;
            this.printing = new Printing();
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
            zombies.Add(new Zombie(accessoryType));

            printing.PrintArray(ref zombies);
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
