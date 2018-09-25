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
        public int start = 0;

    }
    enum State
    {
        Empty,
        Placed,
        Missed,
        Hit,
    }
}
