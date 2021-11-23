using Newtonsoft.Json;
using System.IO;
using System;

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
            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
            output.WriteLine(string.IsNullOrWhiteSpace(game.WelcomeMessage) ? "Welcome to Zork!" : game.WelcomeMessage);
            game.Start(input, output);

            while (game.isRunning)
            {
                output.WriteLine(game.Player.Location);
                output.Write("\n>");
                input.GetInput();
            }

            output.WriteLine("Thank you for playing!");
        }

    }
}
