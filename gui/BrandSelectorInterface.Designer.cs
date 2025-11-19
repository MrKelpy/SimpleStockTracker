using System.ComponentModel;

namespace SimpleStockTracker.gui
{
    internal partial class BrandSelectorInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandSelectorInterface));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonGenerateReport = new System.Windows.Forms.ToolStripButton();
            this.buttonAddBrand = new System.Windows.Forms.ToolStripButton();
            this.Frame = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonGenerateReport, this.buttonAddBrand });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateReport.Image")));
            this.buttonGenerateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(97, 22);
            this.buttonGenerateReport.Text = "Obter Inventário";
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAddBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBrand.Image")));
            this.buttonAddBrand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(98, 22);
            this.buttonAddBrand.Text = "Adicionar Marca";
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // Frame
            // 
            this.Frame.AutoScroll = true;
            this.Frame.BackColor = System.Drawing.Color.White;
            this.Frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frame.Location = new System.Drawing.Point(0, 25);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(794, 446);
            this.Frame.TabIndex = 1;
            // 
            // BrandSelectorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 471);
            this.Controls.Add(this.Frame);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "BrandSelectorInterface";
            this.Text = "Logística de Stock";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripButton buttonAddBrand;

        private System.Windows.Forms.ToolStripButton buttonGenerateReport;

        private System.Windows.Forms.Panel Frame;

        private System.Windows.Forms.ToolStrip toolStrip1;

        #endregion
    }
}