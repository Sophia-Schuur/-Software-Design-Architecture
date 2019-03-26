using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    class GameEventManager
    {
        private GameObjectManager gameObjectManager;

        public GameEventManager(GameObjectManager gameObjectManager)
        {
            this.gameObjectManager = gameObjectManager;
        }

        public void DoDamage(int damage, Zombie zombie)
        {
            Console.WriteLine($"  [!] - {gameObjectManager.Zombies[0].Type} attacked.");
            zombie.TakeDamage(damage);
        }

        public void AttackFromAbove(int damage, Zombie zombie)
        {
            Console.Write($"  [!] - {gameObjectManager.Zombies[0].Type} attacked.");
            if (zombie.Type == "S")
            {
                Console.WriteLine(" Bypassing ScreenDoor.");
                zombie.TakeBaseDamage(damage);
            }
            else
            {
                Console.WriteLine("");
                zombie.TakeDamage(damage);
            }
        }

        public void ApplyMagnetForce(Zombie zombie)
        {
            Console.Write($"  [!] - {gameObjectManager.Zombies[0].Type} attacked.");

            if (zombie.IsMetal == true)
            {
                Console.Write(" Metal parts removed.");
                zombie.KillAccessory();
                Console.WriteLine(" Becoming Regular zombie.");
            }
            else
            {
                Console.Write(" No effect.\n");
            }
        }

        public void SimulateCollisionDetection(int plant)
        {
            Zombie shot = gameObjectManager.Zombies[0];
            switch (plant)
            {
                case 1:
                    DoDamage(25, shot);
                    break;
                case 2:
                    AttackFromAbove(30, shot);
                    break;
                case 3:
                    ApplyMagnetForce(shot);
                    break;
            }
        }
    }
}
