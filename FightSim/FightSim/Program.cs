using System;

namespace FightSim
{
    class Program
    {
        static Methods m = new Methods();
        static bool restartGame = false;
        static void Main(string[] args)
        {
            Fighters player = m.PresentFighterKlass(false); // The player gets to choose a fighter             
            Fighters enemy = m.PresentFighterKlass(true); // The game randomises a fighter

            m.NameYourFighter(player);
            player.PrintStats();            
            enemy.PrintStats();
            
            m.AnitiateFight(player, enemy);

            if (restartGame == true)
            {
                Program.Main(args);
            }
        }
        

    }
}
