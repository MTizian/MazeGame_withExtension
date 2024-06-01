using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class BrickWall : Item
    {
        private string baseName;
        Room startRoom, endRoom;
        char startDirection, targetDirection;


        public BrickWall(string baseName, Room startRoom, char startDirection, Room endRoom, char targetDirection) : base(baseName, false)
        {
            this.baseName = baseName;
            this.startRoom = startRoom;
            this.endRoom = endRoom;
            this.startDirection = startDirection;
            this.targetDirection = targetDirection;
        }


        public void Collapse()
        {
            //Connect both sides
            this.startRoom.ConnectRoom(this.endRoom, this.targetDirection);
            this.endRoom.ConnectRoom(this.startRoom, this.startDirection);
        }
    }
}
