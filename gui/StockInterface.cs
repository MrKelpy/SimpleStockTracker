using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SimpleStockTracker.common.models;
using SimpleStockTracker.common.utils;

namespace SimpleStockTracker.gui
{
    /// <summary>
    /// This interface is responsible for displaying and managing stock items for a selected brand.
    /// </summary>
    public partial class StockInterface : Form
    {
        
        /// <summary>
        /// The brand associated with this stock interface.
        /// </summary>
        private Brand Brand { get; set; }
        
        public StockInterface(Brand brand)
        {
            this.Brand = brand;
            this.InitializeComponent();
            this.BuildProductListLayout();
        }

        /// <summary>
        /// Adds the products of the brand to the data grid view layout.
        /// </summary>
        private void BuildProductListLayout()
        {
            this.SuspendLayout();
            this.DataGrid.Rows.Clear();
            List<Product> products = this.Brand.GetProducts();

            foreach (Product product in products)
                this.DataGrid.Rows.Add(product.Name, product.Quantity);
            
            // Sort the data grid by product name
            this.DataGrid.Sort(this.DataGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            this.ResumeLayout(true);
            
            // Change the button colour to red for the delete button and add the handlers for the increment/decrement buttons
            foreach (DataGridViewRow row in this.DataGrid.Rows)
            {
                DataGridViewCell deleteCell = row.Cells[this.DataGrid.Columns.Count - 1];
                deleteCell.Style.BackColor = Color.Firebrick;
                deleteCell.Style.ForeColor = Color.White;
            }
        }


        /// <summary>
        /// Adds a product to the stock.
        /// </summary>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            NewItemDialog dialog = new NewItemDialog(false);
            dialog.ShowDialog();

            if (dialog.DialogResult != DialogResult.OK) return;
            
            Product product = new Product(dialog.ItemNameResult, dialog.ItemQuantityResult);
            this.Brand.SetProduct(product);
            this.BuildProductListLayout();
        }
        
        /// <summary>
        /// Handles the increment button click event in the data grid view.
        /// </summary>

        private void HandleQuantityChange(object sender, DataGridViewCellEventArgs e, int value)
        {
            string gridProductName = this.DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            int factoredValue = int.Parse(textBoxFactor.Text) * value;
            Product product = new Product(gridProductName, this.Brand.GetProducts().First(p => p.Name == gridProductName).Quantity + factoredValue);
            
            this.Brand.SetProduct(product);
            this.BuildProductListLayout();
        }

        /// <summary>
        /// Handles button clicks in the data grid view for incrementing, decrementing, and removing products.
        /// </summary>
        private void HandleButtonClicks(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header clicks
            
            if (e.ColumnIndex == this.DataGrid.Rows[e.RowIndex].Cells["Decrement"].ColumnIndex)
                this.HandleQuantityChange(sender, e, -1);
            
            else if (e.ColumnIndex == this.DataGrid.Rows[e.RowIndex].Cells["buttonIncrement"].ColumnIndex)
                this.HandleQuantityChange(sender, e, 1);
            
            else if (e.ColumnIndex == this.DataGrid.Rows[e.RowIndex].Cells["buttonRemove"].ColumnIndex)
            {
                string gridProductName = this.DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                Product product = new Product(gridProductName, -1);
                this.Brand.SetProduct(product);
                this.BuildProductListLayout();
            }
        }
        
        /// <summary>
        /// Only allow numbers in the factor text box.
        /// </summary>
        private void textBoxFactor_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox textBox = sender as ToolStripTextBox;
            if (textBox == null) return;

            if (!"0123456789".Contains(textBox.Text.Last()))
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }
    }
}