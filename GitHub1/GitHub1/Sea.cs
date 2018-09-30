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
        int shipTypeCounter = 0;
        public static bool? playerTurn = true;
        static int pl1Points = 0;
        static int pl2Points = 0;
        static int shipSizeCounter = 0;
        int rotateCounter = 0;
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
        public void clearSea()
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    int indexList = seaSize * y + x;
                    seaPoints[indexList].state = State.Empty;
                }
            }
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
                if (shipTypeCounter == 0)
                {
                    int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 0;

                    mark1.markPosY--;
                    indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 1;
                }
                else if (shipTypeCounter == 1)
                {
                    if (rotateCounter == 0 || rotateCounter == 4)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;                        
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 3)
                    {
                        int indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        mark1.markPosY--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
                else if (shipTypeCounter == 2)
                {
                    if (rotateCounter == 0 || rotateCounter == 4)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;


                        mark1.markPosY--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                   else if(rotateCounter == 1)
                   {
                        int indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        mark1.markPosY--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY -1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
            }
            else if (move == 'w')
            {
                if (shipTypeCounter == 0)
                {
                    int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 0;

                    mark1.markPosX--;
                    indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 1;
                }
                else if (shipTypeCounter == 1)
                {
                    if (rotateCounter == 0 || rotateCounter == 4)
                    {
                        if (shipTypeCounter == 1)
                        {
                            int indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                            seaPoints[indexList].marked = 0;

                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 1;
                            mark1.markPosX--;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 1;
                        }
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;                        
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 3)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
                else if (shipTypeCounter == 2)
                {
                    if (rotateCounter == 0 || rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY -1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX--;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
            }
            else if (move == 'd')
            {
                if (shipTypeCounter == 0)
                {
                    int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 0;

                    mark1.markPosY++;
                    indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 1;
                }

                else if (shipTypeCounter == 1)
                {
                    if (rotateCounter == 0 || rotateCounter == 4)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 3)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;                        
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
                else if (shipTypeCounter == 2)
                {
                    if (rotateCounter == 0 || rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosY++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        mark1.markPosY++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
            }
            else if (move == 's')
            {

                if (shipTypeCounter == 0)
                {
                    int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 0;

                    mark1.markPosX++;
                    indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 1;
                }
                else if(shipTypeCounter == 1)
                {
                    if (rotateCounter == 0 || rotateCounter == 4)
                    {
                        if (shipTypeCounter == 1)
                        {
                            int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;

                            mark1.markPosX++;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 1;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                            seaPoints[indexList].marked = 1;
                        }
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        mark1.markPosX++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 3)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
                else if (shipTypeCounter == 2)
                {
                    if(rotateCounter == 0 || rotateCounter == 2)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 1)
                    {
                        int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX++;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                }
            }
            else if (move == 'r')
            {
                if (shipTypeCounter == 1)
                {                   
                    rotateCounter++;
                    int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 1;

                    indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                    seaPoints[indexList].marked = 0;

                    if (rotateCounter == 1)
                    {
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if(rotateCounter == 2)
                    {
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 3)
                    {
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY +1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 4)
                    {
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                        rotateCounter = 0;
                    }

                }
                else if (shipTypeCounter == 2)
                {
                    rotateCounter++;
                    int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                    seaPoints[indexList].marked = 1;

                    indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                    seaPoints[indexList].marked = 0;

                    if (rotateCounter == 1)
                    {
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                    }
                    else if (rotateCounter == 2)
                    {
                        indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                        seaPoints[indexList].marked = 0;
                        indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX ;
                        seaPoints[indexList].marked = 0;

                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                        rotateCounter = 0;
                    }
                }
            }
            else if (move == (char)13)
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;

                if(seaPoints[indexList].state == State.Empty)
                {
                    if(shipTypeCounter == 0)
                    {
                        seaPoints[indexList].state = State.Placed;
                        seaPoints[indexList].marked = 0;

                        mark1.markPosX = 0;
                        mark1.markPosY = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                        shipSizeCounter++;
                    }               
                    else if(shipTypeCounter == 1)
                    {
                        if (rotateCounter == 0 || rotateCounter == 4)
                        {
                            seaPoints[indexList].state = State.Placed;
                            seaPoints[indexList].marked = 0;
                            mark1.markPosX++;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                        }        
                        else if (rotateCounter == 1)
                        {
                            seaPoints[indexList].state = State.Placed;
                            seaPoints[indexList].marked = 0;
                            mark1.markPosY--;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                        }
                        else if (rotateCounter == 2)
                        {
                            seaPoints[indexList].state = State.Placed;
                            seaPoints[indexList].marked = 0;
                            mark1.markPosX--;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                        }
                        else if (rotateCounter == 3)
                        {
                            seaPoints[indexList].state = State.Placed;
                            seaPoints[indexList].marked = 0;
                            mark1.markPosY++;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                        }
                        mark1.markPosX = 1;
                        mark1.markPosY = 0;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                        seaPoints[indexList].marked = 1;
                        indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                        seaPoints[indexList].marked = 1;
                        shipSizeCounter = shipSizeCounter + 2;
                    }
                    else if (shipTypeCounter == 2)
                    {
                        if(rotateCounter == 0 || rotateCounter == 2)
                        {
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX + 1;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                            indexList = seaSize * mark1.markPosY + mark1.markPosX - 1;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;                           
                        }
                        else if (rotateCounter == 1)
                        {
                            indexList = seaSize * mark1.markPosY + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                            indexList = seaSize * (mark1.markPosY + 1) + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                            indexList = seaSize * (mark1.markPosY - 1) + mark1.markPosX;
                            seaPoints[indexList].marked = 0;
                            seaPoints[indexList].state = State.Placed;
                        }
                        shipSizeCounter = shipSizeCounter + 3;
                    }
                    shipTypeCounter++;                   
                    placeCounter++;
                    if (placeCounter == 3)
                    {
                        rotateCounter = 0;
                        shipTypeCounter = 0;
                        playerPlaced = false;
                        placeCounter = 0;
                        mark1.markPosX = 0;
                        mark1.markPosY = 0;
                        seaPoints[0].marked = 1;
                    }
                }               
            }
        }
        public void displayGameSea()
        {
            Console.WriteLine("IN GAME:");
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
                    }

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public void moveGame(char move)
        {        
            if (move == 'a')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosY--;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;
            }
            else if (move == 'w')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosX--;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;
            }
            else if (move == 'd')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosY++;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;
            }
            else if (move == 's')
            {
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 0;

                mark1.markPosX++;
                indexList = seaSize * mark1.markPosY + mark1.markPosX;
                seaPoints[indexList].marked = 1;
            }
            if (move == (char)13)
            {
                Console.Clear();
                int indexList = seaSize * mark1.markPosY + mark1.markPosX;
                Point point = seaPoints[indexList];
                if (playerTurn == true)
                {
                    if (seaPoints[indexList].state == State.Placed)
                    {
                        seaPoints[indexList].state = State.Hit;
                        Console.WriteLine("You have hit enemy's ship.");
                        pl1Points++;
                    }
                    else if (seaPoints[indexList].state == State.Empty)
                    {
                        seaPoints[indexList].state = State.Missed;
                        Console.WriteLine("You have missed enemy's ship.");
                    }  
                    else{
                        Console.WriteLine("You have already shot here.");
                    }
                    Console.WriteLine("Press any key to end your turn.");
                    ConsoleKeyInfo endTurn = Console.ReadKey();
                    if(endTurn.KeyChar == 'k')
                    {
                        playerTurn = false;
                    }
                    {
                        playerTurn = false;
                    }
                    seaPoints[indexList].marked = 0;
                    mark1.markPosX = 0;
                    mark1.markPosY = 0;
                    seaPoints[0].marked = 1;
                }
                else if (playerTurn == false)
                {
                    if (seaPoints[indexList].state == State.Placed)
                    {
                        seaPoints[indexList].state = State.Hit;
                        Console.WriteLine("You have hit enemy's ship.");
                        pl2Points++;
                    }
                    else
                    {
                        seaPoints[indexList].state = State.Missed;
                        Console.WriteLine("You have missed enemy's ship.");
                    }
                    Console.WriteLine("Press any key to end your turn.");
                    ConsoleKeyInfo endTurn = Console.ReadKey();
                    if (endTurn.KeyChar == 'k')
                    {
                        playerTurn = true;
                    }
                    {
                        playerTurn = true;
                    }
                    seaPoints[indexList].marked = 0;
                    mark1.markPosX = 0;
                    mark1.markPosY = 0;
                    seaPoints[0].marked = 1;
                }
                seaPoints[indexList] = point;
            }
        }

        public void playerHasWon(){
            if (pl1Points == shipSizeCounter / 2){     
                Console.Clear();
                playerTurn = null;
                Console.WriteLine("Congratulations! Player 1 has won the game.");
                Console.WriteLine("");
                Console.WriteLine("Do you want to battle ships one more time?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
            }
            else if(pl2Points == shipSizeCounter / 2){
                Console.Clear();
                playerTurn = null;
                Console.WriteLine("Congratulations! Player 2 has won the game.");
            }          
        }
    }
}
