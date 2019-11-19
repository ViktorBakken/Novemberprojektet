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
            maxDamage -= 1;
            minDamage -= 1;
            hitChance = Klasser.RandInt(minHitChance - 1, maxHitChance - 1);
        }
    }
}
