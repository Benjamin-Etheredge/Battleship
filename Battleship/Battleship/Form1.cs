using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
    {
        private Button[][] buttons;
        private Battleship game;


        public Form1()
        {
            game = new Battleship();
            dynamic_InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //game.Play();
        }

        private void dynamic_InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            buttons = new Button[10][];

            for (int i = 0; i < 10; i++)
            {
                buttons[i] = new Button[10];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i][j] = new Button();
                }
            }

            //button91 = new Button()
            Clear = new Button();
            Vertical = new RadioButton();
            Horizontal = new RadioButton();
            ((ISupportInitialize)(splitContainer1)).BeginInit();
            this.Vertical = new System.Windows.Forms.RadioButton();
            this.Horizontal = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PTB = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.DEST = new System.Windows.Forms.RadioButton();
            this.BATT = new System.Windows.Forms.RadioButton();
            this.AC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    splitContainer1.Panel1.Controls.Add(buttons[i][j]);
                }
            }
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Play);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.Clear);
            this.splitContainer1.Size = new System.Drawing.Size(770, 385);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 103;
            // 
            // button91
            // 
            int n = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i][j].Location = new Point(75*i, 23*j);
                    buttons[i][j].Name = "button" + n.ToString();
                    buttons[i][j].Size = new Size(75, 23);
                    buttons[i][j].TabIndex = 199;
                    buttons[i][j].UseVisualStyleBackColor = true;
                    buttons[i][j].Click += new EventHandler(button1_Click);
                    n++;
                }
            }

            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(662, 24);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 105;
            this.Clear.Text = "Clear Ships";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(570, 24);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 108;
            this.Play.Text = "Play!";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.button102_Click);
            // 
            // Vertical
            // 
            this.Vertical.AutoSize = true;
            this.Vertical.Location = new System.Drawing.Point(101, 21);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(60, 17);
            this.Vertical.TabIndex = 104;
            this.Vertical.TabStop = true;
            this.Vertical.Text = "Vertical";
            this.Vertical.UseVisualStyleBackColor = true;
            // 
            // Horizontal
            // 
            this.Horizontal.AutoSize = true;
            this.Horizontal.Checked = true;
            this.Horizontal.Location = new System.Drawing.Point(9, 21);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(72, 17);
            this.Horizontal.TabIndex = 103;
            this.Horizontal.TabStop = true;
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Horizontal);
            this.panel1.Controls.Add(this.Vertical);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 74);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AC);
            this.panel2.Controls.Add(this.BATT);
            this.panel2.Controls.Add(this.DEST);
            this.panel2.Controls.Add(this.Sub);
            this.panel2.Controls.Add(this.PTB);
            this.panel2.Location = new System.Drawing.Point(214, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 74);
            this.panel2.TabIndex = 107;
            // 
            // PTB
            // 
            this.PTB.AutoSize = true;
            this.PTB.Checked = true;
            this.PTB.Location = new System.Drawing.Point(3, 16);
            this.PTB.Name = "PTB";
            this.PTB.Size = new System.Drawing.Size(64, 17);
            this.PTB.TabIndex = 0;
            this.PTB.TabStop = true;
            this.PTB.Text = "PT Boat";
            this.PTB.UseVisualStyleBackColor = true;
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(50, 45);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 17);
            this.Sub.TabIndex = 1;
            this.Sub.TabStop = true;
            this.Sub.Text = "Submarine";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // DEST
            // 
            this.DEST.AutoSize = true;
            this.DEST.Location = new System.Drawing.Point(120, 16);
            this.DEST.Name = "DEST";
            this.DEST.Size = new System.Drawing.Size(70, 17);
            this.DEST.TabIndex = 2;
            this.DEST.TabStop = true;
            this.DEST.Text = "Destroyer";
            this.DEST.UseVisualStyleBackColor = true;
            // 
            // BATT
            // 
            this.BATT.AutoSize = true;
            this.BATT.Location = new System.Drawing.Point(173, 45);
            this.BATT.Name = "BATT";
            this.BATT.Size = new System.Drawing.Size(71, 17);
            this.BATT.TabIndex = 3;
            this.BATT.TabStop = true;
            this.BATT.Text = "Battleship";
            this.BATT.UseVisualStyleBackColor = true;
            // 
            // AC
            // 
            this.AC.AutoSize = true;
            this.AC.Location = new System.Drawing.Point(243, 16);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(91, 17);
            this.AC.TabIndex = 4;
            this.AC.TabStop = true;
            this.AC.Text = "Aircraft Carrier";
            this.AC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region get Coordinates
            int xCoord = 0;
            int yCoord = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (sender.Equals(buttons[i][j]))
                    {
                        xCoord = i;
                        yCoord = j;
                    }
                }
            }
            #endregion

            #region place Boat
            if (!game.boardsAreSet)
            {
                #region get Orientation
                Battleship.Orientation direction;
                if (Horizontal.Checked.Equals(true))
                {
                    direction = (Battleship.Orientation)0;
                }
                else
                {
                    direction = (Battleship.Orientation)1;
                }
                #endregion

                #region get Boat
                int boat = 0;
                if (PTB.Checked.Equals(true))
                {
                    boat = 2;
                }
                else if (DEST.Checked.Equals(true))
                {
                    boat = 3;
                }
                else if (Sub.Checked.Equals(true))
                {
                    boat = 4;
                }
                else if (BATT.Checked.Equals(true))
                {
                    boat = 5;
                }
                else
                {
                    boat = 6;
                }
                #endregion

                game.AttemptToPlaceShip(ref game.humanBoard, boat, direction, xCoord, yCoord);

                #region paint Boat
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (game.humanBoard[i,j].Equals(boat))
                        {
                            switch (boat)
                            {
                                case 2:
                                    buttons[i][j].BackColor = Color.AliceBlue;
                                    break;
                                case 3:
                                    buttons[i][j].BackColor = Color.Red;
                                    break;
                                case 4:
                                    buttons[i][j].BackColor = Color.PaleGreen;
                                    break;
                                case 5:
                                    buttons[i][j].BackColor = Color.Orange;
                                    break;
                                case 6:
                                    buttons[i][j].BackColor = Color.Yellow;
                                    break;
                            }
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region FIRE
            else
            {
                if(game.FIRE(xCoord, yCoord) > 0)
                {
                    buttons[xCoord][yCoord].Text = "HIT";
                }
                game.humanTurn = !game.humanTurn;
            }
            #endregion
        }

        private void button102_Click(object sender, EventArgs e)
        {
            Clear.Enabled = false;
            Horizontal.Enabled = false;
            Vertical.Enabled = false;
            foreach (RadioButton r in panel2.Controls)
            {
                r.Enabled = false;
            }

            game.Play();
        }
    }
}
