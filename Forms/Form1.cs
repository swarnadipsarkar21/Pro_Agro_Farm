using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Agro_farm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGoToLogin.Click += btnGoToLogin_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
