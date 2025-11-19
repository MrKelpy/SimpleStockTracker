using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SimpleStockTracker.common.models;

namespace SimpleStockTracker.common.utils
{
    public static class ReportGenerator
    {
        /// <summary>
        /// Generates a plain text stock report for all brands and their products.
        /// </summary>
        public static string GenerateStockReport()
        {
            List<Brand> brands = StockUtils.GetBrands();

            var sb = new StringBuilder();

            // Title and generation date
            sb.AppendLine("RELATÓRIO DE STOCK");
            sb.AppendLine($"DATA: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine(new string('-', 40));

            // Brand and products
            foreach (Brand brand in brands)
            {
                sb.AppendLine($"Marca: {brand.Name}");
                var products = brand.GetProducts();
                if (products != null)
                {
                    foreach (var product in products)
                        sb.AppendLine($" - {product.Name}: {product.Quantity}");
                }
                sb.AppendLine(); // Empty line between brands
            }

            return sb.ToString();
        }
    }
}