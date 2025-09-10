using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Running = true;

        //start
        while (Running)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ~ Dream Escape ~");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What do you wanna do?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. Start a new game.");
            Console.WriteLine("2. Load a previous game.");
            Console.WriteLine("3. See instructions");
            Console.WriteLine("4. Quit game");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Instruction();
                    //StartNewGame();
                    break;
                case "2":
                    //LoadGame();
                    break;
                case "3":
                    Instruction();
                    break;
                case "4":
                    Running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, press any key to try again.");
                    Console.ReadKey();
                    continue;
            }
        }
    }

    //Instructions
    static void Instruction()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Instructions");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You are trapped in your dreams...");
        Console.WriteLine("You need to find a way to escape.. or stay..");
        Console.WriteLine("\nControls:");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Enter - Continue story");
        Console.WriteLine("1 2 3 - Choices");
        Console.WriteLine("S - Save Game");
        Console.WriteLine("G - Load Game");
        Console.WriteLine("H - Help");
        Console.WriteLine("F - hint");
        Console.WriteLine("Q - quit");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }

}