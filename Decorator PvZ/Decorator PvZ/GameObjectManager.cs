using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    class GameObjectManager
    {
        private List<Zombie> zombies;
        private List<Zombie> zombiesKilled;

        public List<Zombie> Zombies { get { return zombies; } }

        public GameObjectManager()
        {
            zombies = new List<Zombie>();
            zombiesKilled = new List<Zombie>();
        }

        public void AddZombie(Zombie zombie)
        {
            zombies.Add(zombie);
        }

        public void RemoveZombie(Zombie zombie)
        {
            Console.WriteLine($"  [!] - {zombie.Type} died.");
            zombies.Remove(zombie);
        }

        public void CheckEmpty()
        {
            if (zombies.Count == 0)
            {
                Console.WriteLine(" All zombies killed.");
                Console.WriteLine("\nExiting.");
                Environment.Exit(0);
            }
        }

        public void Update()
        {           
            foreach (Zombie z in zombies)
            {
                z.Die();
                if (z.IsAlive == false)
                {
                    zombiesKilled.Add(z);
                }
            }

            foreach (Zombie z in zombiesKilled)
            {
                RemoveZombie(z);
            }
            zombiesKilled.Clear();
        }

        public void PrintZombies()
        {
            Console.Write("   [ ");
            foreach (var z in zombies)
            {
                Console.Write($"{ z.Type}/{ z.Health} ");
            }
            Console.WriteLine("]");
        }
    }
}
