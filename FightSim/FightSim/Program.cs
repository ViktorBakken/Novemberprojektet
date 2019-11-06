using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighters player = PresentFighterKlass(false); // The player gets to choose a fighter 
            Fighters enemy = PresentFighterKlass(true); // The game randomises a fighter

            NameYourFighter(player);

            FightMenues(player);
        }
        static void FightMenues(Fighters player)
        {
            Console.Clear();
            Klasser.WriteLine("Name: " + player.PrintNameOrHealth(true) + "\nHp: " + player.PrintNameOrHealth(false) + "\nWhat do you want to do? \n1. Fight\n2. Check Status", true);
            string[] answears = { "1", "2", "fight", "check staus" };

            string answear = Klasser.ChoiseCorrect(answears);

            Console.Clear();

            if (answear == answears[0] || answear == answears[2])
            {

            }

            if (answear == answears[1] || answear == answears[3])
            {
                player.PrintStats();
                FightMenues(player);
            }
        }

        static void NameYourFighter(Fighters fighter)
        {
            Console.Clear();
            Klasser.WriteLine("Name your fighter!\n", true);

            string newName = Console.ReadLine();

            fighter.NameFighter(newName);
        }

        static Fighters PresentFighterKlass(bool fiende)
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

        static Fighters chooseFighter(bool fiende)
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

        static string RandomiseChoise()
        {
            int i = Klasser.RandInt(1, 3);

            string rand = "" + i;

            return rand;
        }

        static void AnitiateFight()
        {

        }

    }
}
