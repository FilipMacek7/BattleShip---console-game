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
                        seapl1.displaySea();
                        Console.WriteLine("");
                        Console.WriteLine("First player deploys one-block Submarine.");
                        Console.WriteLine("");
                        while (true) { 
                            ConsoleKeyInfo input = Console.ReadKey();
                            char move = input.KeyChar;
                            seapl1.moveShips(move);                         
                            //Console.Write("Choose number x:");
                            //int fplposx = int.Parse(Console.ReadLine());
                            //Console.Write("Choose number y:");
                            //int fplposy = int.Parse(Console.ReadLine());                       
                            //seapl1.placeShips(fplposx, fplposy);
                            //Console.Clear();

                            //seapl1.displaySea();
                            //Console.WriteLine("");
                            //Console.WriteLine("First player deploys two-block Destroyer.");
                            //Console.WriteLine("");
                            //Console.Write("Choose number x:");
                            //fplposx = int.Parse(Console.ReadLine());
                            //Console.Write("Choose number y:");
                            //fplposy = int.Parse(Console.ReadLine());
                            //seapl1.placeShips(fplposx, fplposy);
                            //Console.Clear();

                            //seapl1.displaySea();


                        }
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
