using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter_2 : Fighters
    {
        public Fighter_2() //Randomises the health points, maxDamage, minDamage and hitchance
        {
            //Hp: Medium, Damage: Medium, Hitchance: Medium
            hp = Klasser.RandInt(minHp, maxHp);
            maxDamage += 2;
            minDamage += 2;
            hitChance = Klasser.RandInt(minHitChance, maxHitChance);
        } //Randomises the health points, maxDamage, minDamage and hitchance

    }
}
