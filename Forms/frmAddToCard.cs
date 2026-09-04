using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Pro_Agro_farm.Forms
{
    public partial class frmAddToCard : Form
    {
        public frmAddToCard()
        {
            InitializeComponent();
        }

        private void frmAddToCard_Load(object sender, EventArgs e)
        {
            lblCustomerInfo.Text = "Name: " + SessionCart.CustomerName +
                "\nAddress: " + SessionCart.Address;

            lstItems.Items.Clear();
            foreach (CartItem item in SessionCart.Items)
            {
                lstItems.Items.Add(item.ItemName + "   -   Qty: " + item.Quantity.ToString("N2") +
                    "   -   " + item.TotalPrice.ToString("N2") + " taka");
            }

            lblGrandTotal.Text = "Total Amount: " + SessionCart.GrandTotal().ToString("N2") + " taka";
        }

        private void btnBuyMore_Click(object sender, EventArgs e)
        {
            // Skip straight back to frmMainManu, same as the checkout "Yes" flow.
            NavFlow.ReturnToDashboard = true;
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}