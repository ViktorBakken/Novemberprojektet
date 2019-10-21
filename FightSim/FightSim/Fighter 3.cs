using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter_3 : Fighters
    {
        public Fighter_3()
        {
            hp = Klasser.RandInt(minHp, maxHp - 3);
            maxDamage += 2;
            minDamage += 2;
            hitChance = Klasser.RandInt(minHitChance, maxHitChance + 5);
        }
    }
}
