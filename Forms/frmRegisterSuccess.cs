using System;
using System.Windows.Forms;

namespace Pro_Agro_farm.Forms
{
    public partial class frmRegisterSuccess : Form
    {
        public frmRegisterSuccess()
        {
            InitializeComponent();
        }

        private void btnMoveForward_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}