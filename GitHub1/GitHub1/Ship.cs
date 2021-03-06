﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeGame
{
    class Ship
    {       
        public ShipType Ships { get; set;}      
        public ShipState State { get; set;}
        public int position { get; set; }
    }

    enum ShipType
    {
        Submarine,
        Destroyer,
        Cruiser,
    }

    enum ShipState
    {
        Function,
        Destroyed,
    }
}
