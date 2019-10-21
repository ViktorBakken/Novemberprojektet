using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighters
    {
        protected string name;
        protected int maxHp = 10;
        protected int minHp = 5;
        protected int hp;
        protected int maxDamage = 5;
        protected int minDamage = 1;
        protected int maxHitChance = 5;
        protected int minHitChance = 1;
        protected int hitChance;

        public void PrintStats()
        {
            Console.WriteLine("Name: " + name + "\nHP: " + hp + "\nHit Chance: "+ hitChance + "\nMax Damage: " + maxDamage + "\nMinDamage" + minDamage);
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
