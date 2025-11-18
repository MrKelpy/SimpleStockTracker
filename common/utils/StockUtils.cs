using System.Collections.Generic;
using System.IO;
using System.Linq;
using LaminariaCore_General.utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleStockTracker.common.models;

namespace SimpleStockTracker.common.utils
{
    /// <summary>
    /// This class contains utility functions for stock data processing, be it for
    /// the reading and parsing of stock data from the config or writing.
    /// </summary>
    public class StockUtils
    {
        
        /// <summary>
        /// Retrieves all registered brands from the config data.
        /// </summary>
        /// <returns>A list of all registered brands.</returns>
        public static List<Brand> GetBrands() => Directory.GetFiles(Program.AppDataPath + "brands/").Select(brandPath => new Brand(brandPath)).ToList();
        
        /// <summary>
        /// Creates a new brand config file in the app data path, effectively registering it.
        /// </summary>
        /// <param name="brandName">The brand name to register</param>
        public static void RegisterNewBrand(string brandName)
        {
            string brandConfigPath = Path.Combine(Program.AppDataPath, "brands", brandName + ".json");
            
            if (!File.Exists(brandConfigPath))
                File.WriteAllText(brandConfigPath, @"{}");
        }
        
    }
}