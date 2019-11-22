using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighters //This is a template
    {
        private string[] enemyNames = { "Apollo Creed", "Rocky Balboa", "Adonis Johnson", "Life of Boris", "Cousin Anatoli", "Vadim", "Felix Kjellberg", "Marzia Kjellberg", "Call Me Carson", "HartVigen", "Hugo Wiman", "Anton Jansson", "Martin Nyberg" }; //Names for the enemy
        protected string name; //The name
        protected int maxHp = 20; //The potential max health points that this character can get
        protected int minHp = 15; //The potential min health points that this character can get
        protected int hp; //This will be the official health points the charakter will get
        protected int maxDamage = 6; //The potential max damage that this character can get
        protected int minDamage = 3; //The potential min damage that this character can get
        protected int maxHitChance = 5; //the potential max hit chance that this character can get
        protected int minHitChance = 3; //the potential max hit chance that this character can get
        protected int hitChance; //This will be the official hit chance charakter will get 
        private bool defeated; //A bool to se if the character is defeated;

        public Fighters() //When this class is instantiated a name will be randomed
        {
            name = Klasser.RandString(enemyNames);
        } //When this class is instantiated a name will be randomed

        public int Hp //A variable to see the health points or change the health points
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
        } //A variable to see the health points or change the health points

        public int Damage //A variable to see the damage
        {
            get
            {
                int damage = Klasser.RandInt(minDamage, maxDamage);

                return damage;
            }
        } //A variable to see the damage

        public string Name //A variable to see the character name or change it
        {
            get
            {
                return name;
            }

            set
            {
                string[] wrongAnswear = { "" };
                string newName = Klasser.ChoiseIsNot(wrongAnswear, value);

                name = newName;
            }
        } //A variable to see the character name or change it

        public bool IsDefeated //A variable to see the if the character is defeated
        {
            get
            {
                if (hp <= 0)
                {
                    defeated = true;
                }
                return defeated;
            }
        } //A variable to see the if the character is defeated

        public bool HitOrMiss() //This block of code checks if the character missesor hit a attack
        {
            bool hit = false;
            int hitValueLimiter = Klasser.RandInt(10, 20);
            int hitValRand = Klasser.RandInt(3, 7);

            int hitVal = hitValRand * hitChance;

            if (hitVal > hitValueLimiter)
            {
                hit = true;
            }

            return hit;
        } //This block of code checks if the character missesor hit a attack

        public void PrintStats() //Prints the stats 
        {
            Console.Clear();
            Klasser.WriteLine("Name: " + name + "\nHP: " + hp + "\nHit Chance: " + hitChance + "\nMax Damage: " + maxDamage + "\nMin Damage: " + minDamage + "\n \n(*Enter*)\n", false);

            return;
        } //Prints the stats 
    }
}
