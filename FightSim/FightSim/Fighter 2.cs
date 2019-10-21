using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter_2 : Fighters
    {
        public Fighter_2()
        {
            hp = Klasser.RandInt(minHp, maxHp);
            hitChance = Klasser.RandInt(minHitChance, maxHitChance);
        }

    }
}
