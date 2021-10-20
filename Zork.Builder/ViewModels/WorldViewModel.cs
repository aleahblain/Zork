using System;
using System.ComponentModel;
using Zork;

namespace Zork.Builder.ViewModels
{
    public class WorldViewModel
    {
        public BindingList<Room> Rooms { get; set; }

        private World _world;

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
