using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {

        private static Room[,] Rooms = {
            {new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") },
            {new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            {new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View")}
        };

        private static (int Row, int Column) Location;

        private static Room Place => Rooms[Location.Row, Location.Column];


        private enum Fields
        {
            Name = 0,
            Description
        }

        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Zork!");

            const string defaultRoomsFilename = "Rooms.json";
            string roomsFilename = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFilename);
            InitializeRooms(roomsFilename);
            Room previousRoom = null;
            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{Place.Name}\n> ");

                if(previousRoom != Place)
                {
                    Console.WriteLine(Place.Description);
                    previousRoom = Place;
                }

                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thanks for playing!");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Place.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Console.WriteLine(Move(command) ? $"You moved {command}." : "The way is shut!");
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }

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

        private static void InitializeRooms(string roomsFilename) =>
           Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));

    }
}
