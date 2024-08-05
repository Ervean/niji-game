using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.NijiGame.Rooms
{
    /// <summary>
    /// There can be multiple rooms in a floor
    /// </summary>
    public class Floor : MonoBehaviour
    {
        private FloorGenerator floorGenerator;
        private List<Room> rooms = new List<Room>();
        private void Awake()
        {
            floorGenerator = new FloorGenerator();
            rooms = floorGenerator.GenerateRooms(5);
        }
    }
}