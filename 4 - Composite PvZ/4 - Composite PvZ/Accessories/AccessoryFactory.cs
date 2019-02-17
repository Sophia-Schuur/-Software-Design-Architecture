using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ.Accessories
{
    public static class AccessoryFactory
    {
        public static Accessory GetAccessory(string accessoryType)
        {
            if (accessoryType == "1")
            {
               
                return new Regular();
            }
            else if (accessoryType == "2")
            {
                
                return new Cone();
            }
            else if (accessoryType == "3")
            {
                return new Bucket();
            }
            else if (accessoryType == "4")
            {
                return new ScreenDoor();
            }
            return null;
        }
    }

    public abstract class Accessory
    {
        protected int health;
        public string Type;
        public int Health { get { return health; } set { health = value; } }
    }

    public class Regular : Accessory
    {
        public Regular()
        {
            Type = "R";
            health = 50;
        }
    }

    public class Cone : Accessory
    {
        public Cone()
        {
            Type = "C";
            health = 75;
        }
    }

    public class Bucket : Accessory
    {
        public Bucket()
        {
            Type = "B";
            health = 150;
        }
    }

    public class ScreenDoor : Accessory
    {
        public ScreenDoor()
        {
            Type = "S";
            health = 75;
        }
    }
}
