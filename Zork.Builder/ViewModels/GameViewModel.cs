using System;
using System.ComponentModel;
using Zork;
using Newtonsoft.Json;
using System.IO;

namespace Zork.Builder.ViewModels
{
    internal class GameViewModel : INotifyPropertyChanged
    {

        public bool _GameIsLoaded;
        public BindingList<Room> _Rooms;
        private Game _game;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }

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

        public GameViewModel(Game game = null) => Game = game;

        public void SaveWorld()
        {

            if (string.IsNullOrWhiteSpace(Filename))
            {
                throw new InvalidOperationException("Invalid name.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        public Game Game
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

        public void RemoveRoom (Room room)
        {
            foreach (Room r in Rooms)
            {
                //r.Neighbors.Remove(room);
            }

            Rooms.Remove(room);
        }
    }
}
