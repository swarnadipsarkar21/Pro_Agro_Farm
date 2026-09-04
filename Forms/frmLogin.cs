using System;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;
using Pro_Agro_farm.Forms;

namespace Pro_Agro_farm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
            btnForgotPassword.Visible = false;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '#';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string role = cmbRole.SelectedItem?.ToString().Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(role) || role == "Select Role")
            {
                lblError.Text = "Please select a role.";
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                if (role == "Admin")
                {
                    bool isValidAdmin = UserRepository.ValidateAdmin(username, password);
                    if (!isValidAdmin)
                    {
                        lblError.Text = "Invalid admin username or password.";
                        btnForgotPassword.Visible = true;
                        return;
                    }

                    OpenAdminPanel();
                }
                else if (role == "User")
                {
                    UserRecord existingUser = UserRepository.GetUserByUsername(username);

                    if (existingUser == null)
                    {
                        // First time this username is used -> register it in the Users table.
                        UserRepository.RegisterUser(username, password, "User");

                        SessionCart.CustomerName = username;
                        SessionCart.SessionId = Guid.NewGuid().ToString();

                        using (frmRegisterSuccess successForm = new frmRegisterSuccess())
                        {
                            DialogResult result = successForm.ShowDialog();

                            if (result == DialogResult.Yes)
                            {
                                OpenMainMenu();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (existingUser.Password != password)
                        {
                            lblError.Text = "Incorrect password. Please re-enter your password.";
                            btnForgotPassword.Visible = true;
                            return;
                        }

                        SessionCart.CustomerName = username;
                        SessionCart.SessionId = Guid.NewGuid().ToString();
                        OpenMainMenu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not log in: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            using (frmForgotPassword forgotForm = new frmForgotPassword())
            {
                if (!string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    forgotForm.PrefillUsername(txtUsername.Text.Trim());
                }
                forgotForm.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenMainMenu()
        {
            this.Hide();
            using (frmMainManu mainMenu = new frmMainManu())
            {
                mainMenu.ShowDialog();
            }
            this.Close();
        }

        private void OpenAdminPanel()
        {
            this.Hide();
            using (frmOrders ordersForm = new frmOrders())
            {
                ordersForm.ShowDialog();
            }
            this.Close();
        }
    }
}