using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class Key : Item
    {
        private Door possibleDoor;


        public Key(string name, Door relatedDoor) : base(name, true)
        {
            this.possibleDoor = relatedDoor;
        }

        public override void use(Player user)
        {
            if (user.getCurrentRoom() == possibleDoor.getRoom())
            {
                possibleDoor.toogleLock();

            }


        }
    }
}
