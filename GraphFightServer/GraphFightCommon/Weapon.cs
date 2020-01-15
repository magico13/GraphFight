using System;
using System.Collections.Generic;
using System.Text;

namespace GraphFightCommon
{
    public class Weapon
    {
        public int Damage { get; set; }
        public double Accuracy { get; set; }

        public Weapon(int damage = 1, double accuracy = 0.1)
        {
            Damage = damage;
            Accuracy = accuracy;
        }
    }
}
