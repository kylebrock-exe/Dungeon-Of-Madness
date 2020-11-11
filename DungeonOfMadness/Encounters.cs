using System;
using System.Collections.Generic;
using System.Text;
namespace DungeonOfMadness
{
    public class Encounters 
    {

        //Random
        static Random rand = new Random();

        
        //Encounters
        public static void FirstEncounter()
        {
            Combat(false, "Obese Lizard Man", 1, 4);
        }
        public static void BasicFightEncounter()
        {
            Console.Clear();
            Print("Turning the corner thou spots a monstrosity heading thou's way!");
            Console.ReadKey();
            Combat(true,"",0,0);

        }
        public static void WizardEncounter()
        {
            Console.Clear();
            Print("As thou opens the door thou hears a crackling of arcane energy as a demented old man appears before thou!");
            Console.ReadKey();
            Console.Clear();
            string darkWizard = @"
                          ,---.
                          /    |
                         /     |
                        /      |
                       /       |
                  ___,'        |
                <  -'          :
                 `-._\..-/'``-,_\_
                    |o/ <o>` :,.)_`>
                    :/ `     ||/)
                    (_.).__,-` |\
                    /( `.``   `| :
                    \'`-.)  `  ; ;
                    | `       /-<
                    |     `  /   `.
    ,-_-..____     /|  `    :__..-'\
   /,'-.__\\  ``-./ :`      ;       \
   `\ `\  `\\  \ :  (   `  /  ,   `. \
     \` \   \\   |  | `   :  :     .\ \
      \ `\_  ))  :  ;     |  |      ): :
     (`-.-'\ ||  |\ \   ` ;  ;       | |
      \-_   `;;._   ( `  /  /_       | |
       `-.-.// ,'`-._\__/_,'         ; |
          \:: :     /     `     ,   /  |
           || |    (        ,' /   /   |
           ||                ,'   /    |
";
            Console.WriteLine(darkWizard);
            Print("Thou dare interrupts my studies!? Have thee no respect for the ARCANE ARTS!?");
            Console.ReadKey();
            Console.Clear();
            Print("No, I don't because...");
            Console.ReadKey();
            string magicNerd = @"
.___  ___.      ___       _______  __    ______     __       _______.
|   \/   |     /   \     /  _____||  |  /      |   |  |     /       |
|  \  /  |    /  ^  \   |  |  __  |  | |  ,----'   |  |    |   (----`
|  |\/|  |   /  /_\  \  |  | |_ | |  | |  |        |  |     \   \    
|  |  |  |  /  _____  \ |  |__| | |  | |  `----.   |  | .----)   |   
|__|  |__| /__/     \__\ \______| |__|  \______|   |__| |_______/    
                                                                     
 _______   ______   .______      
|   ____| /  __  \  |   _  \     
|  |__   |  |  |  | |  |_)  |    
|   __|  |  |  |  | |      /     
|  |     |  `--'  | |  |\  \----.
|__|      \______/  | _| `._____|
                                 
.__   __.  _______ .______       _______       _______. __  
|  \ |  | |   ____||   _  \     |       \     /       ||  | 
|   \|  | |  |__   |  |_)  |    |  .--.  |   |   (----`|  | 
|  . `  | |   __|  |      /     |  |  |  |    \   \    |  | 
|  |\   | |  |____ |  |\  \----.|  '--'  |.----)   |   |__| 
|__| \__| |_______|| _| `._____||_______/ |_______/    (__) 
                                                            
