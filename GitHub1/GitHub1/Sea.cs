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
        int seaSize = 10;
        List<Point> seaPoints = new List<Point>();
        Mark mark1 = new Mark();
        public bool playerPlaced = true;
        int placeCounter = 0;
        public static bool Game = true;
        public static bool playerTurn = true;

        public void createSea()
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Point point = new Point();
                    point.posX = x;
                    point.posY = y;
                    seaPoints.Add(point);
                }
            }
            seaPoints[0].marked = 1;
        }
        public void displaySea()
        {
            Console.Write("  ");
            for (int i = 0; i < seaSize; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int x = 0; x < seaSize; x++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(x);
                Console.Write(" ");
                for (int y = 0; y < seaSize; y++)
                {

                    int indexList = seaSize * y + x;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (seaPoints[indexList].marked == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        if (seaPoints[indexList].state == State.Empty)
                        {
                            Console.Write("o ");
                        }
                        else if (seaPoints[indexList].state == State.Placed)
                        {
                            Console.Write("P ");
                        }
                        Console.ResetColor();
                    }
                    else if (seaPoints[indexList].marked == 0)
                    {
                        if (seaPoints[indexList].state == State.Empty)
                        {
                            Console.Write("o ");
                        }
                        else if (seaPoints[indexList].state == State.Placed)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("P ");
                            Console.ResetColor();
                        }
                        else if (seaPoints[indexList].state == State.Missed)
                        {
                            Console.Write("M ");
                        }
                        else if (seaPoints[indexList].state == State.Hit)
                        {
                            Console.Write("H ");
                        }
                    }

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        public void moveShips(char move)
        {
            if (move == 'a')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosY--;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displaySea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == 'w')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosX--;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displaySea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == 'd')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosY++;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displaySea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == 's')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosX++;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displaySea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == (char)13)
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;

                if(seaPoints[indexList].state == State.Empty)
                {
                    Point point = seaPoints[indexList];
                    point.state = State.Placed;                  
                    seaPoints[indexList].marked = 1;
                    seaPoints[indexList] = point;

                    Ship submarine = new Ship();
                    submarine.position = indexList;
                    placeCounter++;
                   
                    if (placeCounter == 3)
                    {
                        playerPlaced = false;
                        placeCounter = 0;
                        mark1.markPosX = 0;
                        mark1.markPosY = 0;
                    }
                }
                else if(seaPoints[indexList].state == State.Placed)
                {
                    Console.Clear();
                    displaySea();
                    Console.WriteLine("Ship already exists here.");
                }
                
            }

        }
        public void displayGameSea()
        {
            Console.Write("  ");
            for (int i = 0; i < seaSize; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int x = 0; x < seaSize; x++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(x);
                Console.Write(" ");
                for (int y = 0; y < seaSize; y++)
                {

                    int indexList = seaSize * y + x;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (seaPoints[indexList].marked == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        if (seaPoints[indexList].state == State.Empty)
                        {
                            Console.Write("o ");
                        }
                        else if (seaPoints[indexList].state == State.Placed)
                        {
                            Console.Write("o ");
                        }
                        else if (seaPoints[indexList].state == State.Missed)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("M ");
                            Console.ResetColor();
                        }
                        else if (seaPoints[indexList].state == State.Hit)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("H ");
                            Console.ResetColor();
                        }
                        Console.ResetColor();
                    }
                    else if (seaPoints[indexList].marked == 0)
                    {
                        if (seaPoints[indexList].state == State.Empty)
                        {
                            Console.Write("o ");
                        }
                        else if (seaPoints[indexList].state == State.Placed)
                        {
                            Console.Write("o ");
                        }
                        else if (seaPoints[indexList].state == State.Missed)
                        {
                            Console.Write("M ");
                        }
                        else if (seaPoints[indexList].state == State.Hit)
                        {
                            Console.Write("H ");
                        }
                    }

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("x:" + mark1.markPosX);
            Console.WriteLine("y:" + mark1.markPosY);
        }

        public void moveGame(char move)
        {
            if (move == 'w')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosY--;
                indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displayGameSea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == 'a')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosX--;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displayGameSea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == 's')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosY++;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displayGameSea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == 'd')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosX++;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;

                Console.Clear();
                displayGameSea();
                Console.WriteLine("x:" + mark1.markPosX);
                Console.WriteLine("y:" + mark1.markPosY);
                Console.WriteLine(indexList);
            }
            else if (move == (char)13)
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                Point point = seaPoints[indexList];
                if (playerTurn == true)
                {
                    if (seaPoints[indexList].state == State.Placed)
                    {
                        seaPoints[indexList].state = State.Hit;
                    }
                    else
                    {
                        seaPoints[indexList].state = State.Missed;
                    }
                    playerTurn = false;
                }
                else if (playerTurn == false)
                {
                   
                    if (seaPoints[indexList].state == State.Placed)
                    {
                        seaPoints[indexList].state = State.Hit;
                    }
                    else
                    {
                        seaPoints[indexList].state = State.Missed;
                    }
                    playerTurn = true;
                }
                seaPoints[indexList] = point;

            }

        }
    }
}
