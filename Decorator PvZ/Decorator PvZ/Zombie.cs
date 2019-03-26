using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    public class Zombie  //all methods are capitalized
    {
        private int zombieHealth;
        private bool isAlive;

        public virtual bool IsAlive { get { return isAlive; } }
        public virtual bool IsMetal { get; }
        public virtual int Health { get { return zombieHealth; } }
        public virtual string Type { get { return "R"; } }
        public virtual void KillAccessory() { }

        public Zombie()
        {
            isAlive = true;
            zombieHealth = 50;
        }
        public virtual void TakeDamage(int damage)
        {
            zombieHealth -= damage;
        }

        public virtual void TakeBaseDamage(int damage)
        {
            zombieHealth -= damage;
        }

        public virtual void Die()
        {
            if (zombieHealth <= 0)
            {
                isAlive = false;
            }
        }
    }
}
