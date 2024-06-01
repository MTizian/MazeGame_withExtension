using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame_withExtension
{
    public partial class MainWindow : Form
    {

        private Maze maze; // add this line
        private Player player; // add this line
        public MainWindow()
        {
            InitializeComponent();
            this.maze = new Maze(); // add this line
            this.player = new Player(maze.getStartRoom()); // add this line
            updateRoom();
        }


        private void updateRoom()
        {

            this.lbl_CurrentRoom.Text = this.player.getCurrentRoom().getRoomName();

            this.Items_In_Room.Items.Clear();

            if (player.getCurrentRoom().CheckForItems())
            {
                foreach (Item it in this.player.getCurrentRoom().getContent())
                {
                    this.Items_In_Room.Items.Add(it);
                }
            }


            this.Personal_Items_Box.Items.Clear();

            if (this.player.CheckForItems())
            {
                foreach (Item it in this.player.getBag())
                {
                    this.Personal_Items_Box.Items.Add(it);
                }
            }

            UpdateMovementButtons();
        }

        private void UpdateMovementButtons()
        {
            Room currentRoom = this.player.getCurrentRoom();

            Button_MoveNorth.Enabled = currentRoom.CanMove('N');
            Button_MoveEast.Enabled = currentRoom.CanMove('E');
            Button_MoveSouth.Enabled = currentRoom.CanMove('S');
            Button_MoveWest.Enabled = currentRoom.CanMove('W');
        }

        private void movePlayer(char direction)
        {
            bool moved = this.player.move(direction);

            if (moved)
            {
                updateRoom();

                if (this.player.getCurrentRoom() == maze.getWinningRoom())
                {
                    MessageBox.Show("Congratulations! You reached the winning room!");
                    Close();
                }
                else if (this.player.getCurrentRoom() == maze.getLosingRoom())
                {
                    MessageBox.Show("Game over! You reached the losing room!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("There is a wall in that direction.");
            }
        }

        private void Button_MoveWest_Click(object sender, EventArgs e)
        {
            movePlayer('W');
        }

        private void Button_MoveNorth_Click(object sender, EventArgs e)
        {
            movePlayer('N');
        }

        private void Button_MoveEast_Click(object sender, EventArgs e)
        {
            movePlayer('E');
        }

        private void Button_MoveSouth_Click(object sender, EventArgs e)
        {
            movePlayer('S');
        }

        private void Button_PickUpItem_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)this.Items_In_Room.SelectedItem;



            if (selectedItem == null)
            {
                MessageBox.Show("Please select an Item!");
                return;
            }

            if (selectedItem != null && !selectedItem.isPickable())
            {
                MessageBox.Show("The Item is to heavy! You cant pick it up!");
                return;
            }

            this.player.getBag().Add(selectedItem);
            this.player.getCurrentRoom().getContent().Remove(selectedItem);


            updateRoom();
        }

        private void Button_DropItem_Click(object sender, EventArgs e)
        {
            Item selcetedItem = (Item)this.Personal_Items_Box.SelectedItem;


            if (selcetedItem == null)
            {
                MessageBox.Show("Please select an Item!");
                return;
            }

            if (!selcetedItem.isPickable())
            {
                MessageBox.Show("The Item is too heavy! You can't pick it up!");
                return;
            }

            this.player.getCurrentRoom().getContent().Add(selcetedItem);
            this.player.getBag().Remove(selcetedItem);

            updateRoom();
        }

        private void Button_UseItem_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)this.Personal_Items_Box.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("You need to select the Item you want to use");
            }
            else
            {
                selectedItem.use(player);
            }

            updateRoom();
        }
    }
}
