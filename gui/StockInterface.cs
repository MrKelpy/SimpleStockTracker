using System.Collections.Generic;
using System.Drawing;
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
        /// Builds the panel layout containing product details (name, quantity)
        /// and buttons (+, -, X) stacked vertically, with buttons anchored right.
        /// </summary>
        public void BuildProductListLayout()
        {
            // Assuming a similar utility method exists for products
            List<Product> products = this.Brand.GetProducts();

            this.Frame.Controls.Clear(); // IMPORTANT: to avoid duplicates

            // --- Handle Empty List ---
            if (products.Count == 0)
            {
                Label noProductsLabel = new Label
                {
                    Text = @"Não existem produtos no carrinho.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 14F)
                };

                this.Frame.Controls.Add(noProductsLabel);
                return;
            }

            // --- Configuration Constants (adjust as needed) ---
            const int itemHeight = 40;
            const int buttonWidth = 40;
            const int margin = 5;

            // A wrapper to contain all product panels and allow scrolling if necessary
            Panel listWrapper = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true, 
                Padding = new Padding(margin)
            };

            int currentY = 0;
            // Account for the listWrapper's padding (margin * 2)
            int panelWidth = this.Frame.ClientSize.Width - (2 * margin); 

            // --- Create Panels for Each Product ---
            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];

                // 1. Container for the single product row (productPanel)
                Panel productPanel = new Panel
                {
                    Width = panelWidth,
                    Height = itemHeight,
                    Location = new Point(0, currentY),
                    Tag = product // Store product object for button handlers
                };

                // --- RIGHT-SIDE BUTTON PLACEMENT (Calculated right-to-left) ---

                // 6. 'X' Remove Button (Rightmost)
                Button removeButton = new Button
                {
                    Text = "X",
                    Width = buttonWidth,
                    Height = itemHeight - 2 * margin,
                    // Location is calculated from the right edge of the productPanel
                    Location = new Point(productPanel.Width - buttonWidth - margin, margin),
                    ForeColor = Color.White,
                    BackColor = Color.Red,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };
                removeButton.Click +=
                    (sender, e) => this.HandleRemoveProduct(productPanel); 

                // 5. '-' Button (Placed to the left of 'X')
                Button subtractButton = new Button
                {
                    Text = "-",
                    Width = buttonWidth,
                    Height = itemHeight - 2 * margin,
                    Location = new Point(removeButton.Left - buttonWidth - margin, margin),
                    Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };
                subtractButton.Click += (sender, e) => this.HandleSubtractProduct(product, 
                    productPanel.Controls.OfType<Label>().FirstOrDefault(l => (l.Tag as Product) == product));


                // 4. '+' Button (Placed to the left of '-')
                Button addButton = new Button
                {
                    Text = "+",
                    Width = buttonWidth,
                    Height = itemHeight - 2 * margin,
                    Location = new Point(subtractButton.Left - buttonWidth - margin, margin),
                    Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };
                addButton.Click += (sender, e) => this.HandleAddProduct(product, 
                    productPanel.Controls.OfType<Label>().FirstOrDefault(l => (l.Tag as Product) == product));

                // 3. Quantity Label (Placed to the left of '+')
                Label quantityLabel = new Label
                {
                    Text = product.Quantity.ToString(),
                    Width = buttonWidth, // Keep the width the same as the button for alignment
                    Height = itemHeight - 2 * margin,
                    Location = new Point(addButton.Left - buttonWidth - margin, margin),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10F),
                    Tag = product, // Tag for easy quantity updates
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                };

                // --- LEFT-SIDE LABEL PLACEMENT ---

                // 2. Product Name Label (Fills the remaining space on the left)
                int nameLabelWidth = quantityLabel.Left - (2 * margin);
                Label nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(margin, margin),
                    Width = nameLabelWidth,
                    Height = itemHeight - 2 * margin,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom
                };
                
                // Add controls to the product panel (Order matters for Z-index, but not layout here)
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(quantityLabel);
                productPanel.Controls.Add(addButton);
                productPanel.Controls.Add(subtractButton);
                productPanel.Controls.Add(removeButton);

                // Add product panel to the list wrapper
                listWrapper.Controls.Add(productPanel);

                // Update Y position for the next item
                currentY += itemHeight;
            }

            // Add the list wrapper to the frame
            this.Frame.Controls.Add(listWrapper);
        }


        private void HandleAddProduct(Product product, Label quantityLabel)
        {
            // Logic to increment product.Quantity in the underlying data structure
            product.Quantity++;
            quantityLabel.Text = product.Quantity.ToString();
            // Re-calculate totals if necessary
        }

        private void HandleSubtractProduct(Product product, Label quantityLabel)
        {
            if (product.Quantity > 1)
            {
                // Logic to decrement product.Quantity in the underlying data structure
                product.Quantity--;
                quantityLabel.Text = product.Quantity.ToString();
                // Re-calculate totals if necessary
            }
            else
            {
                // Option 1: Prevent decrement below 1
                MessageBox.Show("Cannot go below quantity 1. Use 'X' to remove.", "Warning");
                // Option 2: Call HandleRemoveProduct logic directly here
            }
        }

        private void HandleRemoveProduct(Panel productPanel)
        {
            // Get the wrapper panel (the parent)
            Panel listWrapper = productPanel.Parent as Panel;

            if (listWrapper != null)
            {
                listWrapper.Controls.Remove(productPanel);
                productPanel.Dispose();
            }
        }
    }
}