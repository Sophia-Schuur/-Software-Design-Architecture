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
        private int damageValue;
        private Printing printing;

        public Menu()
        {
            isRunning = true;
            state = State.OPTIONS;
            zombies = new List<Zombie>();
            create = new Create(ref zombies);
            demo = new Demo(ref zombies);
            damageValue = 25;
            printing = new Printing();
        }
        public void Run()
        {
            while (isRunning)
            {
                if (state == State.OPTIONS)
                {
                    Console.WriteLine("\n- - - - - Main Menu - - - - -  ");
                    Console.WriteLine("\n (1): Create Zombies  ");
                    Console.WriteLine(" (2): Demo gameplay ");

                    var mode = Console.ReadLine();
                    

                    if (mode == "1")
                    {
                        create.isRunning = true;
                        Console.WriteLine(" (1) - Zombie creation selected.  \n");
                        Console.WriteLine(" [NOTE] - Press 'q' at any point to stop creating zombies.  \n");
                        Console.WriteLine("  Available Zombie types:  ");
                        Console.WriteLine("   (1): Regular  ");
                        Console.WriteLine("   (2): Cone  ");
                        Console.WriteLine("   (3): Bucket  ");
                        Console.WriteLine("   (4): ScreenDoor  ");                       
                        state = State.CREATE;
                    }
                    else if (mode == "2")
                    {
                        Console.WriteLine(" (2) - Demo selected.  \n");
                        Console.WriteLine(" [NOTE] - Press 'q' at any time to exit.\n");

                        string inp;
                        bool success = false;
                        while (!success)
                        {
                            Console.Write("  Input a damage value:  ");
                            inp = Console.ReadLine();

                            int i;
                            success = int.TryParse(inp, out i);
                            if (!success)
                                Console.WriteLine(" [!] - INVALID INPUT. Input an integer.\n");
                            else
                            {
                                damageValue = Int32.Parse(inp);

                                Console.WriteLine();

                                printing.PrintArray(ref zombies);

                                demo.isRunning = true;
                                state = State.DEMO;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(" [!] - INVALID INPUT. Input an integer between 1-2.");
                    }
                }
                if (state == State.CREATE)
                {
                    create.Update();
                    if (create.IsRunning == false)
                    {
                        state = State.OPTIONS;
                    }
                    
                }
                if (state == State.DEMO)
                {
                    demo.Update(damageValue);
                    if (!demo.IsRunning)
                    {
                        state = State.OPTIONS;
                    }
                }
            }
        }
    }
}
