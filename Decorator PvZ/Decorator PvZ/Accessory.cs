using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    public abstract class Accessory : Zombie    //means to override functions of zombie
    {
        private Zombie zombie;
        private bool isAlive;

        protected int accessoryHealth;
        protected string type;
        protected bool isMetal;

        public override string Type { get { if (isAlive) { return type; } else { return "R"; } } }
        public override bool IsAlive { get { return zombie.IsAlive; } }
        public override int Health { get { return zombie.Health + accessoryHealth; } }
        public override bool IsMetal { get { return isMetal; } }

        public Accessory(Zombie zombie)
        {
            this.zombie = zombie;
            isAlive = true;
        }
     
        public override void KillAccessory()
        {
            accessoryHealth = 0;          
        }

        public override void Die()
        {
            zombie.Die();
            if (accessoryHealth <= 0)
            {
                isAlive = false;
            }
        }

        public override void TakeDamage(int damage)
        {
            if(isAlive == true)
            {
                accessoryHealth -= damage;
                if (accessoryHealth < 0)    //if accessory health is 0, accomodate for overflow damage to base zombie
                {
                    TakeBaseDamage(accessoryHealth * -1);
                    accessoryHealth = 0;
                    Console.Write(" Becoming Regular zombie.\n");
                }
            }
            else
            {
                TakeBaseDamage(damage);
            }
        }

        public override void TakeBaseDamage(int damage)
        {
            zombie.TakeDamage(damage);
        }
    }

    public class Cone : Accessory
    {
        public Cone(Zombie zombie) : base(zombie)
        {
            type = "C";
            accessoryHealth = 25;
            isMetal = false;
        }
    }

    public class Bucket : Accessory
    {
        public Bucket(Zombie zombie) : base(zombie)
        {
            type = "B";
            accessoryHealth = 100;
            isMetal = true;
        }
    }

    public class ScreenDoor : Accessory
    {
        public ScreenDoor(Zombie zombie) : base(zombie)
        {
            type = "S";
            accessoryHealth = 25;
            isMetal = true;
        }
    }
}
