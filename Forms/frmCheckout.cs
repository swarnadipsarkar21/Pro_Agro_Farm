using Pro_Agro_farm;
using Pro_Agro_farm.DataAccess;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Pro_Agro_farm.Forms
{
    public partial class frmCheckout : Form
    {
        private readonly int _productId;
        private readonly string _itemName;
        private readonly decimal _quantity;
        private readonly decimal _totalPrice;

        /// <summary>
        /// productId/itemName/quantity/totalPrice come from whichever product
        /// page (e.g. frmMilk) the user pressed "Add to Cart" on, so the
        /// summary here is filled in automatically.
        /// </summary>
        public frmCheckout(int productId, string itemName, decimal quantity, decimal totalPrice)
        {
            _productId = productId;
            _itemName = itemName;
            _quantity = quantity;
            _totalPrice = totalPrice;

            InitializeComponent();

            lblSummary.Text = "Product: " + _itemName +
                "\nQuantity: " + _quantity.ToString("N2") +
                "\nTotal: " + _totalPrice.ToString("N2") + " taka";
        }

        private bool ValidateInputs(out string error)
        {
            error = null;
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                error = "Please enter a phone number.";
                return false;
            }

            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                {
                    error = "Phone number should contain digits only.";
                    return false;
                }
            }

            if (phone.Length != 11)
            {
                error = "Please enter a valid 11 digit phone number.";
                return false;
            }

            if (string.IsNullOrEmpty(address))
            {
                error = "Please enter a delivery address.";
                return false;
            }

            return true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string error;
            if (!ValidateInputs(out error))
            {
                MessageBox.Show(error, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OrderRepository.InsertOrder(_productId, _itemName, _quantity, _totalPrice,
    txtPhone.Text.Trim(), txtAddress.Text.Trim(), SessionCart.CustomerName, SessionCart.SessionId);
                ProductRepository.DecrementStock(_productId, _quantity);

                // Remember this order for the frmAddToCard summary screen.
                SessionCart.Phone = txtPhone.Text.Trim();
                SessionCart.Address = txtAddress.Text.Trim();
                SessionCart.Items.Add(new CartItem
                {
                    ItemName = _itemName,
                    Quantity = _quantity,
                    TotalPrice = _totalPrice 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not place your order: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult addMore = MessageBox.Show(
                " Your order is successfully placed. Do You Want To Add Something?",
                "Order Placed",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (addMore == DialogResult.Yes)
            {
                // Yes -> go straight to frmMainManu, skipping past frmMilk.
                NavFlow.ReturnToDashboard = true;
                this.Close();
            }
            else
            {
                // No -> go to frmAddToCard.
                this.Hide();
                using (frmAddToCard cartForm = new frmAddToCard())
                {
                    cartForm.ShowDialog();
                }
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Takes the user back to the previous page (frmMilk).
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            // No -> remain on this page, do nothing.
        }
    }
}