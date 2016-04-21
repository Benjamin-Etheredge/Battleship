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
