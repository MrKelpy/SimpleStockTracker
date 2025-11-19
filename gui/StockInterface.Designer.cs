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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonAddProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxFactor = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decrement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonIncrement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonAddProduct, this.toolStripLabel1, this.textBoxFactor, this.toolStripSeparator1 });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAddProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProduct.Image")));
            this.buttonAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(108, 22);
            this.buttonAddProduct.Text = "Adicionar Produto";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Quantidade:";
            // 
            // textBoxFactor
            // 
            this.textBoxFactor.BackColor = System.Drawing.Color.White;
            this.textBoxFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFactor.Name = "textBoxFactor";
            this.textBoxFactor.Size = new System.Drawing.Size(135, 25);
            this.textBoxFactor.TextChanged += new System.EventHandler(this.textBoxFactor_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.productName, this.productQuantity, this.Decrement, this.buttonIncrement, this.buttonRemove });
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 25);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.Size = new System.Drawing.Size(784, 436);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HandleButtonClicks);
            this.DataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            this.DataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Nome do Produto";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productQuantity
            // 
            this.productQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.productQuantity.HeaderText = "Quantidade";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            this.productQuantity.Width = 87;
            // 
            // Decrement
            // 
            this.Decrement.HeaderText = "";
            this.Decrement.Name = "Decrement";
            this.Decrement.ReadOnly = true;
            this.Decrement.Text = "-";
            this.Decrement.UseColumnTextForButtonValue = true;
            this.Decrement.Width = 70;
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.HeaderText = "";
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.ReadOnly = true;
            this.buttonIncrement.Text = "+";
            this.buttonIncrement.UseColumnTextForButtonValue = true;
            this.buttonIncrement.Width = 70;
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buttonRemove.HeaderText = "";
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.ReadOnly = true;
            this.buttonRemove.Text = "Apagar";
            this.buttonRemove.UseColumnTextForButtonValue = true;
            // 
            // StockInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockInterface";
            this.Text = "BrandInformationInterface";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.ToolStripTextBox textBoxFactor;

        private System.Windows.Forms.DataGridViewButtonColumn buttonIncrement;
        private System.Windows.Forms.DataGridViewButtonColumn buttonRemove;

        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn Decrement;

        private System.Windows.Forms.DataGridViewTextBoxColumn productName;

        private System.Windows.Forms.DataGridView DataGrid;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonAddProduct;

        private System.Windows.Forms.Panel Panel;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}