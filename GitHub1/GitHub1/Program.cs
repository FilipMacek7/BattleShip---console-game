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
            bool pl3placing = true;
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
                            Console.WriteLine("Press ENTER to deploy ships");
                            Console.WriteLine("Press R to rotate ships");
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
                            Console.WriteLine("Press ENTER to deploy ships");
                            Console.WriteLine("Press R to rotate ships");
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
                            Console.Clear();
                            Sea seapl3 = new Sea();
                            seapl3.createSea();
                            seapl3.displaySea();
                            Console.WriteLine("");
                            Console.WriteLine("Press ENTER to deploy ships");
                            Console.WriteLine("Press R to rotate ships");
                            Console.WriteLine("");
                            seapl3.playerPlaced = true;
                            while (pl3placing)
                            {
                                while (seapl3.playerPlaced == true)
                                {
                                    ConsoleKeyInfo input = Console.ReadKey();
                                    char move = input.KeyChar;
                                    seapl3.moveShips(move);
                                    Console.Clear();
                                    seapl3.displaySea();
                                }
                                Console.WriteLine("Player 3 do you want to set ships on these positions?");
                                Console.WriteLine("1) Yes");
                                Console.WriteLine("2) No");
                                ConsoleKeyInfo choice = Console.ReadKey();
                                if (choice.KeyChar == '1')
                                {
                                    pl3placing = false;
                                }
                                else if (choice.KeyChar == '2')
                                {
                                    seapl3.playerPlaced = true;
                                    seapl3.clearSea();
                                    Console.Clear();
                                    seapl3.displaySea();
                                    Console.WriteLine("Select one more time.");
                                }
                            }

                            while (true)
                            {                                          
                                while (Sea.playerTurn == 1)
                                {                                    
                                    if (Sea.shootTurn == true)
                                    {
                                        Console.Clear();
                                        seapl2.displayGameSea();
                                        Console.WriteLine("Player 1's turn. ");
                                        Console.WriteLine("You are shooting on Player 2. ");
                                        ConsoleKeyInfo input = Console.ReadKey();
                                        char move = input.KeyChar;
                                        seapl2.moveGame(move);
                                    }
                                   else if (Sea.shootTurn == false)
                                    {
                                        Console.Clear();
                                        seapl3.displayGameSea();
                                        Console.WriteLine("Player 1's turn. ");
                                        Console.WriteLine("You are shooting on Player 3. ");
                                        ConsoleKeyInfo input = Console.ReadKey();
                                        char move = input.KeyChar;
                                        seapl3.moveGame(move);                                      
                                    }
                                    Sea.playerHasWon();
                                }                               
                                while (Sea.playerTurn == 2)
                                {
                                    if (Sea.shootTurn == true)
                                    {
                                        Console.Clear();
                                        seapl1.displayGameSea();
                                        Console.WriteLine("Player 2's turn. ");
                                        Console.WriteLine("You are shooting on Player 1. ");
                                        ConsoleKeyInfo input = Console.ReadKey();
                                        char move = input.KeyChar;
                                        seapl1.moveGame(move);
                                    }
                                    else if (Sea.shootTurn == false)
                                    {
                                        Console.Clear();
                                        seapl3.displayGameSea();
                                        Console.WriteLine("Player 2's turn. ");
                                        Console.WriteLine("You are shooting on Player 3. ");
                                        ConsoleKeyInfo input = Console.ReadKey();
                                        char move = input.KeyChar;
                                        seapl3.moveGame(move);
                                    }
                                    Sea.playerHasWon();
                                }
                                while (Sea.playerTurn == 3)
                                {
                                    if (Sea.shootTurn == true)
                                    {
                                        Console.Clear();
                                        seapl1.displayGameSea();
                                        Console.WriteLine("Player 3's turn. ");
                                        Console.WriteLine("You are shooting on Player 1. ");
                                        ConsoleKeyInfo input = Console.ReadKey();
                                        char move = input.KeyChar;
                                        seapl1.moveGame(move);
                                    }
                                    else if (Sea.shootTurn == false)
                                    {
                                        Console.Clear();
                                        seapl2.displayGameSea();
                                        Console.WriteLine("Player 1's turn. ");
                                        Console.WriteLine("You are shooting on Player 2. ");
                                        ConsoleKeyInfo input = Console.ReadKey();
                                        char move = input.KeyChar;
                                        seapl2.moveGame(move);
                                    }
                                    Sea.playerHasWon();
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
