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
                        while (true) {
                            Console.Clear();
                            Sea seapl1 = new Sea();
                            seapl1.createSea();
                            seapl1.displaySea();
                            Console.WriteLine("");
                            Console.WriteLine("Player 1 deploys one-block Submarine.");
                            Console.WriteLine("");
                            while (seapl1.playerPlaced == true)
                            {
                                ConsoleKeyInfo input = Console.ReadKey();
                                char move = input.KeyChar;
                                seapl1.moveShips(move);

                            }
                            Console.Clear();
                            Sea seapl2 = new Sea();
                            seapl2.createSea();
                            seapl2.displaySea();
                            Console.WriteLine("");
                            Console.WriteLine("Player 2 deploys one-block Submarine.");
                            Console.WriteLine("");
                            seapl2.playerPlaced = true;
                            while (seapl2.playerPlaced == true)
                            {
                                ConsoleKeyInfo input = Console.ReadKey();
                                char move = input.KeyChar;
                                seapl2.moveShips(move);
                            }
                            while (Sea.Game)
                            {                                
                                Console.Clear();
                                Console.WriteLine("Game has started. Good luck!");
                                while (Sea.playerTurn == true)
                                {
                                    seapl1.displayGameSea();
                                    Console.WriteLine("Player 1's turn: ");
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl1.moveShips(move);
                                    Console.Clear();
                                }
                                while (Sea.playerTurn == false)
                                {
                                    seapl2.displayGameSea();
                                    Console.WriteLine("Player 2's turn: ");
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl2.moveShips(move);
                                    Console.Clear();
                                }
                            }

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
