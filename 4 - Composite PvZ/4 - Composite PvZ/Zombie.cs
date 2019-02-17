using _4___Composite_PvZ.Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ
{
    class Zombie
    {
        int health;
        private Accessory _accessory;
        private bool isAlive;

        public Zombie(string accessoryType)
        {
            isAlive = true;
            health = 50;
            _accessory = AccessoryFactory.GetAccessory(accessoryType);
        }

        public int Health { get { return _accessory.Health; } }
        public string Type { get { return _accessory.Type; } }
        public bool IsAlive { get { return isAlive; } }

        public void TakeDamage(int damage)
        {
            if(_accessory != null)
            {             
                _accessory.Health -= damage;
                var temp = _accessory.Health;   //temp health for leftover damage

                if (_accessory.Health <= 0 && _accessory.Type == "R")   //dead zombie
                {
                    Die();
                }
                else if (_accessory.Health <= 50 && _accessory.Type != "R") //become regular zombie if health is below 50 (regular zombie max health)
                {
                    _accessory = AccessoryFactory.GetAccessory("1");
                    _accessory.Health = temp;
                    Console.Write(" Becoming Regular zombie.");
                }                
            }
        }
        public void Die()
        {
            isAlive = false;          
        }
    }
}
