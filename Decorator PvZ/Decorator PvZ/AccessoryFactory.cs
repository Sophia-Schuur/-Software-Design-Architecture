using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    class AccessoryFactory
    {
        public static Zombie CreateZombie(string accessoryType)
        {
            if (accessoryType == "1")
            {
                return new Zombie();
            }
            else if (accessoryType == "2")
            {
                return new Cone(new Zombie());
            }
            else if (accessoryType == "3")
            {
                return new Bucket(new Zombie());
            }
            else if (accessoryType == "4")
            {
                return new ScreenDoor(new Zombie());
            }
            return null;
        }
    }
}
