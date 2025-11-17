namespace SimpleStockTracker.common.models
{
    /// <summary>
    /// This class represents a product in the stock tracker application.
    /// </summary>
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        
        /// <summary>
        /// Builds a new product with the given name and quantity.
        /// </summary>
        /// <param name="name">The name of the product</param>
        /// <param name="quantity">The remaining stock</param>
        public Product(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}