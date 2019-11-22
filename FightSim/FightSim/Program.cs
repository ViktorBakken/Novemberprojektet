using System;

namespace FightSim
{
    class Program
    {
        static Methods m = new Methods();
        static void Main(string[] args)
        {
            Fighters player = m.PresentFighterKlass(false); //The player gets to choose a fighter             
            Fighters enemy = m.PresentFighterKlass(true); //The game randomises a fighter

            m.NameYourFighter(player); //Lets the player name their character
            player.PrintStats(); //Prints the player's stats
            
            Console.Clear();
            
            Klasser.WriteLine("You'r oponent is ...\n\n(*Enter*)", false); 
            
            enemy.PrintStats(); //Prints the enemy's stats

            m.AnitiateFight(player, enemy); //This code block is for Anitiating the fight by randomise if the playeer or the enemy start the fight 

            if (Klasser.restartGame == true) //After the fight, if the player wants to restart the game, the bool restartGame becomes true
            {
                Program.Main(args);
            } //After the fight, if the player wants to restart the game, the bool restartGame becomes true
        }
        

    }
}
