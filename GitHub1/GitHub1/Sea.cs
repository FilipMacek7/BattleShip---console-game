using GitHub1;
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
        List<Point> seaPoints = new List<Point>();       

        public void createSea()
        {           
            for (int x = 0; x < seaSize + 1; x++)
            {
                for (int y = 0; y < seaSize + 1; y++)
                {                    
                    Point point = new Point();
                    point.posX = x;
                    point.posY = y;
                    seaPoints.Add(point);
                }
            }
            int indexList = 10 * 1 - 10 + 1;
            seaPoints[indexList].marked = 1;
            seaPoints.RemoveAt(0);


        }
        public void displaySea()
        {
            Console.Write("  ");
            for (int i = 1; i < seaSize + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int x = 1; x < seaSize + 1; x++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(x);
                Console.Write(" ");
                for (int y = 0; y < seaSize; y++)
                {
                    int indexList = 10 * x - 10 + y;
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    if (seaPoints[indexList].state == State.Empty)
                    {
                        Console.Write("o ");
                    }
                    else if (seaPoints[indexList].state == State.Placed)
                    {
                        Console.Write("P ");
                    }
                    else if (seaPoints[indexList].state == State.Missed)
                    {
                        Console.Write("M ");
                    }
                    else if (seaPoints[indexList].state == State.Hit)
                    {
                        Console.Write("H ");
                    }

                    if (seaPoints[indexList].marked == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        if (seaPoints[indexList].state == State.Empty)
                        {
                            Console.Write("P ");
                        }
                        Console.ResetColor();
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        public void placeShips(int x, int y)
        {
            int indexList = (10 * x - 10) + y;
            Point point = seaPoints[indexList];
            point.state = State.Placed;

            seaPoints[indexList] = point;
            Console.Write(point.state);
        }
        public void moveShips(char move)
        {
            Mark mark1 = new Mark();
           
            if(move == 'd')
            {
                int indexList = (10 * mark1.markPosX - 10) + mark1.markPosY;               
                seaPoints[indexList].marked = 0;
                Console.WriteLine(indexList);
                indexList = (10 * mark1.markPosX + 1 - 10) + mark1.markPosY;       
                
                seaPoints[indexList].marked = 1;
                Console.WriteLine(indexList);
                //Console.Clear();
                displaySea();
            }
            
            
        }
    }
}
