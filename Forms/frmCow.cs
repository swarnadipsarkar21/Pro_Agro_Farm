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
    public partial class frmCow : Form
    {
        public frmCow()
        {
            InitializeComponent();
        }

        private void btnBangladeshiCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBangladeshiCow bdCowForm = new frmBangladeshiCow())
            {
                bdCowForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }
        private void btnNewZealandCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmNewZealandCow nzCowForm = new frmNewZealandCow())
            {
                nzCowForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnAustralianCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAustralianCow ausCowForm = new frmAustralianCow())
            {
                ausCowForm.ShowDialog();
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
            // Closing this form returns control to frmMainManu, which is
            // waiting on ShowDialog() and will Show() itself again.
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}