using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;
using SimpleStockTracker.gui;

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
            this.Name = Path.GetFileName(path).Replace(".json", "");
            this.ConfigPath = path;
            this.ImagePath = Path.Combine(Program.AppDataPath, "brand_images" , this.Name.ToLower() + ".png");
        }
        
        /// <summary>
        /// Gets the image/logo of the brand based on the name of the brand.
        /// </summary>
        /// <returns>A Bitmap object representing the picture</returns>
        public Bitmap GetImage()
        {
            if (File.Exists(this.ImagePath))
                return new Bitmap(this.ImagePath);
            
            return null;
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

        /// <summary>
        /// Sets a given product's information into the brand config file.
        /// </summary>
        /// <param name="product">The product to add into the brand</param>
        public void SetProduct(Product product)
        {
            // Read the JSON data from the config file
            string jsonData = File.ReadAllText(this.ConfigPath);
            JObject obj = JObject.Parse(jsonData);
            
            // Add the new product or remove it if the quantity is -1
            if (product.Quantity == -1  && obj.ContainsKey(product.Name))
                obj.Remove(product.Name);
            
            else obj[product.Name] = product.Quantity;
            
            // Write back to the config file
            File.WriteAllText(this.ConfigPath, obj.ToString());
        }
    }
}