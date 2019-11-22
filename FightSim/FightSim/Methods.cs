using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FightSim
{
    class Methods
    {
        //Preperations
        public void NameYourFighter(Fighters fighter) //This code block is for allowing the player rename their character
        {
            Console.Clear();
            Klasser.WriteLine("Name your fighter!", true);
            Klasser.Write("Name: ", true);
            string newName = Console.ReadLine();

            fighter.Name = newName;
        } //This code block is for allowing the player rename their character

        public Fighters PresentFighterKlass(bool player) //This code block presents the three different fighter klass  
        {
            if (player == false)
            {
                Console.Clear();
                Console.WriteLine("Choose a fighter klass");

                Klasser.WriteLine("\nFighter 1: \nHp: High\nDamage: Medium\nHitchance: Low", true);
                Klasser.WriteLine("\nFighter 2: \nHp: Medium\nDamage: Medium\nHitchance: Medium", true);
                Klasser.WriteLine("\nFighter 3: \nHp: Low\nDamage: High\nHitchance: High\n", true);
                Klasser.Write("Choose fighter: ", true);
            }

            return chooseFighter(player);
        } //This code block presents the three different fighter klass  

        public Fighters chooseFighter(bool player) //This code block lets the player choose one of the three fighterklasses
        {
            string[] answears = { "1", "2", "3", "fighter 1", "fighter1", "fighter 2", "fighter2", "fighter 3", "fighter3" };
            string choice;
            Fighters fighter = new Fighters();

            if (player == false)
            {
                choice = Klasser.ChoiseCorrect(answears);
            }
            else
            {
                choice = RandomiseChoise();
            }

            if (choice == "fighter 1" || choice == "fighter1" || choice == "1")
            {
                fighter = new Fighter_1();
            }

            if (choice == "fighter 2" || choice == "fighter2" || choice == "2")
            {
                fighter = new Fighter_2();
            }

            if (choice == "fighter 3" || choice == "fighter3" || choice == "3")
            {
                fighter = new Fighter_3();
            }

            return fighter;
        } //This code block lets the player choose one of the three fighterklasses

        public string RandomiseChoise() //Randomise a number between 1-3 and convert it to a string
        {
            int i = Klasser.RandInt(1, 3);

            string rand = "" + i;

            return rand;
        } //Randomise a number between 1-3 and convert it to a string

        public void AnitiateFight(Fighters player, Fighters enemy) //This code block is for Anitiating the fight by randomise if the playeer or the enemy start the fight 
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
        } //This code block is for Anitiating the fight by randomise if the playeer or the enemy start the fight 



        //Fighting
        public void Fight(bool playerStartFight, Fighters player, Fighters enemy)  //This is the processor of the fight. It says which characters turn it is and after the fight the block says who won the fight
        {
            while (player.IsDefeated == false && enemy.IsDefeated == false) //The fight will continue untill one character faint
            {
                if (playerStartFight == true)
                {
                    FightMenues(player, enemy, true);
                }

                FightMenues(player, enemy, false);
                playerStartFight = true;
            }


            //After the fight

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
        } //This is the processor of the fight. It says which characters turn it is and after the fight the block says who won the fight

        public void FightMenues(Fighters player, Fighters enemy, bool isPlayer) //For the player this code block lets the player choose if they want to check their stats or attack
        {
            if (isPlayer == true)
            {
                Console.Clear();
                Klasser.WriteLine("Name: " + player.Name + "\nHp: " + player.Name + "\nEnemy Hp: " + enemy.Hp + "\n\nWhat do you want to do? \n1. Fight\n2. Check Status", true);
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
        } //For the player this code block lets the player choose if they want to check their stats or attack

        public void DealDamage(Fighters player, Fighters enemy, bool playerBool) //This code block is for dealing dammage between the player and the enemy. It randomise if the attack will hit or not. If it hit it randomises what kind of attack it was and where it hit.
        {
            Console.Clear();
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
                Klasser.WriteLine(player.Name + " missed his attack\n\n(*Enter *)", false);
            }

            if (enemyHit == true && playerBool == false)
            {
                int damage = enemy.Damage;

                Klasser.WriteLine(enemy.Name + " hit a " + Klasser.RandString(attacks) + " on " + player.Name + "'s " + Klasser.RandString(hit) + " and dealt " + damage + " damage\n\n(*Enter*)", false);

                player.Hp -= damage;
            }

            if (enemyHit == false && playerBool == false)
            {
                Klasser.WriteLine(enemy.Name + " missed the attack\n\n(*Enter *)", false);
            }
        } //This code block is for dealing dammage between the player and the enemy. It randomise if the attack will hit or not. If it hit it randomises what kind of attack it was and where it hit.

        public void End(bool playerWon) //This code block resolvs the "after fight" and let the player choose if they want to restart the game
        {
            Console.Clear();

            if (playerWon == true)
            {
                Klasser.WriteLine("Perfekt round!", true);
            }
            else
            {
                Klasser.WriteLine("Better luck next time!", true);
            }

            Klasser.WriteLine("Would you like to play again? \n\n (Yes/No)", true);

            string[] answears = { "yes", "no" };

            string answear = Klasser.ChoiseCorrect(answears);

            if (answear == "yes")
            {
                Klasser.restartGame = true;
            }
        } //This code block resolvs the "after fight" and let the player choose if they want to restart the game
    }
}