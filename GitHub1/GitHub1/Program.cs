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
            bool pl1placing = true;
            bool pl2placing = true;
            bool Game = true;
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
                            Console.WriteLine("Press ENTER to deploy one-block Submarine Player 1.");
                            Console.WriteLine("");
                            while (pl1placing)
                            {
                                while (seapl1.playerPlaced == true)
                                {
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl1.moveShips(move);
                                    Console.Clear();
                                    seapl1.displaySea();
                                }                              
                                Console.WriteLine("Player 1 do you want to set ships on these positions?");
                                Console.WriteLine("1) Yes");
                                Console.WriteLine("2) No");
                                ConsoleKeyInfo choice = Console.ReadKey();
                                if (choice.KeyChar == '1')
                                {
                                    pl1placing = false;
                                }
                                else if(choice.KeyChar == '2')
                                {
                                    seapl1.playerPlaced = true;
                                    seapl1.clearSea();
                                    Console.Clear();
                                    seapl1.displaySea();
                                    Console.WriteLine("Select one more time.");
                                }
                            }
                            
                            Console.Clear();
                            Sea seapl2 = new Sea();
                            seapl2.createSea();
                            seapl2.displaySea();
                            Console.WriteLine("");
                            Console.WriteLine("Press ENTER to deploy one-block Submarine Player 2.");
                            Console.WriteLine("");
                            seapl2.playerPlaced = true;
                            while (pl2placing)
                            {
                                while (seapl2.playerPlaced == true)
                                {
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl2.moveShips(move);
                                    Console.Clear();
                                    seapl2.displaySea();
                                }
                                Console.WriteLine("Player 2 do you want to set ships on these positions?");
                                Console.WriteLine("1) Yes");
                                Console.WriteLine("2) No");
                                ConsoleKeyInfo choice = Console.ReadKey();
                                if (choice.KeyChar == '1')
                                {
                                    pl2placing = false;
                                }
                                else if (choice.KeyChar == '2')
                                {
                                    seapl2.playerPlaced = true;
                                    seapl2.clearSea();
                                    Console.Clear();
                                    seapl2.displaySea();
                                    Console.WriteLine("Select one more time.");
                                }
                            }

                            while (Game)
                            {
                                Console.Clear();                              
                                seapl1.displayGameSea();                                                            
                                while (Sea.playerTurn == true)
                                {
                                    Console.Clear();
                                    seapl1.displayGameSea();
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl1.moveGame(move);
                                    seapl1.displayGameSea();
                                    Console.WriteLine("Player 1's turn. ");
                                }                               
                                while (Sea.playerTurn == false)
                                {
                                    Console.Clear();
                                    seapl2.displayGameSea();
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl1.moveGame(move);
                                    seapl2.displayGameSea();
                                    Console.WriteLine("Player 2's turn. ");
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
