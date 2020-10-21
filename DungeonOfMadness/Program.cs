using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace DungeonOfMadness
{
    public class Program
    {
        public static Random rand = new Random();
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
 ___           __                   _    _    __                                  
  | |_   _    (_        _  ._ _|   / \ _|_   /__ |  _. ._ _  |_   _| ._ o ._   _  
  | | | (/_   __) \/\/ (_) | (_|   \_/  |    \_| | (_| | | | |_) (_| |  | | | (_| 
                                                                               _| 
                    A Silly Console RPG By Kyle Brock   2020                ";

            Print(title, 1);
            Print("                           <Press any key to continue>", 10);  
            Console.ReadKey();
            Console.Clear();
            if (!Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }
            currentPlayer = Load(out bool newP);
            if (newP)
            {
                Encounters.FirstEncounter();
            }
            while (mainLoop)
            {
                Encounters.RandomEncounter();
            }
        }

        static public Player newStart(int i)
        {
            Console.Clear();
            Player p = new Player();
            Print("Welcome To The Dungeon Of Madness!");
            Print("What is thy name adventurer?");
            p.name = Console.ReadLine();
            p.id = 1;
            if (p.name == "")
            { 
                Print("Ooooooh. Not having a name is pretty edgy. Probably a little too edgy for this game...");
                Print("What is thy name adventurer?");
                p.name = Console.ReadLine();
            }
            else
                Print(p.name + " is a pretty wimpy name for an adventurer...");
            Print("Let's go with " + p.name + ".");
            Console.ReadKey();
            Console.Clear();
            Print("Thou awakens in an inky black chamber. Thou feelth the cold stone floor beneath your feet.");
            Print("Suffering from mead induced amnesia thou fumbles thy way to thy feet.");
            Console.ReadKey();
            Console.Clear();
            Print("Undaunted, thou frantically searchs for an exit from this dark room.");
            Console.ReadKey();
            Console.Clear();
            Print("THE GODS SMILE UPON YE! Thou is able to find what thou believes to");
            Print("be a door handle. Although it is sticky to the touch thou is not a coward and turns it with a vigor!");
            Console.ReadKey();
            Console.Clear();
            Print("The door swings outward and you find thyself face to face with your captor!");
            Console.ReadKey();
            Print("Standing before thou is a greasy morbidly obese Lizard Man!");
            Console.ReadKey();
            string lizardMan = @"
                                             ,--,  ,.-.
               ,                   \,       '-,-`,'-.' | ._
              /|           \    ,   |\         }  )/  / `-,',
              [ ,          |\  /|   | |        /  \|  |/`  ,`
              | |       ,.`  `,` `, | |  _,...(   (      .',
              \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\
               \  \_\,``,   ` , ,  /  |         )         _,/
                \  '  `  ,_ _`_,-,<._.<        /         /
                 ', `>.,`  `  `   ,., |_      |         /
                   \/`  `,   `   ,`  | /__,.-`    _,   `\
               -,-..\  _  \  `  /  ,  / `._) _,-\`       \
                \_,,.) /\    ` /  / ) (-,, ``    ,        |
               ,` )  | \_\       '-`  |  `(               \
              /  /```(   , --, ,' \   |`<`    ,            |
             /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
       ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
      (-, \           ) \ ('_.-._)/ /,`    /
      | /  `          `/ \\ V   V, /`     /
   ,--\(        ,     <_/`\\     ||      /
  (   ,``-     \/|         \-A.A-`|     /
 ,>,_ )_,..(    )\          -,,_-`  _--`
(_ \|`   _,/_  /  \_            ,--`
 \( `   <.,../`     `-.._   _,-`
            ";
            Console.WriteLine(lizardMan);
            Console.ReadKey();
            Print("Unthinking, thou grabs a conviently placed rusty sword and charge the bloated reptile!");
            Console.ReadKey();
            Console.Clear();
            string vertSword = @"

            .-.
           (0.0)
         '=.|m|.='
         .='/@\`=.
            @8@
        _   8@8   _
       (@__/@8@\__@)
        `-=:8@8:=-'
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            |:|
            \:/
             ^
";
            Print(vertSword, 1);
            Print("A strange aura eminates from this sword...");
            Print("Thou aren't sure if it is magical in nature or perhaps just acrid poop smells.");
            Console.ReadKey();
            Console.Clear();
            Print("A voice speaks withing thine mind's eye...");
            Console.ReadKey();
            Print(p.name + ", thou have been chosen to wield me...the ultimate blade Glambdring!");
            Console.ReadKey();
            Print("If thou wishes to leave this dungeon alive, thou must empower with me gold!");
            Console.ReadKey();
            Print("Slaughter the monsters within this dungeon, and speak the magic word '[R]un' to enter my realm");
            Print("and bestow upon me their ill gotten goods, and I shall empower you to defeat your captors!");
            Console.ReadKey();
            return p;
        }

        public static void Quit()
        {
            Save();
            Environment.Exit(0);
        }
        public static void Save()
        {
            BinaryFormatter binForm = new BinaryFormatter();
            string path = "saves/" + currentPlayer.id.ToString() + ".level";
            FileStream file = File.Open(path, FileMode.OpenOrCreate);
            binForm.Serialize(file, currentPlayer);
            file.Close();
        }

        public static Player Load(out bool newP)
        {
            newP = false;
            Console.Clear();
            string[] paths = Directory.GetFiles("saves");
            List<Player> players = new List<Player>();
            int idCount = 0;

            BinaryFormatter binForm = new BinaryFormatter();
            foreach (string p in paths)
            {
                FileStream file = File.Open(p, FileMode.Open);
                Player player = (Player)binForm.Deserialize(file);
                file.Close();
                players.Add(player);
            }

            idCount = players.Count;

            while (true)
            {
                Console.Clear();
                Print("Continue Your Adventure?", 60);
                
                foreach (Player p in players)
                {
                    Console.WriteLine(p.id + " : " + p.name);
                }
               
                Print("Please Enter Player's Name or ID. (ID=# or Player's Name)");
                Print("Entering 'create' will make a new save file.)");
                string[] data = Console.ReadLine().Split(':');

                try
                {
                    if (data[0] == "id")
                    {
                        if (int.TryParse(data[1], out int id))
                        {
                            foreach (Player player in players)
                            {
                                if (player.id == id)
                                {
                                    return player;
                                }
                            }
                            Print("There is no player with that ID. Press any key to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Print("Your ID needs to be a number. Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    else if (data[0] == "create")
                    {
                        Player newPlayer = newStart(idCount);
                        newP = true;
                        return newPlayer;
                       
                    }
                    else
                    {
                        foreach (Player player in players)
                        {
                            if (player.name == data[0])
                            {
                                return player;
                            }
                        }
                        Print("There is no player with that ID. Press any key to continue.");
                        Console.ReadKey();
                    }
                }
                catch(IndexOutOfRangeException) 
                {
                    Print("Your ID needs to be a number. Press any key to continue.");
                    Console.ReadKey();
                }
            }
            

        }
        public static void Print(string text, int speed = 40)
        {
            //SoundPlayer soundPlayer = new SoundPlayer("sounds/bookFlip1.wav");
            //soundPlayer.PlayLooping();
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            //soundPlayer.Stop();
            Console.WriteLine();
        }
    }
}
