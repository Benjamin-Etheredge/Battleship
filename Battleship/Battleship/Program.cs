using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Battleship
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Battleship
    {
        private int[,] humanBoard;
        private int[,] computerBoard;

        private int EMPTY_SEA = 0;
        private int ATTACKED = 1;
        private int PATROL_BOAT = 2;
        private int DESTROYER = 3;
        private int SUBMARINE = 4;
        private int BATTLESHIP = 5;
        private int AIRCRAFT_CARRIER = 6;

        private bool humanTurn = true;

        public Battleship()
        {
            
        }

        public int attemptFire(int x, int y)
        {
            int returnValue = 1;
            if(humanTurn)
            {
                if (humanBoard[x,y])
                humanBoard[x,y] = 
            }
            else
            {
                if (computerBoard[x,y] != 1)
                {
                    int temp = computerBoard[x, y];
                    computerBoard[x, y] = 1;
                }
            }
        }



    }

}
