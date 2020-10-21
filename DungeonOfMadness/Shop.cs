using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfMadness
{
    public class Shop
    {
        public static void LoadShop(Player p)
        {
            Console.Clear();
            string shopKeep = @"

_____________________________________________                                          
||                   _                     ||      
||                .'` `'.                  ||
||               /    ,-.\                 || 
||              /    /:::\\               /||          
||              |    |:::||              |/||                
||              |    |:::||             //'||                    
||              |    |:::||            //  ||                      
||              /    |:::|/        _,-//\  ||
||             /`    |:::|`-,__,-'`  |/  \ ||
||           /`  |   |'' ||           \   |||
||         /`    \   |   ||            |  /||
||       |`       |  |   |)            \ | ||
||      |          \ |   /      ,.__    \| ||
||      /           `         /`    `\   | ||
";
            Console.WriteLine(shopKeep);
            Console.WriteLine("Welcome! I've got alot of good things on sale...stranger.");
            Console.ReadKey();
            Console.Clear();
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int difP;

            while (true)
            {
                potionP = 20 + 10 * p.mods;
                armorP = 100 * (p.armorClass + 1);
                weaponP = 100 * p.weaponValue;
                difP = 300 + 100 * p.mods;
                Console.Clear();
                Console.WriteLine("          Shop           ");
                Console.WriteLine("****************************");
                Console.WriteLine("|   [P]otion    :       "+ potionP);
                Console.WriteLine("|   [A]rmor     :       "+ armorP);
                Console.WriteLine("|   [W]eapon    :       "+ weaponP);
                Console.WriteLine("|   [D]ifficulty:       "+ difP);
                Console.WriteLine("****************************");
                Console.WriteLine("     [E]xit The Shop     ");
                Console.WriteLine("  [Q]uit/Save The Game   ");
                Console.WriteLine();
                Console.WriteLine(p.name+"'s Stats           ");
                Console.WriteLine("****************************");
                Console.WriteLine("|   Coin    :         " + p.coins);
                Console.WriteLine("|   Health    :       " + p.health);
                Console.WriteLine("|   Armor     :       " + p.armorClass);
                Console.WriteLine("|   Weapon    :       " + p.weaponValue);
                Console.WriteLine("|   Potions   :       " + p.potion);
                Console.WriteLine("|   Difficulty:       " + p.mods);
                Console.WriteLine("****************************");



                string input = Console.ReadLine().ToLower();
                if (input == "p" || input == "potion")
                {
                    tryBuy("potion", potionP, p);
                }
                else if (input == "a" || input == "armor")
                {
                    tryBuy("armor", armorP, p);
                }
                else if (input == "w" || input == "weapon")
                {
                    tryBuy("weapon", weaponP, p);
                }
                else if (input == "d" || input == "difficulty")
                {
                    tryBuy("dif", difP, p);
                }
                else if (input == "e" || input == "exit")
                {
                    break;
                }
                else if (input == "q" || input == "quit")
                {
                    Program.Quit();
                }
            }
        }
        static void tryBuy(string item, int cost, Player p)
        {
            if (p.coins >= cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "armor")
                    p.armorClass++;
                else if (item == "weapon")
                    p.weaponValue++;
                else if (item == "dif")
                    p.mods++;

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("Not enough gold...stranger.");
                Console.ReadKey();
            }

        }
    }
}
