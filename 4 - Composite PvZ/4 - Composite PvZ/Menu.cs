using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Composite_PvZ
{
    public enum State { OPTIONS, CREATE, DEMO }


    class Menu
    {
        private State state;
        private Demo demo;//managers
        private Create create;
        private List<Zombie> zombies;
        private bool isRunning;
        
        public Menu()
        {
            isRunning = true;
            state = State.OPTIONS;
            zombies = new List<Zombie>();
            create = new Create(ref zombies);
            demo = new Demo(ref zombies);
        }
        public void Run()
        {
            while (isRunning)
            {
                if (state == State.OPTIONS)
                {
                    Console.WriteLine("(1): Create Zombies  ");
                    Console.WriteLine("(2): Demo gameplay ");

                    var mode = Console.ReadLine();
                    

                    if (mode == "1")
                    {
                        create.isRunning = true;
                        Console.WriteLine(" [!] - Type 'done' at any point to stop creating zombies.  ");
                        Console.WriteLine("(1): Regular  ");
                        Console.WriteLine("(2): Cone  ");
                        Console.WriteLine("(3): Bucket  ");
                        Console.WriteLine("(4): ScreenDoor  ");
                        Console.WriteLine(" Which type of Zombie?  ");
                        state = State.CREATE;
                    }
                    else if (mode == "2")
                    {
                        demo.isRunning = true;
                        state = State.DEMO;
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT");
                    }
                }
                if (state == State.CREATE)
                {
                    create.Update();
                    if (!create.IsRunning)
                    {
                        state = State.OPTIONS;
                    }
                }
                if (state == State.DEMO)
                {
                    demo.Update();
                    if (!demo.IsRunning)
                    {
                        state = State.OPTIONS;
                    }
                }
            }
        }

    }
}
