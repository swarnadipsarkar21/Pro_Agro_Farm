using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Agro_farm.Forms
{
    public partial class frmAustralianCow : Form
    {
        public frmAustralianCow()
        {
            InitializeComponent();
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAusType1 typeForm = new frmAusType1())
            {
                typeForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAusType2 typeForm = new frmAusType2())
            {
                typeForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Takes the user back to the previous page (frmCow).
            this.Close();
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAddToCard cartForm = new frmAddToCard())
            {
                cartForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                this.Close();
                return;
            }

            this.Show();
        }
    }
}