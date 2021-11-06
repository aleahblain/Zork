using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Zork.Common;

namespace Zork.Builder.UserControls
{
    public partial class NeighborControls : UserControl
    {
        private Room mRoom;
        private Directions mDirections;
        public static readonly Room NoRoom = new Room() { Name = "None", Description = "None" };

        public NeighborControls()
        {
            InitializeComponent();
        }

        public Room CurrentNeighbor
        {
            get => (Room)NeighborsComboBox.SelectedItem;
            set => NeighborsComboBox.SelectedItem = value;
        }

        public Directions Directions
        {
            get => mDirections;
            set
            {

            }
        }

        public Room Room
        {
            get => mRoom;
            set
            {
                if(mRoom != value)
                {
                    mRoom = value;
                    if(Room != null)
                    {
                        var neighbors = new List<Room>((IEnumerable<Room>)mRoom.Neighbors);
                        neighbors.Insert(0, NoRoom);
                        NeighborsComboBox.SelectedIndexChanged -= NeighborsComboBox_SelectedIndexChanged;
                        NeighborsComboBox.DataSource = neighbors;
                        if(mRoom.Neighbors.TryGetValue(Directions, out Room neighbor))
                        {
                            CurrentNeighbor = neighbor;
                        } else
                        {
                            CurrentNeighbor = NoRoom;
                        }

                        NeighborsComboBox.SelectedIndexChanged += NeighborsComboBox_SelectedIndexChanged;
                    }
                } 
            }
        }
        public NeighborControls(Directions direction , Room room)
        {
            Directions = direction;
            Room = room ?? throw new ArgumentNullException(nameof(room));
        }

        private void NeighborsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mRoom != null)
            {
                Room selectedRoom = (Room)NeighborsComboBox.SelectedItem;
                if(selectedRoom == NoRoom)
                {
                    mRoom.Neighbors.Remove(mDirections);
                } else
                {
                    mRoom.Neighbors[mDirections] = selectedRoom;
                }
            }
        }

    }
}
