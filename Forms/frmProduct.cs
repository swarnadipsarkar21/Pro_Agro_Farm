using System;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;

namespace Pro_Agro_farm.Forms
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                dgvProducts.DataSource = ProductRepository.GetAllProducts();

                // Lock everything except Price and AvailableQty from editing.
                foreach (DataGridViewColumn col in dgvProducts.Columns)
                {
                    if (col.Name == "Price" || col.Name == "AvailableQty")
                    {
                        col.ReadOnly = false;
                    }
                    else
                    {
                        col.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load products: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvProducts.EndEdit();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow) continue;

                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                string itemName = row.Cells["ItemName"].Value?.ToString();

                decimal price;
                decimal qty;

                if (!decimal.TryParse(row.Cells["Price"].Value?.ToString(), out price) || price < 0)
                {
                    MessageBox.Show("Invalid price for " + itemName + ". Please enter a valid non-negative number.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(row.Cells["AvailableQty"].Value?.ToString(), out qty) || qty < 0)
                {
                    MessageBox.Show("Invalid quantity for " + itemName + ". Please enter a valid non-negative number.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal qty = Convert.ToDecimal(row.Cells["AvailableQty"].Value);

                    ProductRepository.UpdatePriceAndStock(productId, price, qty);
                }

                MessageBox.Show("All product changes have been saved.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save changes: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}