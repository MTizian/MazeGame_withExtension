using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MazeGame_withExtension
{
    internal class TimeBomb : Item
    {


        private static System.Windows.Forms.Timer timer;



        public TimeBomb(string baseName) : base(baseName, false)
        {

        }


        private void explode(object sender, EventArgs e)
        {

        }


        public override void use(Player user)
        {
            timer = new System.Windows.Forms.Timer();


        }

    }
}