";
            Console.WriteLine(magicNerd);
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Dark Wizard", 4, 2);
        }

        public static void SkeletonEncounter()
        {
            Console.Clear();
            Print("Thou passes by a crypt and hear sound that reminds ye of thou's NaNa getting up from her chair...");
            Print("The creaking of bone becomes more rapid as thou sees a skeleton charging towards you!");
            Console.ReadKey();
            Console.Clear();
            string skeletonWarrior = @"
                  .7
                .'/
               / /
              / /
             / /
            / /
           / /
          / /
         / /         
        / /          
      __|/
    ,-\__\
    |f- Y\|
    \()7L /
     cgD                            __ _
     |\(                          .'  Y ' >,
      \ \                        / _   _   \
       \\\                       )(_)(_)    )
        \\\                      {  4A     /
         \\\                      \uLuJJ/\l
          \\\                     |3    p)/
           \\\___ __________      /nnm_n /
           c7___-__,__-)\,__)(.  \_>-<_/D
                      /V     \_-._.__G G_c__.-_/ ( \
                             </-._>__-,G_.___)\   \7\
                            (\-.__.| \|<.__.-/ )   \ \
                            |\-.__||  ||-.__.--)   \ \
                            (\-.__||  |-.__.--)     \_\
                            \\-.__||  ||-.__.-)     \ \
                             \-.__||  ||-.__.)      \ l

";
            Console.WriteLine(skeletonWarrior);
            Print("SCREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEECH!");
            Console.ReadKey();
            Console.Clear();
            Print("Hey buddy...");
            Console.ReadKey();
            string magicNerd = @"
