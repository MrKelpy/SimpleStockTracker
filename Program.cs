using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleStockTracker.gui;

namespace SimpleStockTracker
{
    internal static class Program
    {
        
        /// <summary>
        /// The path to the application data folder.
        /// </summary>
        public static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SimpleStockTracker\\";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainframe());
        }
    }
}