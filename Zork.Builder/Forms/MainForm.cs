using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork;
using Zork.Builder.Forms;
using Zork.Builder.UserControls;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    internal interface IBlinkable
    {
        int Frequency { get; }
    }

    public partial class MainForm : Form
    {

        private GameViewModel _viewModel;
        private Control[] _worldDependentControls;
        private ToolStripMenuItem[] _worldDependentMenuItems;
        private readonly Dictionary<Directions, NeighborControls> mNeighborsControlMap;
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();

            _worldDependentControls = new Control[]
            {
                RoomsAddButton,
                RoomsDeleteButton
            };

            _worldDependentMenuItems = new ToolStripMenuItem[]
            {
                saveToolStripMenuItem,
                saveAsToolStripMenuItem,
            };

            IsGameLoaded = false;
        }

        internal GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if(_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        private bool IsGameLoaded
        {
            get
            {
                return _viewModel.GameIsLoaded;
            }
            set
            {
                _viewModel.GameIsLoaded = value;

                foreach(var control in _worldDependentControls)
                {
                    control.Enabled = _viewModel.GameIsLoaded;
                }

                foreach (var menuItem in _worldDependentMenuItems)
                {
                    menuItem.Enabled = _viewModel.GameIsLoaded;
                }
            }
        }

        private void RoomsDeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                    ViewModel.GameIsLoaded = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                
            }
        }

        private void RoomsAddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if(addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomsDeleteButton.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach(var entry in mNeighborsControlMap)
            {
                entry.Value.Room = selectedRoom;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
=======
>>>>>>> parent of 1c3ff37 (Zork Builder (IN PROGRESS))
        }
    }
}
