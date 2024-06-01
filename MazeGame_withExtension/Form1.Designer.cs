namespace MazeGame_withExtension
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CurrentLevel_str = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CurrentLevel_int = new System.Windows.Forms.Label();
            this.lbl_Highscore_str = new System.Windows.Forms.Label();
            this.lbl_Highscore_int = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CurrentRoom = new System.Windows.Forms.Label();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Personal_Items_Box = new System.Windows.Forms.ListBox();
            this.Items_In_Room = new System.Windows.Forms.ListBox();
            this.Button_UseItem = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_PickUpItem = new System.Windows.Forms.Button();
            this.Button_DropItem = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_MoveNorth = new System.Windows.Forms.Button();
            this.Button_MoveWest = new System.Windows.Forms.Button();
            this.Button_MoveEast = new System.Windows.Forms.Button();
            this.Button_MoveSouth = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Mission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navigate through the room of the old mansion and find the exit.";
            // 
            // lbl_CurrentLevel_str
            // 
            this.lbl_CurrentLevel_str.AutoSize = true;
            this.lbl_CurrentLevel_str.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentLevel_str.Location = new System.Drawing.Point(3, 25);
            this.lbl_CurrentLevel_str.Name = "lbl_CurrentLevel_str";
            this.lbl_CurrentLevel_str.Size = new System.Drawing.Size(97, 17);
            this.lbl_CurrentLevel_str.TabIndex = 2;
            this.lbl_CurrentLevel_str.Text = "Current Level:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_CurrentLevel_int, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Highscore_str, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_CurrentLevel_str, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Highscore_int, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(541, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 51);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_CurrentLevel_int
            // 
            this.lbl_CurrentLevel_int.AutoSize = true;
            this.lbl_CurrentLevel_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentLevel_int.Location = new System.Drawing.Point(125, 25);
            this.lbl_CurrentLevel_int.Name = "lbl_CurrentLevel_int";
            this.lbl_CurrentLevel_int.Size = new System.Drawing.Size(26, 17);
            this.lbl_CurrentLevel_int.TabIndex = 5;
            this.lbl_CurrentLevel_int.Text = "XX";
            // 
            // lbl_Highscore_str
            // 
            this.lbl_Highscore_str.AutoSize = true;
            this.lbl_Highscore_str.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Highscore_str.Location = new System.Drawing.Point(3, 0);
            this.lbl_Highscore_str.Name = "lbl_Highscore_str";
            this.lbl_Highscore_str.Size = new System.Drawing.Size(76, 17);
            this.lbl_Highscore_str.TabIndex = 3;
            this.lbl_Highscore_str.Text = "Highscore:";
            // 
            // lbl_Highscore_int
            // 
            this.lbl_Highscore_int.AutoSize = true;
            this.lbl_Highscore_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Highscore_int.Location = new System.Drawing.Point(125, 0);
            this.lbl_Highscore_int.Name = "lbl_Highscore_int";
            this.lbl_Highscore_int.Size = new System.Drawing.Size(26, 17);
            this.lbl_Highscore_int.TabIndex = 4;
            this.lbl_Highscore_int.Text = "XX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Avoid the torture chamber, because you would die instantly!";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_CurrentRoom, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Text, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 91);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lbl_CurrentRoom
            // 
            this.lbl_CurrentRoom.AutoSize = true;
            this.lbl_CurrentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_CurrentRoom.Location = new System.Drawing.Point(3, 35);
            this.lbl_CurrentRoom.Name = "lbl_CurrentRoom";
            this.lbl_CurrentRoom.Size = new System.Drawing.Size(266, 31);
            this.lbl_CurrentRoom.TabIndex = 7;
            this.lbl_CurrentRoom.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Text.Location = new System.Drawing.Point(3, 0);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(136, 17);
            this.lbl_Text.TabIndex = 6;
            this.lbl_Text.Text = "You are currently in:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.48905F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.51095F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Personal_Items_Box, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Items_In_Room, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Button_UseItem, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 180);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.92271F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 258);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your Inventory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "The Room contains:";
            // 
            // Personal_Items_Box
            // 
            this.Personal_Items_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Personal_Items_Box.FormattingEnabled = true;
            this.Personal_Items_Box.ItemHeight = 16;
            this.Personal_Items_Box.Location = new System.Drawing.Point(3, 28);
            this.Personal_Items_Box.Name = "Personal_Items_Box";
            this.Personal_Items_Box.Size = new System.Drawing.Size(184, 164);
            this.Personal_Items_Box.TabIndex = 10;
            // 
            // Items_In_Room
            // 
            this.Items_In_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Items_In_Room.FormattingEnabled = true;
            this.Items_In_Room.ItemHeight = 16;
            this.Items_In_Room.Location = new System.Drawing.Point(323, 28);
            this.Items_In_Room.Name = "Items_In_Room";
            this.Items_In_Room.Size = new System.Drawing.Size(149, 164);
            this.Items_In_Room.TabIndex = 11;
            // 
            // Button_UseItem
            // 
            this.Button_UseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_UseItem.Location = new System.Drawing.Point(3, 210);
            this.Button_UseItem.Name = "Button_UseItem";
            this.Button_UseItem.Size = new System.Drawing.Size(184, 45);
            this.Button_UseItem.TabIndex = 12;
            this.Button_UseItem.Text = "Use";
            this.Button_UseItem.UseVisualStyleBackColor = true;
            this.Button_UseItem.Click += new System.EventHandler(this.Button_UseItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Button_PickUpItem);
            this.flowLayoutPanel1.Controls.Add(this.Button_DropItem);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(193, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 176);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // Button_PickUpItem
            // 
            this.Button_PickUpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_PickUpItem.Location = new System.Drawing.Point(3, 3);
            this.Button_PickUpItem.Name = "Button_PickUpItem";
            this.Button_PickUpItem.Size = new System.Drawing.Size(121, 45);
            this.Button_PickUpItem.TabIndex = 13;
            this.Button_PickUpItem.Text = "< Pick Up";
            this.Button_PickUpItem.UseVisualStyleBackColor = true;
            this.Button_PickUpItem.Click += new System.EventHandler(this.Button_PickUpItem_Click);
            // 
            // Button_DropItem
            // 
            this.Button_DropItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_DropItem.Location = new System.Drawing.Point(3, 54);
            this.Button_DropItem.Name = "Button_DropItem";
            this.Button_DropItem.Size = new System.Drawing.Size(121, 45);
            this.Button_DropItem.TabIndex = 14;
            this.Button_DropItem.Text = "Drop >";
            this.Button_DropItem.UseVisualStyleBackColor = true;
            this.Button_DropItem.Click += new System.EventHandler(this.Button_DropItem_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.Button_MoveNorth, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Button_MoveWest, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Button_MoveEast, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.Button_MoveSouth, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(541, 180);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(247, 258);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // Button_MoveNorth
            // 
            this.Button_MoveNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_MoveNorth.Location = new System.Drawing.Point(85, 3);
            this.Button_MoveNorth.Name = "Button_MoveNorth";
            this.Button_MoveNorth.Size = new System.Drawing.Size(76, 80);
            this.Button_MoveNorth.TabIndex = 15;
            this.Button_MoveNorth.Text = "North";
            this.Button_MoveNorth.UseVisualStyleBackColor = true;
            this.Button_MoveNorth.Click += new System.EventHandler(this.Button_MoveNorth_Click);
            // 
            // Button_MoveWest
            // 
            this.Button_MoveWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_MoveWest.Location = new System.Drawing.Point(3, 89);
            this.Button_MoveWest.Name = "Button_MoveWest";
            this.Button_MoveWest.Size = new System.Drawing.Size(76, 80);
            this.Button_MoveWest.TabIndex = 16;
            this.Button_MoveWest.Text = "West";
            this.Button_MoveWest.UseVisualStyleBackColor = true;
            this.Button_MoveWest.Click += new System.EventHandler(this.Button_MoveWest_Click);
            // 
            // Button_MoveEast
            // 
            this.Button_MoveEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_MoveEast.Location = new System.Drawing.Point(167, 89);
            this.Button_MoveEast.Name = "Button_MoveEast";
            this.Button_MoveEast.Size = new System.Drawing.Size(77, 80);
            this.Button_MoveEast.TabIndex = 17;
            this.Button_MoveEast.Text = "East";
            this.Button_MoveEast.UseVisualStyleBackColor = true;
            this.Button_MoveEast.Click += new System.EventHandler(this.Button_MoveEast_Click);
            // 
            // Button_MoveSouth
            // 
            this.Button_MoveSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_MoveSouth.Location = new System.Drawing.Point(85, 175);
            this.Button_MoveSouth.Name = "Button_MoveSouth";
            this.Button_MoveSouth.Size = new System.Drawing.Size(76, 80);
            this.Button_MoveSouth.TabIndex = 18;
            this.Button_MoveSouth.Text = "South";
            this.Button_MoveSouth.UseVisualStyleBackColor = true;
            this.Button_MoveSouth.Click += new System.EventHandler(this.Button_MoveSouth_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(810, 480);
            this.Name = "MainWindow";
            this.Text = "Maze Game with Extension";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_CurrentLevel_str;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Highscore_str;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Highscore_int;
        private System.Windows.Forms.Label lbl_CurrentLevel_int;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_CurrentRoom;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Personal_Items_Box;
        private System.Windows.Forms.ListBox Items_In_Room;
        private System.Windows.Forms.Button Button_UseItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Button_PickUpItem;
        private System.Windows.Forms.Button Button_DropItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Button_MoveNorth;
        private System.Windows.Forms.Button Button_MoveWest;
        private System.Windows.Forms.Button Button_MoveEast;
        private System.Windows.Forms.Button Button_MoveSouth;
    }
}

