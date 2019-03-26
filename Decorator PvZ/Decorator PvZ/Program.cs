using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PvZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Plants Vs. Zombies Demo");

            new Menu().Run();

            Console.WriteLine("Exiting.");
        }
    }
}
