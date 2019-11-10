using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighters //Detta blir en mall för de andra klasserna
    {
        private string[] enemyNames = { "Apollo Creed", "Rocky Balboa", "Adonis Johnson", "Life of Boris", "Cousin Anatoli", "Vadim", "Felix Kjellberg", "Marzia Kjellberg", "Call Me Carson", "HartVigen", "Hugo Wiman", "Anton Jansson", "Martin Nyberg" };
        protected string name;
        protected int maxHp = 10;
        protected int minHp = 5;
        protected int hp;
        protected int maxDamage = 5;
        protected int minDamage = 1;
        protected int maxHitChance = 5;
        protected int minHitChance = 1;
        protected int hitChance;

        public Fighters()
        {
            name = Klasser.RandString(enemyNames);
        }
        public void NameFighter(string newName)
        {
            name = newName;
        }

        public string PrintNameOrHealth(bool Name)
        {
            string retVal;

            if (Name == true)
            {
                retVal = name;
            }
            else
            {
                retVal = hp.ToString();
            }

            return retVal;

        }

        public void PrintStats()
        {
            Klasser.WriteLine("Name: " + name + "\nHP: " + hp + "\nHit Chance: " + hitChance + "\nMax Damage: " + maxDamage + "\nMin Damage: " + minDamage + "\n \n(press enter)\n", false);

            return;
        }

        public void TakeDamage(int amount)
        {
            hp -= amount;
        }

        public int DealDamage()
        {
            int damage = Klasser.RandInt(minDamage, maxDamage);

            return damage;
        }
    }
}
