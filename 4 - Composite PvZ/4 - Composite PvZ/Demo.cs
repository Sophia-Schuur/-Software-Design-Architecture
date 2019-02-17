using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ
{
    class Demo
    {
        public bool isRunning = false;
        private List<Zombie> zombies;
        private int damage = 25;

        public bool IsRunning { get { return isRunning; } }

        public Demo(ref List<Zombie> zombies)
        {
            this.zombies = zombies;
        }

        public void Tick()
        {
            int damage = 25;

            Console.WriteLine("Press any key to shoot a zombie! Type q to stop. ");
            var inp = Console.ReadLine();

            if(zombies == null || inp == "q")
            {
                Stop();
            }
            
            zombies[0].TakeDamage(damage);

            if(zombies[0].Health <= 0)
            {
                zombies[0].Die();
                
            }
            foreach(var z in zombies)
            {
                if(!z.IsAlive)
                {
                    zombies.Remove(z);
                }
            }
        }
        public void Update()
        {
            if(isRunning)
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
            Environment.Exit(0);
        }
    }
}
