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
                    //Instruction();
                    //StartNewGame();
                    break;
                case "2":
                    //LoadGame();
                    break;
                case "3":
                    //Instruction();
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
}