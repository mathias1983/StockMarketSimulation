using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockMarketSimulation
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ModelSwarm ms = new ModelSwarm();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
