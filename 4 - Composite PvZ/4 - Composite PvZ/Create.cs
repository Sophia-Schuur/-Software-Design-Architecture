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

        public bool IsRunning { get { return isRunning; } }

        public Create(ref List<Zombie> zombies)
        {
            this.isRunning = true;
            this.zombies = zombies;
        }

        public void Tick()
        {
            
            //get zombie type from user
            Console.Write("  Enter Zombie type int:  ");
            var accessoryType = Console.ReadLine();
            if(accessoryType == "done")
            {
                Stop();
            }
            //add user specifed zombie to list of zombies
            //TO DO CHECK INPUT
            zombies.Add(new Zombie(accessoryType));
            Console.Write("[");
            foreach (var z in zombies)
            {
                Console.Write($"{ z.Type}/{ z.Health} ");
            }
            Console.Write("]");
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
