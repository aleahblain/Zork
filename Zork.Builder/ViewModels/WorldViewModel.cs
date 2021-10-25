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

        public World World
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
