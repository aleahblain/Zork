using System;
using System.ComponentModel;
using Zork;

namespace Zork.Builder.ViewModels
{
    internal class WorldViewModel
    {

        public bool _WorldIsLoaded;
        public BindingList<Room> _Rooms;
        private World _world;
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

        public WorldViewModel(World world = null)
        {
            World = world;
        }

        public bool WorldIsLoaded
        {
            get
            {
                return _WorldIsLoaded;
            }

            set
            {   
                if (_WorldIsLoaded != value)
                {
                    _WorldIsLoaded = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WorldIsLoaded)));
                }
            }
        }

<<<<<<< HEAD:Zork.Builder/ViewModels/GameViewModel.cs
        public void SaveWorld(string filename)
        {
            if (!WorldIsLoaded)
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
                serializer.Serialize(jsonWriter, _world);
            }
        }

<<<<<<< HEAD:Zork.Builder/ViewModels/GameViewModel.cs
        public Game Game
=======
        public World World
>>>>>>> parent of 1c3ff37 (Zork Builder (IN PROGRESS)):Zork.Builder/ViewModels/WorldViewModel.cs
=======
        public World World
>>>>>>> parent of 0b242a5 (Zork Builder (IN PROGRESS)):Zork.Builder/ViewModels/WorldViewModel.cs
        {
            set
            {
                if(_world != value)
                {
                    _world = value;
                    if(_world != null)
                    {
                        //Rooms = new BindingList<Room>(_world.Rooms);

                    } else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }
    }
}
