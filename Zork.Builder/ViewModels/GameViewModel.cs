using System;
using System.ComponentModel;
using Zork;

namespace Zork.Builder.ViewModels
{
    internal class GameViewModel
    {

        public bool _GameIsLoaded;
        public BindingList<Room> _Rooms;
        private Game _game;
        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Room> Rooms
        {
            get
            {
                return _Rooms;
            }
            set
            {
                if(_Rooms != value)
                {
                    _Rooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Rooms)));
                }
            }
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        public bool GameIsLoaded
        {
            get
            {
                return _GameIsLoaded;
            }

            set
            {   
                if (_GameIsLoaded != value)
                {
                    _GameIsLoaded = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GameIsLoaded)));
                }
            }
        }

<<<<<<< HEAD:Zork.Builder/ViewModels/GameViewModel.cs
        public void SaveWorld(string filename)
        {
            if (!GameIsLoaded)
            {
                throw new InvalidOperationException("No world is loaded.");
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidOperationException("Invalid name.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        public Game Game
=======
        public World World
>>>>>>> parent of 1c3ff37 (Zork Builder (IN PROGRESS)):Zork.Builder/ViewModels/WorldViewModel.cs
        {
            set
            {
                if(_game != value)
                {
                    _game = value;
                    if(_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);

                    } else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }
    }
}
