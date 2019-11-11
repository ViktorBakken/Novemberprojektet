﻿using System;
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
            Klasser.WriteLine("Name: " + name + "\nHP: " + hp + "\nHit Chance: " + hitChance + "\nMax Damage: " + maxDamage + "\nMin Damage: " + minDamage + "\n \n(press enter)\n", false);

            return;
        }
    }
}
