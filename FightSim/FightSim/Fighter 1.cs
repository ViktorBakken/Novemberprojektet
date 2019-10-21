using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter_1 : Fighters
    {
        public Fighter_1()
        {
            hp = Klasser.RandInt(minHp, maxHp + 10);
            hitChance = Klasser.RandInt(minHitChance, maxHitChance - 5);
        }
    }
}
