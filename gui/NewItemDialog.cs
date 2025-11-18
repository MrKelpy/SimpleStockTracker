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
        public string ItemName => textBox1.Text;
        
        /// <summary>
        /// The resulting item quantity.
        /// </summary>
        public int ItemQuantity => (int)numericUpDown1.Value;
        
        /// <summary>
        /// Builds a generic new item dialog.
        /// </summary>
        /// <param name="name"></param>
        public NewItemDialog(string name)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the item name as the user types it. The name
        /// may only be alphanumeric and must be between 1 and 50 characters long.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e) =>
            buttonConfirm.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) &&
                              textBox1.Text.Length <= 50;
        
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}