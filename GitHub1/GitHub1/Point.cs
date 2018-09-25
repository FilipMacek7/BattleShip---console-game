using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeGame
{
    class Point
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public State state { get; set; }

    }
    enum State
    {
        Empty,
        Placed,
        Missed,
        Hit,
    }
}
