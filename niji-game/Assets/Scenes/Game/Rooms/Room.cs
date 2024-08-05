using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.NijiGame.Rooms
{
    public abstract class Room : MonoBehaviour
    {
        //Also works as the type
        private string roomName;
        public string RoomName => roomName;
        protected int id;
        public int RoomId => id;

        [SerializeField] protected Vector2Int dimensions;
        /// <summary>
        /// 0 index = top, and each increment is clock wise, with 3 index at left
        /// </summary>
        protected Room[] connectedRooms = new Room[4];

        protected bool isExitRoom = false;

        public void ConnectRoom(int index,  Room room)
        {
            if(index > 3 || index < 0)
            {
                return;
            }
            else
            {
                connectedRooms[index] = room;
            }
        }

        public void Initialize(RoomTypes roomType, bool isExitRoom)
        {
            if(roomType == RoomTypes.None)
            {
                return;
            }
            this.isExitRoom = isExitRoom;
            this.roomName = roomType.ToString();
        }

        protected virtual void AdditionalInitialize(RoomTypes roomType)
        {

        }

    }

    public enum RoomTypes
    {
        None,
        Mob,
        Boss,
        Reward
    }
}