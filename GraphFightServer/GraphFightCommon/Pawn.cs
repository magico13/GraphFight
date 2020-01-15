using System;
using System.Collections.Generic;
using System.Text;

namespace GraphFightCommon
{
    public class Pawn
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Movement { get; set; }
        public int MaxMovement { get; set; }

        public Weapon Weapon { get; set; }

        public Pawn(Weapon weapon, int health = 1, int move = 3)
        {
            MaxHealth = Health = health;
            MaxMovement = Movement = move;
            Weapon = weapon;
        }
    }
}
