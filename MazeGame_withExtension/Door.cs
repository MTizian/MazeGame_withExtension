using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class Door : Item
    {
        private bool locked = true;
        private string baseName;
        Room startRoom, endRoom;
        char startDirection, targetDirection;




        public Door(string name, Room startRoom, char startDirection, Room endRoom, char endDirection) : base(name, false)
        {

            this.baseName = name;
            this.startRoom = startRoom;
            this.endRoom = endRoom;
            this.startDirection = startDirection;
            this.targetDirection = endDirection;

            if (this.locked) { SetName(name + "(locked)"); }


            UpdateName();
        }
        private void UpdateName()
        {
            //Adding statename to basename
            if (this.locked)
            {
                SetName(this.baseName + " (locked)");
            }
            else
            {
                SetName(this.baseName + " (unlocked)");
            }
        }
        public void toogleLock()
        {
            //change Locked state 
            this.locked = !this.locked;
            UpdateName();

            //Connecting Rooms from both sides
            this.startRoom.ConnectRoom(this.endRoom, this.targetDirection);
            this.endRoom.ConnectRoom(this.startRoom, this.startDirection);
        }
        public Room getRoom() { return this.startRoom; }
    }
}
