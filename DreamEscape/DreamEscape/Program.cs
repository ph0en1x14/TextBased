using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

internal class Program
{
    static string saveFile = "savegame.txt";
    static int dreamStage = 1;
    static int dream1Progress = 0; // New variable to track progress in Dream 1
    static bool gameRunning = true;
    static List<string> inventory = new List<string>();

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
                    StartNewGame();
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

    //New game
    static void StartNewGame()
    {
        dreamStage = 1;
        dream1Progress = 0;
        inventory.Clear();
        GameLoop();
    }

    //Loop running dreams
    static void GameLoop()
    {
        gameRunning = true;
        while (gameRunning)
        {
            switch (dreamStage)
            {
                case 1:
                    Dream1();
                    break;
                default:
                    Console.WriteLine("Game over or undefined stage.");
                    gameRunning = false;
                    break;
            }
        }
    }
    //Dream 1
    static void Dream1()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        //Senario 1
        if (dream1Progress == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Objective: Try to escape the dream");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You open your eyes and look around...");
            Console.WriteLine("You're in an unfamiliar house.");
            Console.WriteLine("The walls are painted in many clashing bright colors...");
            Console.WriteLine("The furniture looks like it came out of a circus.");
            Console.WriteLine("In a corner, you see a small clown horn and a pair of oversized, floppy shoes. You take them with you");
        }
        //Senario 2
        else if (dream1Progress == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Objective: Try to escape the dream");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You're in the hallway, the bikes of the gorey clowns are blocking your path.");
        }
        //Senario 3
        else if (dream1Progress == 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Objective: Try to escape the dream");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are in the kitchen, a single, rusty knife is on the table. It calls to you.");
        }
        //Last Senario
        else if (dream1Progress == 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Objective: Try to escape the dream");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The clowns are gone, and a new door has appeared. It's a single, plain wooden door.");
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;

        //Senario 1
        if (dream1Progress == 0)
        {

            Console.WriteLine("What do you want to do?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. Explore the room.");
            Console.WriteLine("2. Try to go back to sleep.");
            Console.WriteLine("3. Leave the room.");
        }

        //Senario 2
        else if (dream1Progress == 1)
        {
            Console.WriteLine("What do you do about the clowns?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. Squeak the clown horn.");
            Console.WriteLine("2. Sneak past them.");
            Console.WriteLine("3. Run back into the room.");
        }

        //Senario 3
        else if (dream1Progress == 2)
        {
            Console.WriteLine("What do you do?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. Take the knife.");
            Console.WriteLine("2. Leave it and go back.");
            Console.WriteLine("3. Stay and explore the kitchen.");
        }

        //Last Senario 
        else if (dream1Progress == 3)
        {
            Console.WriteLine("What do you do?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. Open the wooden door.");
            Console.WriteLine("2. Stay in the circus house.");
            Console.WriteLine("3. Use the rusty knife on yourself.");
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;

        string choice = Console.ReadLine();

        HandleDream1Choice(choice);
    }

    //other options
    static void HandleDream1Choice(string choice)
    {
        if (choice == "s")
        {
            //SaveGame();
            return;
        }
        if (choice == "g")
        {
            //LoadGame();
            return;
        }
        if (choice == "h")
        {
            Instruction();
            return;
        }
        if (choice == "q")
        {
            gameRunning = false;
        }


        //Senario 1
        if (dream1Progress == 0)
        {
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("You wander around the room. You see paintings of clowns, their twisted smiles following you.");
                Console.WriteLine("a hand appears from out the painting and pulls you into it.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You appear in a long dark hallway surrounded by clowns");
                Console.WriteLine("you look at your refection and see yourself wearing a bloody clown costume. \nYou're wearing clown makeup and your eyes are bloody and slowly falling out their sockets.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ENDING - YOU are the clown");
                gameRunning = false;
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You lay back down on the bed and try to fall back asleep.");
                Console.WriteLine("You close your eyes and... wake up again in the same place. This dream is endless.");

            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You decide to leave the room. The hallway is long and dark, lit by a single, flickering bulb.");
                Console.WriteLine("Suddenly, a group of clowns with long legs on tiny bikes appears, their eyes weeping blood and some hanging from their sockets. They block your path.");
                dream1Progress = 1;
            }
            else if (choice == "f")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Maybe try going somewhere else instead of staying in that dirty room of yours.. - hint sponsored by ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("A judging lady");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        //Senario 2
        else if (dream1Progress == 1)
        {
            if (choice == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("You pull out the clown horn and give it a loud, startling ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("SQUEAKKK!");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nThe clowns' broken eyes stare at you for a moment, then they burst into a shower of confetti and disappear.");
                Console.WriteLine("The path is clear. You continue down the hall until you reach a kitchen.");
                dream1Progress = 2;
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("You try to sneak past them, but the clowns see you and their smiles grow wider.");
                Console.WriteLine("Their bikes swerve, and they begin to surround you, their blood-weeping eyes fixed on you.");
                Console.WriteLine("They close in on you as they eerily start singing.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("They pull you with them...");
                Console.WriteLine("Your body dragging limp over the floor as they bike to a room. \nThey throw you in and quickly start to order you around.\nYou do it.. knowing yout fate would be worse if you didn't.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ENDING - Endless slaving away");
                gameRunning = false;
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You run back into the room you started in. The clowns follow you, but stop at the door and simply stare. You are trapped.");
                Console.WriteLine("You feel a pull in your mind, a sense of familiarity. Perhaps it's not so bad here after all... \nMaybe you do wanna stay..");
                dream1Progress = 0;
            }
            else if (choice == "f")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("HONK HONNKKKK!! - hint sponsored by ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("frank the goose");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        //Senario 3
        else if (dream1Progress == 2)
        {
            if (choice == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You carefully pick up the rusty knife. It's cold and heavy in your hand.");
                inventory.Add("Rusty Knife");
                dream1Progress = 3;
                Console.WriteLine("You hear a creak behind you. The clowns are gone, but a new door has appeared in the hallway.");
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You decide to leave the knife. It feels too dangerous. You return to the hallway, but the clowns are gone.");
                Console.WriteLine("A new, plain wooden door has appeared where they once were.");
                dream1Progress = 3;
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You stay in the kitchen. The cabinets are filled with old, moldy food. The stove is covered in grime.");
                Console.WriteLine("You hear faint, circus music from outside the room. You have a sense of overwhelming dread.");
            }
            else if (choice == "f")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("hmmmm.. that knife does look good doesn't it? - hint sponsored by ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Patrica the crow");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        //Last Senario 
        else if (dream1Progress == 3)
        {
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("You open the wooden door. The room beyond is a stark, empty void. You step through...");
                Console.WriteLine("You feel a sharp pain in your head as the dream shatters. The world around you fades to black.");
                Console.WriteLine("But you don't wake up...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You just float around the darkness slowly fading away");
                Console.WriteLine("When you finally see something again you see a neat hospital room. \nAnd you yourself layed in the bed... \nyou look at your hands... They are clear and seethrough.. \nYou all of a sudden hear a loud long beep..");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ENDING - You actually died...");
                gameRunning = false;
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("You decide to stay. This strange, unsettling circus house is your new reality.");
                Console.WriteLine("The clowns return, but they no longer seem threatening. They offer you a balloon.");
                Console.WriteLine("You have chosen to stay in the dream. You are safe here, but you will never wake up.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You go back to the room and find a clown costume and makeup laying on the ben for you.");
                Console.WriteLine("You put them on and the clowns treat you as one of their own.. \nThey treat you like you a precious to them even.. \nYou're the only human clown.. but you feel like you belong with them.. \nWith your new family..");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ENDING - You stayed and became one of them");
                gameRunning = false;
            }

            else if (choice == "3" && inventory.Contains("Rusty Knife"))
            {
                Console.WriteLine("You raise the rusty knife and plunge it into your chest. The pain is real, searing.");
                Console.WriteLine("You stumble and fall, and the world around you dissolves into a cascade of light.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You gasp and wake up..");
                Console.WriteLine("You look around and see you're own room. \nYou sigh out of relief and try to continue with your day");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ENDING - You Escaped");
                gameRunning = false;
                dream1Progress = 0;
            }
            else if (choice == "3" && !inventory.Contains("Rusty Knife"))
            {
                Console.WriteLine("You don't have a knife. You can't end it here. You must continue...");
            }

            //hint
            else if (choice == "f")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("got that pretty and shape thing with you? you should do it.. do it.. DO IT!! - hint sponsored by ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Your dark thoughts");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        Console.ReadKey();
    }
}