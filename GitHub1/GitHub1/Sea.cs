using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeGame
{
    class Sea
    {
        public int seaSize = 10;
        public Point[,] seaPoints = new Point[10, 10];
        public void createSea()
        {
            Console.Write("  ");
            for (int i = 0; i < seaSize; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int x = 0; x < seaSize; x++)
            {
                Console.Write(x);
                Console.Write(" ");

                for (int y = 0; y < seaSize; y++)
                {
                    Point point = new Point();
                    point.posX = x;
                    point.posY = y;
                    point.state = State.Empty;

                    seaPoints[x, y] = point;

                    if (seaPoints[x, y].state == State.Empty)
                    {
                        Console.Write("o ");
                    }
                    else if (seaPoints[x, y].state == State.Placed)
                    {
                        Console.Write("P ");
                    }
                    else if (seaPoints[x, y].state == State.Missed)
                    {
                        Console.Write("M ");
                    }
                    else if (seaPoints[x, y].state == State.Hit)
                    {
                        Console.Write("H ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(seaPoints[7, 7].state);
        }
        public void placeShips(int x, int y)
        {
            Point point = seaPoints[x, y];
            point.state = State.Placed;

            seaPoints[x, y] = point;
            Console.WriteLine(seaPoints[7, 7].state);
        }
    }
}
