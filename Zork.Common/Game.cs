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

        [JsonIgnore]
        public bool isRunning { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        [JsonIgnore]
        public IOutputService Output { get; set; }

        [JsonIgnore]
        public IInputService Input { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Commands>()
            {
                { "QUIT", new Commands("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Commands("LOOK", new string[] { "LOOK", "L" }, Look) },
                {"REWARD", new Commands("REWARD", new string[] {"REWARD, 'R" }, Reward) },
                { "NORTH", new Commands("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.NORTH)) },
                { "SOUTH", new Commands("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.SOUTH)) },
                { "EAST", new Commands("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.EAST)) },
                { "WEST", new Commands("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.WEST)) },
            };
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
        
        private void InputReceivedHandler(object sender, string inputString)
        {    

            Commands foundCommand = null;
            foreach (Commands command in Commands.Values)
            {
                if (command.Verbs.Contains(inputString.Trim()))
                {
                    foundCommand = command;
                    break;
                }
            }

            Room previousRoom = Player.Location;
            if (foundCommand != null)
            {
                Player.Moves++;
                if (previousRoom != Player.Location)
                {
                    Look(this);
                    previousRoom = Player.Location;
                }

                foundCommand.Action(this);
            }
            else
            {
                Output.WriteLine("That's not a verb I recognize.");
            }


        }

        private void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                Output.WriteLine("The way is shut!");
            }
        }

        public void Look(Game game) => Output.WriteLine($"{game.Player.Location}\n {game.Player.Location.Description}");

        private static void Quit(Game game) => game.isRunning = false;

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => Player = new Player(World, StartingLocation);

        private void Reward(Game game)
        {
            game.Player.Score++;
            Output.WriteLine($"Your score would be {game.Player.Score} in {game.Player.Moves} move(s). ");
        }
    }
}
