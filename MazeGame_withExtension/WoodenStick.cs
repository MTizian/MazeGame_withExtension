using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class WoodenStick : Item
    {
        public WoodenStick() : base("Wooden Stick", true)
        {

        }

        public override void use(Player player)
        {
            WoodenStick newWoodenStick = new WoodenStick();

            player.getBag().Add(newWoodenStick);
        }
    }
}
