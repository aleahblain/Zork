using Newtonsoft.Json;
using System;
using System.IO;

namespace Zork
{
    class Program
    {
        private enum CommandLineArguments
        {
            GameFilename = 0
        }

        static void Main(string[] args)
        {

            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);
            
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();

            game.Player.LocationChanged += Player_LocationChanged;

            output.WriteLine(string.IsNullOrWhiteSpace(game.WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);
            game.Start(input, output);

            Room previousRoom = null;
            while (game.IsRunning)
            {

                output.WriteLine(game.Player.Location);
                if (previousRoom != game.Player.Location)
                {
                    Game.Look(game);
                    previousRoom = game.Player.Location;
                }

                output.Write("\n> ");
                input.ProcessInput();
            }

            output.WriteLine(string.IsNullOrWhiteSpace(game.ExitMessage) ? "Thanks for playing!" : ExitMessage);

        }

        private static void Player_LocationChanged(object sender, Room e)
        {
            Console.WriteLine($"You moved to {e.Name}");
        }
    }
}