.___                  __             ___.                            __          
|   |    ____   _____/  |_  _____    \_ |__   ____   ____   ____   _/  |_  ____  
|   |   / ___\ /  _ \   __\ \__  \    | __ \ /  _ \ /    \_/ __ \  \   __\/  _ \ 
|   |  / /_/  >  <_> )  |    / __ \_  | \_\ (  <_> )   |  \  ___/   |  | (  <_> )
|___|  \___  / \____/|__|   (____  /  |___  /\____/|___|  /\___  >  |__|  \____/ 
      /_____/                    \/       \/            \/     \/                
            .__        __             .__  __  .__                          ._.  
     ______ |__| ____ |  | __ __  _  _|__|/  |_|  |__    ___.__. ____  __ __| |  
     \____ \|  |/ ___\|  |/ / \ \/ \/ /  \   __\  |  \  <   |  |/  _ \|  |  \ |  
     |  |_> >  \  \___|    <   \     /|  ||  | |   Y  \  \___  (  <_> )  |  /\|  
     |   __/|__|\___  >__|_ \   \/\_/ |__||__| |___|  /  / ____|\____/|____/ __  
     |__|           \/     \/                       \/   \/                  \/ 
                                                            
";
            Console.WriteLine(magicNerd);
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Spooky Skeleton", 4, 2);
        }

        public static void GargoyleEncounter()
        {
            Console.Clear();
            Print("A small statue in this chamber starts to cracking a smile at thee...");
            Print("You think nothing of it...wait...");
            Console.ReadKey();
            Console.Clear();
            Print("STATUES DON'T SMILE!!!");
            Console.ReadKey();
            Console.Clear();
            string gargoyle = @"
 ,                                                               ,
 \'.                                                           .'/
  ),\                                                         /,( 
 /__\'.                                                     .'/__\
 \  `'.'-.__                                           __.-'.'`  /
  `)   `'-. \                                         / .-'`   ('
  /   _.--'\ '.          ,               ,          .' /'--._   \
  |-'`      '. '-.__    / \             / \    __.-' .'      `'-|
  \         _.`'-.,_'-.|/\ \    _,_    / /\|.-'_,.-'`._         /
   `\    .-'       /'-.|| \ |.-'   '-.| / ||.-'\       '-.    /`
     )-'`        .'   :||  / -.\\ //.- \  ||:   '.        `'-(
    /          .'    / \\_ |  /o`^'o\  | _// \    '.          \
    \       .-'    .'   `--|  `'/ \'`  |--`   '.    '-.       /
     `)  _.'     .'.--.;     |\__'__/| ; .--.    '.     '._  ('
     / _.'     .-'  _.- '   \\ \/^\/ //     `-._  ' -.     '._\
     \     .'`_.--'          \\     //          `--._`'.     /
      '-._' /`            _   \\-.-//   _            `\ '_.-'
          `< _,..--''`    |    \`'`/    |`''--..,_     >`
           _\  ``--..__   \     `'`     /   __..--``  /_
    
";
            Console.WriteLine(gargoyle);
            Print("PREPARE TO STONED ADVENTURER!!!");
            Console.ReadKey();
            Console.Clear();
            Print("Wait...was that a joke?");
            Console.ReadKey();
            string hilarious = @"
______                                 _____ _           _   _     
| ___ \                               |_   _| |         | | ( )    
| |_/ / ___  ___ __ _ _   _ ___  ___    | | | |__   __ _| |_|/ ___ 
| ___ \/ _ \/ __/ _` | | | / __|/ _ \   | | | '_ \ / _` | __| / __|
| |_/ /  __/ (_| (_| | |_| \__ \  __/   | | | | | | (_| | |_  \__ \
\____/ \___|\___\__,_|\__,_|___/\___|   \_/ |_| |_|\__,_|\__| |___/
                                                                   
                                                                   
 _   _ _____ _       ___  ______ _____ _____ _   _ _____ _ _ _     
| | | |_   _| |     / _ \ | ___ \_   _|  _  | | | /  ___| | | |    
| |_| | | | | |    / /_\ \| |_/ / | | | | | | | | \ `--.| | | |    
|  _  | | | | |    |  _  ||    /  | | | | | | | | |`--. \ | | |    
| | | |_| |_| |____| | | || |\ \ _| |_\ \_/ / |_| /\__/ /_|_|_|    
\_| |_/\___/\_____/\_| |_/\_| \_|\___/ \___/ \___/\____/(_|_|_)
                                                          
";
            Console.WriteLine(hilarious);
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Goofy Gargoyle", 3, 3);
        }

        public static void MinotaurEncounter()
        {
            Console.Clear();
            Print("As ye approaches the corner you hear clipping and clopping in the distance...");
            Print("Upon rounding the corner the hair on the back ye neck stands up as...");
            Console.ReadKey();
            Console.Clear();
            Print("THE CLOPPING INTENSIFIES!");
            Console.ReadKey();
            Console.Clear();
            string minotaur = @"
         ,     .
        /(     )\               A
   .--.( `.___.' ).--.         /_\
   `._ ` \&%#%$/ ' _.'     /| <___> |\
      `|(@\*%%/@)|'       / (  |L|  ) \
       |  |%%#|  |       J d8bo|=|od8b L
        \ \$#%/ /        | 8888|=|8888 |
        |\|%%#|/|        J Y8P |=| Y8P F
        | (. .)%|         \ (  |L|  ) /
    ___.'  `-'  `.___      \|  | |  |/
  .'#*#`-       -'$#*`.       / )|
 /#%^#%*_ *%^%_  #  %$%\    .J (__)
 #&  . %%%#% ###%*.   *%\.-'&# (__)
 % *J %.%#_|_#$.\J* \ %'#%*^   (__)
 *#% J %$%%#|#$#$ J\%   *   .--|(_)
 |% J\ `%%#|#%%' / `.   _.'    |L|
 |#$%||` %%%$### '|   `-'      |L|
 (#%%||` #$#$%%% '|            |L|
 | ##||  $%%.%$%  |            |L|
    
";
            Console.WriteLine(minotaur);
            Print("Are you lost?");
            Console.ReadKey();
            Console.Clear();
            Print("Because I sure as heck am!");
            Console.ReadKey();
            string beef = @"
 __      __           ________        __    __________               _____ 
/  \    /  \ ____    /  _____/  _____/  |_  \______   \ ____   _____/ ____\
\   \/\/   // __ \  /   \  ___ /  _ \   __\  |    |  _// __ \_/ __ \   __\ 
 \        /\  ___/  \    \_\  (  <_> )  |    |    |   \  ___/\  ___/|  |   
  \__/\  /  \___  >  \______  /\____/|__|    |______  /\___  >\___  >__|   
       \/       \/          \/                      \/     \/     \/     
                                                          
";
            Console.WriteLine(beef);
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Manly Minotaur", 3, 4);
        }

        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    WizardEncounter();
                    break;
                case 1:
                    SkeletonEncounter();
                    break;
                case 2:
                    GargoyleEncounter();
                    break;
                case 3:
                    MinotaurEncounter();
                    break;
            }
        }
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                
                p = Program.currentPlayer.getPower();
                h = Program.currentPlayer.getHealth();
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                string swordArt = @"
               ,
              (@|
 ,,           ,)|_____________________________________
//\\8@8@8@8@8@8 / _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ \
\\//8@8@8@8@8@8 \_____________________________________/
 ``           `)|
              (@| 
               `
";
                Console.WriteLine(swordArt);
                Console.WriteLine(n);
                Console.WriteLine("Enemy Power: " + p + " | Enemy Health: " + h);
                Console.WriteLine("***************************************");
                Console.WriteLine("||         [A]ttack [D]efend         ||");
                Console.WriteLine("||         [R]un    [H]eal           ||");
                Console.WriteLine("***************************************");
                Console.WriteLine(" Potions: "+ Program.currentPlayer.potion +" Health: "+Program.currentPlayer.health);
                string input = Console.ReadLine();
                if(input.ToLower() == "a"||input.ToLower() =="attack")
                {
                    //Attack
                    Console.WriteLine("Thy muscles glisten as thou bringth down wrath upon thy enemy! Egads! The "+n+" counter attacks!");
                    int damage = p - Program.currentPlayer.armorClass;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1,4);
                    Console.WriteLine("Thou loses " + damage + " health, but thine blade inflicted " + attack + " damage upon thy enemy!");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("Thou braces thyself for impact! The " + n + " lunges forth!");
                    int damage = (p/4) - Program.currentPlayer.armorClass;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue)/2;
                    Console.WriteLine("Thou loses " + damage + " health, but thine blade inflicted " + attack + " damage upon thy enemy!");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As thou cowardly flees the "+n+" trips thou...boy that was embarassing.");
                        int damage = p - Program.currentPlayer.armorClass;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("Thou loses " + damage + " health and looked really dumb while losing it!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Thou art nimble! Thou art quick! Thou jumped over the " + n + "!");
                        Console.ReadKey();
                        Shop.LoadShop(Program.currentPlayer);
                    
                    }
                    
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("Thou reachth for a magical cold one, thou comes up wanting as they are all empty!");
                        int damage = p - Program.currentPlayer.armorClass;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + " punishes thou for thine lack of awareness and cold ones! Dealing " + damage + " damage!");

                    }
                    else
                    {
                        Console.WriteLine("Thou cheeks swellth with an infusion of healing cold one!");
                        int potionValue = 5;
                        Console.WriteLine("Thou recovers " + potionValue + " health!");
                        Program.currentPlayer.health += potionValue;
                        Console.WriteLine("As thou guzzled the tincture, the " + n + " strikes you!");
                        int damage = (p / 2) - Program.currentPlayer.armorClass;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health!");
                        Program.currentPlayer.potion -= 1;
                    }
                    Console.ReadKey();
                }
                if (Program.currentPlayer.health <= 0)
                {
                    //Death Code
                    Console.WriteLine("The " + n + " was too much for thou to handle. Thou art dead! Good job!");
                    Console.WriteLine("GAME OVER");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            int c = Program.currentPlayer.getCoins();
            Console.WriteLine("Thou stands over the corpse of the " + n + " golden coins spurt forth from the mortal wound thou inflicted upon it! Thou gathers "+c+" bloody coins");
            Program.currentPlayer.coins += c;
            Console.ReadKey();
        }


        public static void Print(string text, int speed = 40)
        {
           
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

    }
}
