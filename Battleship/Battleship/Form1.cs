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
        //gheakldmsgnjfkadng

        public Battleship game;
        public buttonBoard computerBoard;

        public Label winBanner;

        public Form1()
        {
            game = new Battleship();
            InitializeComponent();

            winBanner = new Label();
            winBanner.BackColor = Color.White;
            winBanner.ForeColor = Color.Black;
            winBanner.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winBanner.Location = new Point(100, 150);
            winBanner.Size = new Size(145, 20);

            playerBoard.label_who.Text = "Human's ships";

            for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                {
                    playerBoard.buttons[i][j].Click += new EventHandler(button1_Click);
                }
            }
        }
                        
        private void Play_Click(object sender, EventArgs e)
        {
            Size = new Size(305, 750);
            SetDesktopLocation(0, 0);

            disableBoardButtons(playerBoard);
            //for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
            //{
            //    for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
            //    {
            //        playerBoard.buttons[i][j].Enabled = false;
            //    }
            //}

            splitContainer1.Panel2.Controls.Clear();

            computerBoard = new buttonBoard();
            computerBoard.Dock = DockStyle.Fill;
            computerBoard.label_who.Text = "Computer's ships";
            splitContainer1.Panel2.Controls.Add(computerBoard);
            splitContainer1.SplitterDistance = 334;

            game.SetupComputerBoard();

            for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                {
                    computerBoard.buttons[i][j].Click += new EventHandler(button1_Click);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            game.ClearBoards();
            for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                {
                    playerBoard.buttons[i][j].BackColor = Color.Transparent;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            #region place Boat
            if (!game.boardsAreSet)
            {
                #region get Coordinates
                int xCoord = 0;
                int yCoord = 0;

                for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
                {
                    for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                    {
                        if (sender.Equals(playerBoard.buttons[i][j]))
                        {
                            xCoord = i;
                            yCoord = j;
                        }
                    }
                }
                #endregion
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
                    boat = Battleship.PATROL_BOAT;
                }
                else if (DEST.Checked.Equals(true))
                {
                    boat = Battleship.DESTROYER;
                }
                else if (Sub.Checked.Equals(true))
                {
                    boat = Battleship.SUBMARINE;
                }
                else if (BATT.Checked.Equals(true))
                {
                    boat = Battleship.BATTLESHIP;
                }
                else
                {
                    boat = Battleship.AIRCRAFT_CARRIER;
                }
                #endregion

                game.AttemptToPlaceShip(ref game.humanBoard, boat, direction, xCoord, yCoord);

                #region paint Boat
                for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
                {
                    for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                    {
                        if (game.humanBoard[i, j].Equals(boat))
                        {
                            switch (boat)
                            {
                                case Battleship.PATROL_BOAT:
                                    playerBoard.buttons[i][j].BackColor = Color.Blue;
                                    break;
                                case Battleship.DESTROYER:
                                    playerBoard.buttons[i][j].BackColor = Color.LightPink;
                                    break;
                                case Battleship.SUBMARINE:
                                    playerBoard.buttons[i][j].BackColor = Color.PaleGreen;
                                    break;
                                case Battleship.BATTLESHIP:
                                    playerBoard.buttons[i][j].BackColor = Color.Orange;
                                    break;
                                case Battleship.AIRCRAFT_CARRIER:
                                    playerBoard.buttons[i][j].BackColor = Color.Yellow;
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
                #region get Coordinates
                int xCoord = 0;
                int yCoord = 0;

                bool foundIt = false;

                for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
                {
                    for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                    {
                        if (sender.Equals(computerBoard.buttons[i][j]))
                        {
                            xCoord = i;
                            yCoord = j;
                            foundIt = true;
                            break;
                        }
                    }
                    if (foundIt) { break; }
                }
                #endregion
                #region player's move
                bool userMoved = false;

                if (computerBoard.buttons[xCoord][yCoord].Text == string.Empty)
                {
                    if (game.FIRE(xCoord, yCoord) > Battleship.EMPTY_SEA)
                    {
                        computerBoard.buttons[xCoord][yCoord].Text = "HIT";
                        computerBoard.buttons[xCoord][yCoord].FlatAppearance.BorderSize = 2;
                        computerBoard.buttons[xCoord][yCoord].FlatAppearance.BorderColor = Color.OrangeRed;
                    }
                    else
                    {
                        computerBoard.buttons[xCoord][yCoord].Text = "MISSED";
                        computerBoard.buttons[xCoord][yCoord].FlatAppearance.BorderSize = 2;
                        computerBoard.buttons[xCoord][yCoord].FlatAppearance.BorderColor = Color.White;
                    }
                    userMoved = true;
                    checkWin();
                    //switch (game.IsWinner())
                    //{
                    //    case 0:
                    //        break;
                    //    case 1:
                    //        winBanner.Text = "HUMAN WINS!";
                    //        computerBoard.Controls.Add(winBanner);
                    //        winBanner.BringToFront();
                    //        disableBoardButtons(computerBoard);
                    //        break;
                    //    case 2:
                    //        winBanner.Text = "COMPUTER WINS!";
                    //        playerBoard.Controls.Add(winBanner);
                    //        winBanner.BringToFront();
                    //        disableBoardButtons(computerBoard);
                    //        break;
                    //}
                }
                #endregion

                #region computer's move
                if (userMoved)
                {
                    int[] computerShot = game.ComputerFIRE();

                    if (computerShot[0] > Battleship.EMPTY_SEA)
                    {
                        playerBoard.buttons[computerShot[1]][computerShot[2]].Text = "HIT";
                        playerBoard.buttons[computerShot[1]][computerShot[2]].FlatAppearance.BorderSize = 2;
                        playerBoard.buttons[computerShot[1]][computerShot[2]].FlatAppearance.BorderColor = Color.OrangeRed;
                    }
                    else
                    {
                        playerBoard.buttons[computerShot[1]][computerShot[2]].Text = "MISSED";
                        playerBoard.buttons[computerShot[1]][computerShot[2]].FlatAppearance.BorderSize = 2;
                        playerBoard.buttons[computerShot[1]][computerShot[2]].FlatAppearance.BorderColor = Color.White;
                    }
                    checkWin();
                    //switch (game.IsWinner())
                    //{
                    //    case 0:
                    //        break;
                    //    case 1:
                    //        winBanner.Text = "HUMAN WINS!";
                    //        computerBoard.Controls.Add(winBanner);
                    //        winBanner.BringToFront();
                    //        break;
                    //    case 2:
                    //        winBanner.Text = "COMPUTER WINS!";
                    //        playerBoard.Controls.Add(winBanner);
                    //        winBanner.BringToFront();
                    //        break;
                    //}
                }
                #endregion
                //game.humanTurn = !game.humanTurn;
            }
            #endregion
        }

        private void checkWin()
        {
            switch (game.IsWinner())
            {
                case 0:
                    break;
                case 1:
                    winBanner.Text = "HUMAN WINS!";
                    computerBoard.Controls.Add(winBanner);
                    winBanner.BringToFront();
                    disableBoardButtons(computerBoard);
                    break;
                case 2:
                    winBanner.Text = "COMPUTER WINS!";
                    playerBoard.Controls.Add(winBanner);
                    winBanner.BringToFront();
                    disableBoardButtons(computerBoard);
                    break;
            }
        }

        private void disableBoardButtons(buttonBoard board)
        {
            for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                {
                    board.buttons[i][j].Enabled = false;
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.ClearBoards();
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel2.Controls.Clear();
            Size = new Size(305, 536);
            splitContainer1.SplitterDistance = 311;

            game = new Battleship();

            playerBoard = new buttonBoard();
            playerBoard.label_who.Text = "Human's ships";

            for (int i = 0; i < Battleship.SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < Battleship.SIZE_OF_BOARD; j++)
                {
                    playerBoard.buttons[i][j].Click += new EventHandler(button1_Click);
                }
            }
            splitContainer1.Panel1.Controls.Add(playerBoard);
            
            splitContainer1.Panel2.Controls.Add(Play);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(Clear);
        }
    }
}
