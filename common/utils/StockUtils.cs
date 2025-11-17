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
        public static List<Brand> GetBrands() => Directory.GetFiles(Program.AppDataPath).Select(brandPath => new Brand(brandPath)).ToList();

        /// <summary>
        /// Saves the entirety of a brand's information to its file.
        /// </summary>
        public static void SaveBrandInformation(Brand brand)
        {
            JObject json = new JObject();

            // Saves each product in the brand to its dictionary so it's json-ready
            foreach (var product in brand.GetProducts())
                json[product.Name] = product.Quantity;
            
            File.WriteAllText( Program.AppDataPath, json.ToString(Formatting.Indented));
        }
        
    }
}