﻿using System;

namespace Zork
{
    class Program

    {

        private static string[,] Rooms = {
            {"Dense Woods", "North of House", "Clearing" },
            { "Forest", "West of House", "Behind House" },
            {"Rocky Trail", "South of House", "Canyon View"}
        };

        private static (int Row, int Column) Location;

        private static string Place => Rooms[Location.Row, Location.Column];

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Zork!");
            Commands command = Commands.UNKNOWN;

            while(command != Commands.QUIT)
            {
                Console.Write($"{Place}\n> ");
                command = ToCommand(Console.ReadLine().Trim());
                string outputString;

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thanks for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. A rubber mat saying 'Welcome to Zork! lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);

            }

        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {

                case Commands.NORTH when Location.Row > 0:
                    Location.Row--;
                    didMove = true;
                    break;

                case Commands.SOUTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    didMove = true;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    didMove = true;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    didMove = true; 
                    break;

            }

            return didMove;
        }

    }
}
