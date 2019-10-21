using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Figher_1 : Fighters
    {
        public Figher_1()
        {
            hp = Klasser.RandInt(minHp, maxHp + 10);
            hitChance = Klasser.RandInt(minHitChance, maxHitChance - 5);
        }
    }
}
