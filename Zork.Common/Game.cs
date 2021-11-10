using System;
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

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        public IOutputService Output { get; set; }

        public IInputService Input { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = new Player(game.World, game.StartingLocation);
            return game;
        }

        public void Start(IInputService input, IOutputService output)
        {
            //Assert.IsNotNull(input);
            Input = input;
            Input.InputReceived += InputReceivedHandler;

            //Assert.IsNotNull(output);
            Output = output;
            isRunning = true;
        }

        private void InputReceivedHandler(object sender, string e)
        {
            Room previousRoom = null;

            Output.WriteLine(Player.Location);
            if (previousRoom != Player.Location)
            {
                Output.WriteLine(Player.Location.Description);
                previousRoom = Player.Location;
            }

            Output.Write("\n> ");

            Commands command = Commands.UNKNOWN;
            command = ToCommand(Console.ReadLine().Trim());

            switch (command)
            {
                case Commands.QUIT:
                    isRunning = false;
                    break;

                case Commands.LOOK:
                    Output.WriteLine(Player.Location.Description);
                    break;

                case Commands.NORTH:
                case Commands.SOUTH:
                case Commands.EAST:
                case Commands.WEST:
                    Directions direction = (Directions)command;
                    if (Player.Move(direction) == false)
                    {
                        Output.WriteLine("The way is shut!");
                    }
                    break;

                default:
                    Output.WriteLine("Unknown command.");
                    break;
            }


        }

        public void Look(Game g)
        {
            Output.WriteLine(g.Player.Location.Description);
        }

        private static void Move(Directions d, Game g)
        {
            if(g.Player.Move(d) == false)
            {
                //Output.WriteLine("The way is shut!");
            }
        }
    }
}
