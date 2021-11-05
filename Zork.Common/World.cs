﻿using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Zork
{
    public class World
    {
        public HashSet<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach(Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

    }
}