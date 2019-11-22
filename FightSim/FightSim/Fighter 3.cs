using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter_3 : Fighters
    {
        public Fighter_3() //Randomises the health points, maxDamage, minDamage and hitchance
        {
            //Hp: Low, Damage: High, Hitchance: High
            hp = Klasser.RandInt(minHp - 2, maxHp - 3);
            maxDamage += 2;
            minDamage += 2;
            hitChance = Klasser.RandInt(minHitChance, maxHitChance + 5);
        } //Randomises the health points, maxDamage, minDamage and hitchance
    }
}
