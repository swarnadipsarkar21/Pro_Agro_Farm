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
    public partial class frmBabyCow : Form
    {
        public frmBabyCow()
        {
            InitializeComponent();
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            // Local
            this.Hide();
            using (frmLocalBabyCow localForm = new frmLocalBabyCow())
            {
                localForm.ShowDialog();
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
            // Shaheol
            this.Hide();
            using (frmShaheol shaheolForm = new frmShaheol())
            {
                shaheolForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnType3_Click(object sender, EventArgs e)
        {
            // Brahama
            this.Hide();
            using (frmBrahama brahamaForm = new frmBrahama())
            {
                brahamaForm.ShowDialog();
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
            // Closing this form returns control to frmMore, which is
            // waiting on ShowDialog() and will Show() itself again.
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