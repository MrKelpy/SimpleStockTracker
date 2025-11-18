using System;
using System.Windows.Forms;
using LaminariaCore_General.utils;
using SimpleStockTracker.common.models;
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
            FileUtils.EnsurePath(AppDataPath + "/brands/");
            FileUtils.EnsurePath(AppDataPath + "/brand_images/");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BrandSelectorInterface());
        }
    }
}