using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter_1 : Fighters
    {
        public Fighter_1() //Randomises the health points, maxDamage, minDamage and hitchance
        {
            //Hp: High, Damage: Medium, Hitchance: Low
            hp = Klasser.RandInt(minHp, maxHp + 10);
            maxDamage -= 1;
            minDamage -= 1;
            hitChance = Klasser.RandInt(minHitChance - 1, maxHitChance - 1);
        } //Randomises the health points, maxDamage, minDamage and hitchance
    }
}
