using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Methods
    {
        public void FightMenues(Fighters player, Fighters enemy)
        {
            Console.Clear();
            Klasser.WriteLine("Name: " + player.PrintNameOrHealth(true) + "\nHp: " + player.PrintNameOrHealth(false) + "\nWhat do you want to do? \n1. Fight\n2. Check Status", true);
            string[] answears = { "1", "2", "fight", "check staus" };

            string answear = Klasser.ChoiseCorrect(answears);

            Console.Clear();

            if (answear == answears[0] || answear == answears[2])
            {
                DealDamage(player, enemy);
            }

            if (answear == answears[1] || answear == answears[3])
            {
                player.PrintStats();
                FightMenues(player, enemy);
            }
        }

        public void NameYourFighter(Fighters fighter)
        {
            Console.Clear();
            Klasser.WriteLine("Name your fighter!\n", true);

            string newName = Console.ReadLine();

            fighter.Name = newName;
        }

        public Fighters PresentFighterKlass(bool fiende)
        {
            if (fiende == false)
            {
                Console.Clear();
                Console.WriteLine("Choose a fighter klass");

                Klasser.WriteLine("\nFighter 1: \nHp: High\nDamage: Medium\nHitchance: Low", true);
                Klasser.WriteLine("\nFighter 2: \nHp: Medium\nDamage: Medium\nHitchance: Medium", true);
                Klasser.WriteLine("\nFighter 3: \nHp: Low\nDamage: High\nHitchance: High", true);
                Klasser.Write("Choose fighter:", true);
            }

            return chooseFighter(fiende);
        }

        public Fighters chooseFighter(bool fiende)
        {
            string[] answears = { "1", "2", "3", "fighter 1", "fighter 2", "fighter 3" };
            string choice;
            Fighters fighter = new Fighters();

            if (fiende == false)
            {
                choice = Klasser.ChoiseCorrect(answears);
            }
            else
            {
                choice = RandomiseChoise();
            }

            if (choice == "fighter 1" || choice == "1")
            {
                fighter = new Fighter_1();
            }

            if (choice == "fighter 2" || choice == "2")
            {
                fighter = new Fighter_2();
            }

            if (choice == "fighter 3" || choice == "3")
            {
                fighter = new Fighter_3();
            }

            return fighter;
        }

        public string RandomiseChoise()
        {
            int i = Klasser.RandInt(1, 3);

            string rand = "" + i;

            return rand;
        }

        public void DealDamage(Fighters player, Fighters enemy, bool playerBool)
        {
            if(player.HitOrMiss() == true && playerBool == true)
            {
                int damage = player.Damage;

                enemy.Hp -= damage;
            }

            if (true)
            {

            }


        }

        public void AnitiateFight(Fighters player, Fighters enemy)
        {
            int whoWillStart;
            bool playerStartFight;

            Console.Clear();
            Klasser.WriteLine("The fight will now commense! Todays fight is between " + player.Name + " versus " + enemy.Name + ".\n\n", true);

            whoWillStart = Klasser.RandInt(0, 1);

            if (whoWillStart == 0)
            {
                playerStartFight = true;
            }
            else
            {
                playerStartFight = false;
            }

            Fight(playerStartFight, player, enemy);
        }

        public void Fight(bool playerStartFight, Fighters player, Fighters enemy)
        {
            if (playerStartFight == true)
            {
                FightMenues(player, enemy);
            }

        }
    }
}
