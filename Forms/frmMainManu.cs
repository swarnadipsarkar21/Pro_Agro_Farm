using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pro_Agro_farm.Forms;

namespace Pro_Agro_farm
{
    public partial class frmMainManu : Form
    {
        public frmMainManu()
        {
            InitializeComponent();
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmMilk milkForm = new frmMilk())
            {
                milkForm.ShowDialog();
            }
            NavFlow.ReturnToDashboard = false;
            this.Show();
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmMeat meatForm = new frmMeat())
            {
                meatForm.ShowDialog();
            }
            NavFlow.ReturnToDashboard = false;
            this.Show();
        }

        private void btnButter_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmButter butterForm = new frmButter())
            {
                butterForm.ShowDialog();
            }
            NavFlow.ReturnToDashboard = false;
            this.Show();
        }

        private void btnCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmCow cowForm = new frmCow())
            {
                cowForm.ShowDialog();
            }
            NavFlow.ReturnToDashboard = false;
            this.Show();
        }
        private void btnMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmMore moreForm = new frmMore())
            {
                moreForm.ShowDialog();
            }
            NavFlow.ReturnToDashboard = false;
            this.Show();
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAddToCard cartForm = new frmAddToCard())
            {
                cartForm.ShowDialog();
            }
            NavFlow.ReturnToDashboard = false;
            this.Show();
        }
    }
}