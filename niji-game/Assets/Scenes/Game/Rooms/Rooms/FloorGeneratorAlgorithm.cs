using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ervean.NijiGame.Rooms
{
    /// <summary>
    /// This ones simple and just does it from purely chance
    /// </summary>
    public class FloorGeneratorAlgorithm 
    {
        private class Settings
        {
            public RoomTypes RoomType = RoomTypes.None;
            public float Weight;
        }

        private List<Room> generatedRooms = new List<Room>();

        private Dictionary<RoomTypes, Settings> map = new Dictionary<RoomTypes, Settings>();


        public Room GetNextRoom()
        {
            return null;
        }

        public void Reset()
        {
            generatedRooms.Clear();
        }
    }
}