using System.ComponentModel;

namespace SimpleStockTracker.gui
{
    partial class StockInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInterface));
            this.Frame = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonAddBrand = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.AutoScroll = true;
            this.Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frame.Location = new System.Drawing.Point(0, 25);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(784, 436);
            this.Frame.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonAddBrand });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAddBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBrand.Image")));
            this.buttonAddBrand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(108, 22);
            this.buttonAddBrand.Text = "Adicionar Produto";
            // 
            // StockInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Frame);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StockInterface";
            this.Text = "BrandInformationInterface";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel Frame;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonAddBrand;

        private System.Windows.Forms.Panel Panel;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}