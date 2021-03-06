using Newtonsoft.Json;
using System;

namespace Zork
{
    public class Player
    {

        public event EventHandler<Room> LocationChanged;
        public event EventHandler<int> MovesChanged;
        public event EventHandler<int> ScoreChanged;

        private Room _location;
        private int _score;
        private int _moves;

        public World World { get; }

        [JsonIgnore]
        public Room Location
        {
            get
            {
                return _location;
            }
            set
            {
                if (_location != value)
                {
                    _location = value;
                    LocationChanged?.Invoke(this, _location);
                }
            }
        }

        public int Moves
        {
            get
            {
                return _moves;
            }
             set
            {
                if (_moves != value)
                {
                    _moves = value;
                    MovesChanged?.Invoke(this, _moves);
                }
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if(value != _score)
                {
                    _score = value;
                    ScoreChanged?.Invoke(this, _score);
                }
            }
        }


        public Player(World world, string startingLocation)
        {
            Assert.IsTrue(world != null);
            Assert.IsTrue(world.RoomsByName.ContainsKey(startingLocation));
            World = world;
            Location = world.RoomsByName[startingLocation];
            Moves = 0;
            Score = 0;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);

            if (isValidMove)
                Location = destination;

            return isValidMove;
        }

    }
}