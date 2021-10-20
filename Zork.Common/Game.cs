﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool isRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();
            return game;
        }

        public void Run()
        {
            isRunning = true;
            Room previousRoom = null;
            while (isRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Console.Write("\n> ");

                Commands command = Commands.UNKNOWN;
                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        isRunning = false;
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if(Player.Move(direction) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }

            }
        }
    }
}