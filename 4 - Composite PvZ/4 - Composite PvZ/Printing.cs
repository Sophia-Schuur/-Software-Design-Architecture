using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ
{
    class Printing
    {
        public void PrintArray(ref List<Zombie> zombies)
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
