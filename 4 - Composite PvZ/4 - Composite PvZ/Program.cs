//Sophia Schuur
//2/16/2019
//Simulates a Plants vs. Zombies demo using Factory and Composite design patterns.
//Game design practice.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ
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
