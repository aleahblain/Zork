using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public Dictionary<string, Commands> Commands { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool isRunning { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }


        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Commands>()
            {
                { "QUIT", new Commands("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Commands("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Commands("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.NORTH)) },
                { "SOUTH", new Commands("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.SOUTH)) },
                { "EAST", new Commands("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.EAST)) },
                { "WEST", new Commands("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.WEST)) },
            };
        }

        public void Run()
        {
            Console.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);

            isRunning = true;
            Room previousRoom = null;
            while (isRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Look(this);
                    previousRoom = Player.Location;
                }

                Console.Write("\n> ");
                string commandString = Console.ReadLine().Trim().ToUpper();
                Commands foundCommand = null;
                foreach (Commands command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        foundCommand = command;
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    foundCommand.Action(this);
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Thank you for playing!" : ExitMessage);
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }

        private static void Look(Game game) => Console.WriteLine(game.Player.Location.Description);

        private static void Quit(Game game) => game.isRunning = false;

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => Player = new Player(World, StartingLocation);
    }
}
