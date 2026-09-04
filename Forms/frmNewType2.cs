using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;

namespace Pro_Agro_farm.Forms
{
    public partial class frmNewType2 : Form
    {
        private Product _product;

        public frmNewType2()
        {
            InitializeComponent();
        }

        private void frmNewType2_Load(object sender, EventArgs e)
        {
            try
            {
                _product = ProductRepository.GetByCategory("NewType2");
                lblPricePerUnit.Text = "Price per Unit: " + _product.Price.ToString("N2") + " taka";
                lblAvailable.Text = "Available stock: " + _product.AvailableQty.ToString("N2") + " " + _product.Unit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load price: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal quantity;
            string text = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                lblTotalPrice.Text = "Total Price : 0.00 taka";
                return;
            }

            if (!decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out quantity) || quantity <= 0)
            {
                lblTotalPrice.Text = "Please enter a valid quantity.";
                return;
            }

            if (_product != null && quantity > _product.AvailableQty)
            {
                lblTotalPrice.Text = "Only " + _product.AvailableQty.ToString("N2") + " " + _product.Unit + " available.";
                return;
            }

            decimal total = quantity * (_product != null ? _product.Price : 0);
            lblTotalPrice.Text = "Total Price : " + total.ToString("N2") + " taka";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            decimal quantity;
            string text = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(text) ||
                !decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity first.", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_product == null)
            {
                MessageBox.Show("Product info is not loaded yet.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity > _product.AvailableQty)
            {
                MessageBox.Show("Only " + _product.AvailableQty.ToString("N2") + " " + _product.Unit + " available.",
                    "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = quantity * _product.Price;

            this.Hide();

            if (OrderFlow.HandleAddToCart(_product.ProductID, _product.ItemName, quantity, total))
            {
                this.Close();
                return;
            }

            // Came back via Checkout's Back button - refresh stock/price and show again.
            try
            {
                _product = ProductRepository.GetByCategory("NewType2");
                lblAvailable.Text = "Available stock: " + _product.AvailableQty.ToString("N2") + " " + _product.Unit;
                lblPricePerUnit.Text = "Price per Unit: " + _product.Price.ToString("N2") + " taka";
                textBox1.Text = "";
            }
            catch
            {
                // ignore refresh errors, not critical
            }

            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Takes the user back to the previous page (frmNewZealandCow).
            this.Close();
        }
    }
}