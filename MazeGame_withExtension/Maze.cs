using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class Maze
    {
        private Room startRoom, winningRoom, losingRoom;

        public Maze()
        {
            Room kitchen = new Room("Kitchen");
            Room livingRoom = new Room("Living Room");
            Room bathroom = new Room("Bathroom");
            Room bedRoom = new Room("Bedroom");
            Room chamber = new Room("Torture Chamber");
            Room exitRoom = new Room("Exit Room");



            kitchen.setConnectedRooms(null, null, null, null);
            bathroom.setConnectedRooms(null, bedRoom, null, null);
            livingRoom.setConnectedRooms(null, null, bedRoom, null);
            bedRoom.setConnectedRooms(livingRoom, null, chamber, bathroom);
            chamber.setConnectedRooms(bedRoom, null, null, null);
            exitRoom.setConnectedRooms(null, null, null, null);


            this.startRoom = bathroom;
            this.winningRoom = exitRoom;
            this.losingRoom = chamber;



            ///////////////Items
            ///

            Door redDoor = new Door("Red Door", bathroom, 'S', kitchen, 'N');

            Key redKey = new Key("Red Key", redDoor);


            //Key redKey2 = new Key("Red Key 2", redDoor2);
            //TimeBomb timeBomb = new TimeBomb();

            Door blueDoor = new Door("Blue Door", livingRoom, 'W', exitRoom, 'E');
            Key blueKey = new Key("Blue Key", blueDoor);



            BrickWall brickwall = new BrickWall("Brickwall East", livingRoom, 'E', kitchen, 'W');




            kitchen.addContent(new WoodenStick());


            livingRoom.addContent(blueDoor);
            exitRoom.addContent(blueDoor);


            bathroom.addContent(redDoor);
            kitchen.addContent(redDoor);

            kitchen.addContent(brickwall);

            //bedRoom.addContent(redKey2);
            bedRoom.addContent(redKey);
            kitchen.addContent(blueKey);

        }

        public Room getStartRoom() { return this.startRoom; }

        public Room getWinningRoom() { return this.winningRoom; }

        public Room getLosingRoom() { return this.losingRoom; }
    }

}
