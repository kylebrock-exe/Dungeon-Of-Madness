using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfMadness
{
    public class Player
    {
        Random rand = new Random();

        public string name;
        public int coins = 3330;
        public int health = 10;
        public int damage = 1;
        public int armorClass = 0;
        public int potion = 5;
        public int weaponValue = 1;

        public int mods = 0;

        public int getHealth()
        {
            int upper = (2 * mods + 5);
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }

        public int getPower()
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }

        public int getCoins()
        {
            int upper = (15 * mods + 50);
            int lower = (10 * mods + 10);
            return rand.Next(lower, upper);
        }
    }
}
