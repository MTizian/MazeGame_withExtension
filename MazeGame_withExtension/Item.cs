using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_withExtension
{
    internal class Item
    {
        private string name;
        private bool pickable;


        public Item(string name, bool pickable)
        {
            this.name = name;
            this.pickable = pickable;
        }


        public string getName() { return name; }

        protected void SetName(string name) { this.name = name; }

        public override string ToString() { return this.name; }

        public bool isPickable() { return this.pickable; }

        public virtual void use(Player user) { }
    }
}
