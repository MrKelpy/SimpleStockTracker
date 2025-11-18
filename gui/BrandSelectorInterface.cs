using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SimpleStockTracker.common.models;
using SimpleStockTracker.common.utils;

namespace SimpleStockTracker.gui
{
    /// <summary>
    /// This interface is responsible for displaying buttons for selecting different brands modularly.
    /// </summary>
    internal partial class BrandSelectorInterface : Form
    {
        /// <summary>
        /// The maximum number of brand buttons to display per row.
        /// </summary>
        private int BrandLimitPerRow { get; set; } = 4;
        
        /// <summary>
        /// The height of each row in the brand selector interface. This will
        /// directly impact the button size as well.
        /// </summary>
        private int RowHeight { get; set; } = 100;

        /// <summary>
        /// The margin between each button in the brand selector interface, including the top
        /// </summary>
        private int ButtonMargin { get; set; }
        
        public BrandSelectorInterface()
        {
            this.InitializeComponent();
            this.CenterToScreen();

            this.SizeChanged += (sender, args) => this.BuildPanelLayout();
            this.ButtonMargin = this.RowHeight / 2;
            this.BuildPanelLayout();
        }

        /// <summary>
        /// Builds the panel layout containing the brand buttons which will be displayed to the user as a grid.
        /// </summary>
        public void BuildPanelLayout()
        {
            List<Brand> brands = StockUtils.GetBrands();

            this.Frame.Controls.Clear(); // IMPORTANT: to avoid duplicates

            if (brands.Count == 0)
            {
                Label noBrandsLabel = new Label
                {
                    Text = @"Não existem marcas registadas.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 14F)
                };

                this.Frame.Controls.Add(noBrandsLabel);
                return;
            }

            int availableWidth = this.Frame.ClientSize.Width;

            double columnWidth = (double)availableWidth / this.BrandLimitPerRow;
            int squareDimension = (int)columnWidth - this.ButtonMargin;
            int containerSize = squareDimension + this.ButtonMargin;
            
            // cap square dimension to row height
            squareDimension = Math.Min(squareDimension, this.RowHeight*3);
            int rowAmount = (int)Math.Ceiling((double)brands.Count / this.BrandLimitPerRow);

            Panel contentWrapper = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = false,
                Height = rowAmount * containerSize,
                Padding = new Padding(10)
            };

            for (int i = 0; i < brands.Count; i++)
            {
                Panel container = new Panel
                {
                    Width = containerSize,
                    Height = containerSize,
                    Location = new Point(
                        (i % this.BrandLimitPerRow) * containerSize,
                        (i / this.BrandLimitPerRow) * containerSize
                    )
                };

                Bitmap image = brands[i].GetImage();
                bool hasImage = image != null;
                
                Button brandButton = new Button
                {
                    Text = hasImage ? "" : brands[i].Name,
                    Tag = brands[i].ConfigPath,
                    Image = hasImage ? new Bitmap(image, new Size(squareDimension, squareDimension)) : null,
                    ImageAlign = ContentAlignment.MiddleCenter,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    
                    Width = squareDimension,
                    Height = squareDimension,
                    Location = new Point(
                        (container.Width - squareDimension) / 2,
                        (container.Height - squareDimension) / 2
                    ),
                    Anchor = AnchorStyles.None
                };
                
                // Event handler for when a brand button is clicked
                brandButton.Click += (sender, args) =>
                {
                    Control control = (Control) sender;
                    new StockInterface(new Brand(control.Tag.ToString())).Show();
                };

                container.Controls.Add(brandButton);
                contentWrapper.Controls.Add(container);
            }

            this.Frame.Controls.Add(contentWrapper);
        }

        /// <summary>
        /// Adds a new brand when the add brand button is clicked.
        /// </summary>
        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            NewItemDialog newItemDialog = new NewItemDialog(true);
            newItemDialog.ShowDialog();

            if (newItemDialog.DialogResult != DialogResult.OK) return;
            
            StockUtils.RegisterNewBrand(newItemDialog.ItemNameResult);
            this.BuildPanelLayout();
        }
    }
}