
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.NijiGame.Rooms
{
    /// <summary>
    /// Generates a floor
    /// </summary>
    public class FloorGenerator
    {
     
        public virtual FloorGeneratorAlgorithm GetFloorGeneratorAlgorithm()
        {
            return new FloorGeneratorAlgorithm();
        }

        public virtual List<Room> GenerateRooms(int amountOfRooms)
        {
            List<Room> rooms = new List<Room>();
            FloorGeneratorAlgorithm algorithm = GetFloorGeneratorAlgorithm();
            algorithm.Reset();
            for(int i = 0; i < amountOfRooms; i++)
            {
                rooms.Add(algorithm.GetNextRoom());
            }

            return rooms;
        }
    }
}