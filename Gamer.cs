﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Gamer
    {
        string name;
        Dice seans;
        public Gamer(string name)
        {
            this.name = name;
            seans = new Dice();
        }
        public int SeansGame()
        {
            return seans.Roll();
        }
        public override string ToString()
        {
            return name;
        }
    }
}
