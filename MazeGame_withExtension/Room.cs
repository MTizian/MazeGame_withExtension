using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class Room
    {
        public string roomName = "unknown";
        public int numDoors;
        public string[] items;
        public bool isExit = false;
        private Room northRoom, eastRoom, southRoom, westRoom;
        private List<Item> content;

        private bool NorthWall, EastWall, SouthWall, WestWall;


        public Room(string roomName) { this.roomName = roomName; }
        public void addContent(Item item)
        {
            if (content == null)
            {
                content = new List<Item>();
            }
            content.Add(item);
        }

        public List<Item> getContent() { return content; }


        public void setConnectedRooms(Room north, Room east, Room south, Room west)
        {
            //set references here
            this.northRoom = north;
            this.eastRoom = east;
            this.southRoom = south;
            this.westRoom = west;

            UpdateWalls();

        }

        private void UpdateWalls()
        {
            this.NorthWall = (this.northRoom == null);
            this.EastWall = (this.eastRoom == null);
            this.SouthWall = (this.southRoom == null);
            this.WestWall = (this.westRoom == null);
        }

        public void ConnectRoom(Room room, char direction)
        {
            switch (direction)
            {
                case 'N':
                    this.northRoom = room;
                    break;
                case 'E':
                    this.eastRoom = room;
                    break;
                case 'S':
                    this.southRoom = room;
                    break;
                case 'W':
                    this.westRoom = room;
                    break;
                default:
                    break;
            }

            UpdateWalls();
        }


        public string getRoomName()
        {
            return this.roomName;
        }

        public Room getConnectedRoom(char direction)
        {
            direction = Char.ToUpper(direction);

            switch (direction)
            {
                case 'N':
                    return this.northRoom;
                case 'E':
                    return this.eastRoom;
                case 'S':
                    return this.southRoom;
                case 'W':
                    return this.westRoom;
                default:
                    return null;
            }
        }


















        public void EnterRoom()
        {
            Console.WriteLine("You are in the {0}.", roomName);
        }

        public bool IsExitRoom()
        {
            return isExit;
        }



        public bool CheckForItems()
        {
            if (this.content != null && this.content.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool CanMove(char direction)
        {

            switch (direction)
            {
                case 'N':
                    return !this.NorthWall;
                case 'E':
                    return !this.EastWall;
                case 'S':
                    return !this.SouthWall;
                case 'W':
                    return !this.WestWall;
                default:
                    return false;
            }
        }
    }
}
