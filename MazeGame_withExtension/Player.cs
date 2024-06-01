using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class Player
    {
        private Room currentRoom;
        private List<Item> bag;
        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }

        public List<Item> getBag()
        {
            if (bag == null)
            {
                bag = new List<Item>();
            }
            return bag;
        }
        public bool CheckForItems()
        {
            if (this.bag != null && this.bag.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Room getCurrentRoom() { return this.currentRoom; }
        public bool move(char direction)
        {
            Room nextRoom = currentRoom.getConnectedRoom(direction);

            if (nextRoom != null)
            {
                currentRoom = nextRoom;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
