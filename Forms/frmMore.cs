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
    public partial class frmMore : Form
    {
        public frmMore()
        {
            InitializeComponent();
        }

        private void btnBioGas_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBioGas bioGasForm = new frmBioGas())
            {
                bioGasForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnCowFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmCowFeed cowFeedForm = new frmCowFeed())
            {
                cowFeedForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnCalf_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBabyCow babyCowForm = new frmBabyCow())
            {
                babyCowForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnCowHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmCowHide cowHideForm = new frmCowHide())
            {
                cowHideForm.ShowDialog();
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