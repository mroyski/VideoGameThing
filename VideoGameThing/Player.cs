﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameThing
{
    public class Player : Character
    {
        public int PlayerNumber { get; private set; }

        public Player()
        {
            Name = "Hero";
            HealthPoints = 100;
            AttackPower = 20;
            Movement = 5;
        }
    }
}
