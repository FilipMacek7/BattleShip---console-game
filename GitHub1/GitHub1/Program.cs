using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            void menu()
            {
                Console.WriteLine("Welcome to the BattleShip console game.");
                Console.WriteLine("1) New Game");
                Console.WriteLine("2) Exit");

            }
            int seaSize = 10;
            Point[,] seaPoints = new Point[10, 10];

            void createSea()
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

                        Console.Write(" ");

                    }
                    Console.WriteLine();
                }
            }
            bool Semafor = true;
            while (Semafor)
            {
                menu();
                while (true)
                {
                    string vyber = Console.ReadLine();
                    if (vyber == "1")
                    {
                        Console.Clear();
                        Sea seapl1 = new Sea();
                        seapl1.createSea();
                        Console.WriteLine("");
                        Console.WriteLine("First player deploys two-block Submarine.");
                        Console.WriteLine("");
                        Console.Write("Choose number x:");
                        int fplposx = int.Parse(Console.ReadLine());
                        Console.Write("Choose number y:");
                        int fplposy = int.Parse(Console.ReadLine());
                        //int ind = ((fplposx - 1) + (fplposy - 1) * 10);
                        seaPoints[fplposx, fplposy] = new Point
                        {
                            posX = fplposx,
                            posY = fplposy,
                        };
                        
                        seapl1.placeShips(fplposx, fplposy);

                        Console.Clear();
                        seapl1.createSea();

                    }
                    else if (vyber == "2")
                    {
                        Semafor = false;
                        break;
                    }
                }                        
            }                     
        }
    }
}
