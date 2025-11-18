using System;
using System.Windows.Forms;

namespace SimpleStockTracker.gui
{
    /// <summary>
    /// This dialog allows the user to create a new stock item.
    /// </summary>
    public partial class NewItemDialog : Form
    {

        /// <summary>
        /// The resulting item name.
        /// </summary>
        public string ItemNameResult;

        /// <summary>
        /// The resulting item quantity.
        /// </summary>
        public int ItemQuantityResult;
        
        /// <summary>
        /// Builds a generic new item dialog that can either be used for brands or products.
        /// </summary>
        public NewItemDialog(bool brand = true)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            
            this.Text = brand ? "Adicionar Marca" : "Adicionar Produto";
            this.labelName.Text = brand ? "Nome da Marca" : "Nome do Produto";
            this.labelQuantity.Visible = this.numericUpDown1.Visible = !brand;
        }

        /// <summary>
        /// Validates the item name as the user types it. The name
        /// may only be alphanumeric and must be between 1 and 50 characters long.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e) =>
            buttonConfirm.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) &&
                              textBox1.Text.Length <= 50;
        
        /// <summary>
        /// Confirms the creation of the new item, saves the results, and closes the dialog.
        /// </summary>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.ItemNameResult = textBox1.Text;
            this.ItemQuantityResult = (int) numericUpDown1.Value;
            this.Close();
        }

        
        /// <summary>
        /// Cancels the creation of the new item and closes the dialog.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}