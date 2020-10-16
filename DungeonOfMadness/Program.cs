using System;

namespace DungeonOfMadness
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            Console.Title = "ASCII Art";
            string title = @"
                ___                                        ___  __ 
               /   \_   _ _ __   __ _  ___  ___  _ __     /___\/ _|
              / /\ / | | | '_ \ / _` |/ _ \/ _ \| '_ \   //  // |_ 
             / /_//| |_| | | | | (_| |  __/ (_) | | | | / \_//|  _|
            /___,'  \__,_|_| |_|\__, |\___|\___/|_| |_| \___/ |_|  
                                |___/                              
                                      _                     
                      /\/\   __ _  __| |_ __   ___  ___ ___ 
                     /    \ / _` |/ _` | '_ \ / _ \/ __/ __|
                    / /\/\ \ (_| | (_| | | | |  __/\__ \__ \
                    \/    \/\__,_|\__,_|_| |_|\___||___/___/                     
                                                                 ";

            Console.WriteLine(title);
            Console.WriteLine("                             Press any key to continue");  
            Console.ReadKey();
            Console.Clear();
            Start();
            Encounters.FirstEncounter();
            while (mainLoop)
            {
                Encounters.RandomEncounter();
            }
        }

        static void Start()
        {
            Console.WriteLine("Welcome To The Dungeon Of Madness!");
            Console.WriteLine("What is thy name adventurer?");
            currentPlayer.name = Console.ReadLine();
            if (currentPlayer.name == "")
            {
                Console.WriteLine("Ooooooh. Not having a name is pretty edgy. Probably a little too edgy for this game...");
                Console.WriteLine("What is thy name adventurer?");
                currentPlayer.name = Console.ReadLine();
            }
            else
                Console.WriteLine(currentPlayer.name + " is a pretty wimpy name for an adventurer...");
            Console.WriteLine("But sure let's go with " + currentPlayer.name + ".");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thou awakens in an inky black chamber. Thou feelth the cold stone floor beneath your feet.");
            Console.WriteLine("Suffering from mead induced amnesia tho fumbles thine way to thy feet.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Undaunted thy frantically searchs for an exit from this dark room.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("'THE OLD GODS SMILE UPON ME,' Thy thinks to thyself as you find what you believe to");
            Console.WriteLine("be a door handle. Allow it is sticky to the touch thine is not a coward and turns it with a vigor!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The door swings outward and you find thyself face to face with your captor!");
        }
    }
}
