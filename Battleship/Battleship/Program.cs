//Amy Brown, Ben Etheredge, Benz McGahey
//CS 315 - Spring 2016
//Due: Tuesday April 26, 2016
//Project 5: Battleship

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Battleship
{
    static class Program
    {
        
            //Battleship batShip = new Battleship();
            //batShip.Play();
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

    
}
