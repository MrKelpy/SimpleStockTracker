using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleStockTracker.gui;

namespace SimpleStockTracker
{
    static class Program
    {
        
        /// <summary>
        /// The path to the application data folder.
        /// </summary>
        public static String AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SimpleStockTracker\\";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainframe());
        }
    }
}