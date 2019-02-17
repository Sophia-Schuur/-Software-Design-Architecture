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
        private Printing printing;

        public bool IsRunning { get { return isRunning; } }

        public Demo(ref List<Zombie> zombies)   //constructor
        {
            this.zombies = zombies;
            this.printing = new Printing();
        }

        public void Tick(int damageValue)
        {
            int damage = damageValue;
            if(zombies.Count == 0)  //no more zombies (or initial empty list)
            {
                Console.WriteLine(" All zombies killed.");
                Stop();
            }
            Console.Write("\n  Press any key to shoot a zombie.");
            var inp = Console.ReadLine();

            if(inp == "q")
                Stop();
            
            Console.Write($"  [!] - { zombies[0].Type} shot.");
            zombies[0].TakeDamage(damage);

            Console.WriteLine();
            printing.PrintArray(ref zombies);

            if (!zombies[0].IsAlive)
            {
                Console.WriteLine($"  [!] - {zombies[0].Type} died.");
                zombies.Remove(zombies[0]);
            }
            
        }
        public void Update(int damageValue)
        {
            if(isRunning)
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
