using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
                        var neighbors = new List<Room>(mRoom.Neighbors);
                        neighbors.Insert(0, NoRoom);
                        NeighborsComboBox.SelectedIndexChanged -= NeighborsComboBox_SelectedIndexChanged;

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

        }

    }
}
