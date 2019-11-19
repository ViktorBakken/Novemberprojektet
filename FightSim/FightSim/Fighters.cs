using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighters //Detta blir en mall för de andra klasserna
    {
        private string[] enemyNames = { "Apollo Creed", "Rocky Balboa", "Adonis Johnson", "Life of Boris", "Cousin Anatoli", "Vadim", "Felix Kjellberg", "Marzia Kjellberg", "Call Me Carson", "HartVigen", "Hugo Wiman", "Anton Jansson", "Martin Nyberg" };
        protected string name;
        protected int maxHp = 20;
        protected int minHp = 15;
        protected int hp;
        protected int maxDamage = 6;
        protected int minDamage = 3;
        protected int maxHitChance = 5;
        protected int minHitChance = 3;
        protected int hitChance;
        private bool defeated;

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                if (hp >= 0)
                {
                    hp = value;
                }
                else
                {
                    defeated = true;
                }
            }
        }

        public int Damage
        {
            get
            {
                int damage = Klasser.RandInt(minDamage, maxDamage);

                return damage;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool IsDefeated
        {
            get
            {
                return defeated;
            }
        }

        public bool HitOrMiss()
        {
            bool hit = false;
            int hitValueLimiter = Klasser.RandInt(1, 50);
            int hitValRand = Klasser.RandInt(1, 10);

            int hitVal = hitValRand * hitChance;

            if (hitVal > hitValueLimiter)
            {
                hit = true;
            }

            return hit;
        }

        public Fighters()
        {
            name = Klasser.RandString(enemyNames);
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
            Console.Clear();
            Klasser.WriteLine("Name: " + name + "\nHP: " + hp + "\nHit Chance: " + hitChance + "\nMax Damage: " + maxDamage + "\nMin Damage: " + minDamage + "\n \n(*Enter*)\n", false);

            return;
        }
    }
}
