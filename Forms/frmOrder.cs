using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;

namespace Pro_Agro_farm.Forms
{
    public partial class frmOrders : Form
    {
        private BindingList<OrderGroupRow> _rows;

        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                List<OrderRow> allOrders = OrderRepository.GetAllOrders();

                var groups = allOrders
                    .GroupBy(o => string.IsNullOrEmpty(o.SessionId) ? "order-" + o.OrderID : o.SessionId)
                    .Select(g => new OrderGroupRow
                    {
                        SessionId = g.Key,
                        CustomerName = g.First().CustomerName,
                        Phone = g.First().CustomerPhone,
                        Address = g.First().CustomerAddress,
                        ItemsSummary = string.Join("\n", g.Select(o =>
                            o.ItemName + "  x" + o.QuantityOrdered.ToString("N2") +
                            "  (" + o.TotalPrice.ToString("N2") + " taka)")),
                        TotalPrice = g.Sum(o => o.TotalPrice),
                        Delivered = g.All(o => o.Delivered)
                    })
                    .ToList();

                _rows = new BindingList<OrderGroupRow>(groups);
                dgvOrders.DataSource = _rows;
                dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // SessionId is only needed internally (to update delivery status) -
                // remove it from the visible grid entirely.
                dgvOrders.Columns.Remove("SessionId");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load orders: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer row first.", "No Row Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvOrders.CurrentRow.Index;
            OrderGroupRow row = _rows[selectedIndex];

            if (row.Delivered)
            {
                MessageBox.Show("This order is already marked as delivered.", "Already Delivered",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                OrderRepository.UpdateDeliveryStatusForSession(row.SessionId, true);
                row.Delivered = true;

                // DeliveredText is a computed property, so tell the grid this row changed
                // so the "Delivery Status" column re-reads it and shows "Delivered".
                _rows.ResetItem(selectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update delivery status: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmProduct productForm = new frmProduct())
            {
                productForm.ShowDialog();
            }
            this.Close();
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

    /// <summary>One grouped row (per customer purchase session) shown in the admin orders grid.</summary>
    public class OrderGroupRow
    {
        public string SessionId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ItemsSummary { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Delivered { get; set; }

        /// <summary>What the "Delivery Status" grid column displays.</summary>
        public string DeliveredText
        {
            get { return Delivered ? "Delivered" : ""; }
        }
    }
}