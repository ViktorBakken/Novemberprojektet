using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FightSim
{
    class Methods
    {

        //Begining
        public void NameYourFighter(Fighters fighter)
        {
            Console.Clear();
            Klasser.WriteLine("Name your fighter!", true);
            Klasser.Write("Name: ", true);
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
                Klasser.WriteLine("\nFighter 3: \nHp: Low\nDamage: High\nHitchance: High\n", true);
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

        public void AnitiateFight(Fighters player, Fighters enemy)
        {
            int whoWillStart;
            bool playerStartFight;

            Console.Clear();
            Klasser.WriteLine("The fight will now commense! Todays fight is between " + player.Name + " versus " + enemy.Name + ".\n", true);

            whoWillStart = Klasser.RandInt(0, 1);

            if (whoWillStart == 0)
            {
                playerStartFight = true;
                Klasser.WriteLine(player.Name + " will start the fight.\n\n(*Enter*)", false);
            }
            else
            {
                playerStartFight = false;
                Klasser.WriteLine(enemy.Name + " will start the fight.\n\n(*Enter*)", false);
            }

            Fight(playerStartFight, player, enemy);
        }



        //Fighting
        public void Fight(bool playerStartFight, Fighters player, Fighters enemy)
        {
            while (player.IsDefeated == false && enemy.IsDefeated == false)
            {
                if (playerStartFight == true)
                {
                    FightMenues(player, enemy, true);
                }

                FightMenues(player, enemy, false);
                playerStartFight = true;
            }

            bool playerWon = false;

            if (player.IsDefeated == false)
            {
                playerWon = true;
            }
            else
            {
                playerWon = false;
            }


            End(playerWon);
        }

        public void FightMenues(Fighters player, Fighters enemy, bool isPlayer)
        {
            if (isPlayer == true)
            {
                Console.Clear();
                Klasser.WriteLine("Name: " + player.PrintNameOrHealth(true) + "\nHp: " + player.PrintNameOrHealth(false) + "\nWhat do you want to do? \n1. Fight\n2. Check Status", true);
                string[] answears = { "1", "2", "fight", "check staus", "checkstatus" };

                string answear = Klasser.ChoiseCorrect(answears);

                Console.Clear();

                if (answear == answears[0] || answear == answears[2])
                {
                    DealDamage(player, enemy, true);
                }

                if (answear == answears[1] || answear == answears[3] || answear == answears[4])
                {
                    player.PrintStats();
                    FightMenues(player, enemy, true);
                }
            }
            else
            {
                DealDamage(player, enemy, false);
            }
        }

        public void DealDamage(Fighters player, Fighters enemy, bool playerBool)
        {
            string[] attacks = { "hook", "straight", "death stare", "roundhouse kick", "DDT" };
            string[] hit = { "stomach", "knee", "shoulder", "liver", "Hand", "feet" };
            bool playerHit = player.HitOrMiss();
            bool enemyHit = enemy.HitOrMiss();

            Thread.Sleep(200);

            if (playerHit == true && playerBool == true)
            {
                int damage = player.Damage;

                Klasser.WriteLine(player.Name + " hit a " + Klasser.RandString(attacks) + " on " + enemy.Name + "'s " + Klasser.RandString(hit) + " and dealt " + damage + " damage" + "\n\n(*Enter*)", false);

                enemy.Hp -= damage;
            }

            if (playerHit == false && playerBool == true)
            {
                Klasser.WriteLine(player.Name + " missed his attack", false);
            }

            if (enemyHit == true && playerBool == false)
            {
                int damage = enemy.Damage;

                Klasser.WriteLine(enemy.Name + " hit a " + Klasser.RandString(attacks) + " on " + player.Name + "'s " + Klasser.RandString(hit) + " and dealt " + damage + " damage" + "\n\n(*Enter*)", false);

                player.Hp -= damage;
            }

            if (enemyHit == false && playerBool == false)
            {
                Klasser.WriteLine(enemy.Name + " missed the attack", false);
            }

            Console.Clear();
        }

        public void End(bool playerWon)
        {
            if (playerWon == true)
            {
                Klasser.WriteLine("Better luck next time!", true);
            }
            else
            {
                Klasser.WriteLine("Perfekt round!", true);
            }

            Klasser.WriteLine("Would you like to play again? \n\n (Yes/No)", true);

            string[] answears = { "yes", "no" };

            string answear = Klasser.ChoiseCorrect(answears);

            if (answear == "yes")
            {
                Klasser.restartGame = true;
            }
        }
    }
}
