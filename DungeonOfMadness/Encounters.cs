using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfMadness
{
    public class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic


        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("Standing before thou is greasy morbidly obese Lizard Man!");
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
            Console.WriteLine("Unthinking, thou grabs a conviently placed rusty sword and charge the bloated reptile!");
            Console.ReadKey();
            Combat(false, "Obese Lizard Man", 1, 4);
        }
        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("Turning the corner thou spots a monstrosity heading thou's way!");
            Console.ReadKey();
            Combat(true,"",0,0);

        }
        public static void WizardEncounter()
        {
            Console.Clear();
            Console.WriteLine("As thou opens the door thou hears a crackling of arcane energy as a demented old man appears before thou!");
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
            Console.WriteLine("Thou dare interrupts my studies!? Have thee no respect for the ARCANE ARTS!?");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("No, I don't because...");
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


        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 2))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    WizardEncounter();
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
                n = GetName();
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
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("*************************");
                Console.WriteLine("|   [A]ttack [D]efend   |");
                Console.WriteLine("|   [R]un    [H]eal     |");
                Console.WriteLine("*************************");
                Console.WriteLine(" Potions: "+Program.currentPlayer.potion+" Health: "+Program.currentPlayer.health);
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

        public static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Goopy Skeleton";
                    
                case 1:
                    return "Obese Lizard Man";
                    
                case 2:
                    return "Rancid Zombie";
                   
                case 3:
                    return "Smelly Cultist";
                    
            }
            return "Gassy Gnome";
        }
    }
}
