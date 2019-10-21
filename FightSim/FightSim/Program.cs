﻿using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentFighterKlass(false);

        }
        static void PresentFighterKlass(bool fiende)
        {
            if (fiende == false)
            {
                Console.Clear();
                Console.WriteLine("Choose a fighter klass");

                Klasser.WriteLine("Fighter 1: \nHp: High\nDamage: Medium\nHitchance: Low", false);
                Klasser.WriteLine("Fighter 2: \nHp: Medium\nDamage: Medium\nHitchance: Medium", false);
                Klasser.WriteLine("Fighter 3: \nHp: Low\nDamage: High\nHitchance: High", false);
            }
            chooseFighter(fiende);
        }

        static string chooseFighter(bool fiende)
        {
            string choice;
            bool failsafe = false;

            if (fiende == false)
            {
                choice = Console.ReadLine().Trim().ToLower();
            }
            else
            {
                choice = RandomiseChoise();
            }
            while (failsafe == false)
            {
                if (choice == "fighter1" || choice == "1")
                {
                    Fighter_1 player = new Fighter_1();
                    break;
                }

                if (choice == "fighter2" || choice == "2")
                {
                    Fighter_2 player = new Fighter_2();
                    break;
                }

                if (choice == "fighter3" || choice == "3")
                {
                    Fighter_3 player = new Fighter_3();
                    break;
                }

                choice = Console.ReadLine().Trim().ToLower();
            }



            return choice;
        }

        static string RandomiseChoise()
        {
            int i = Klasser.RandInt(1, 3);

            string rand = "" + i;

            return rand;
        }
    }
}
