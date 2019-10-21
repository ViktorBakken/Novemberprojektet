using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentFighterKlass();
            
        }
        static string PresentFighterKlass()
        {
            Console.Clear();
            Console.WriteLine("Choose a fighter klass");

            Klasser.WriteLine("Fighter 1: \nHp: High\nDamage: Medium\nHitchance: Low", false);
            Klasser.WriteLine("Fighter 2: \nHp: Medium\nDamage: Medium\nHitchance: Medium", false);
            Klasser.WriteLine("Fighter 3: \nHp: Low\nDamage: High\nHitchance: High", false);

            string choice = Console.ReadLine();


            return choice;
        }
    }
}
