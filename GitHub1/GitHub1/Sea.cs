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
        public string[,] seaPoints2 = new string[10,10];

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

                    seaPoints[x, y] = new Point
                    {
                        posX = x,
                        posY = y,
                    };
                    if(Point.state == State.Empty)
                    {
                        Console.Write("o ");
                    }
                    else if (Point.state == State.Placed)
                    {
                        Console.Write("P ");
                    }
                    else if (Point.state == State.Missed)
                    {
                        Console.Write("M ");
                    }
                    else if (Point.state == State.Hit)
                    {
                        Console.Write("H ");
                    }
                }
                Console.WriteLine();
            }
        }

        //public void placeShips(int x, int y)
        //{
        //    seaPoints2[x, y] = "o ";
        //}
    }
}
