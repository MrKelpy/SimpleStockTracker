using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;

namespace SimpleStockTracker.common.models
{
    /// <summary>
    /// This class represents a registered brand in the stock tracker application.
    /// It will contain the count of every product associated with this brand.
    /// </summary>
    public class Brand
    {
        
        /// <summary>
        /// The name of the brand.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The path to the brand config file.
        /// </summary>
        public string ConfigPath { get; set; }
        
        /// <summary>
        /// The path to the image/logo of the brand.
        /// </summary>
        private string ImagePath { get; set; }
        
        /// <summary>
        /// Builds a new brand according to the config data based on the given path.
        /// </summary>
        /// <param name="path">The path to the brand config data.</param>
        public Brand(string path)
        {
            this.Name = Path.GetFileName(path);
            this.ConfigPath = path;
        }
        
        /// <summary>
        /// Gets all products associated with this brand.
        /// </summary>
        /// <returns>A list of all the registered products in the brand</returns>
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            
            // Read the JSON data from the config file
            string jsonData = File.ReadAllText(this.ConfigPath);
            JObject obj = JObject.Parse(jsonData);
            
            foreach (var product in obj)
            {
                string productName = product.Key;
                int productCount = (int) product.Value;
                
                products.Add(new Product(productName, productCount));
            }
            
            return products;
        }
    }
}