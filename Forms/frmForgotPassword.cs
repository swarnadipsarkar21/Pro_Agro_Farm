using System;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;

namespace Pro_Agro_farm.Forms
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        public void PrefillUsername(string username)
        {
            txtUsername.Text = username;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            lblErrorFP.Text = "";

            string username = txtUsername.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone))
            {
                lblErrorFP.Text = "Please enter both username and phone number.";
                return;
            }

            try
            {
                UserRecord user = UserRepository.GetUserByUsername(username);

                if (user == null)
                {
                    lblErrorFP.Text = "No account found with this username.";
                    return;
                }

                bool phoneMatches = UserRepository.VerifyPhoneForUser(username, phone);

                if (!phoneMatches)
                {
                    lblErrorFP.Text = "Phone number does not match our purchase records.";
                    return;
                }

                lblCurrentPasswordCaption.Visible = true;
                lblCurrentPasswordValue.Visible = true;
                lblCurrentPasswordValue.Text = user.Password;

                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                lblConfirmPassword.Visible = true;
                txtConfirmPassword.Visible = true;
                btnSave.Visible = true;

                txtUsername.Enabled = false;
                txtPhone.Enabled = false;
                btnVerify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not verify: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                lblErrorFP.Text = "Please enter and confirm your new password.";
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblErrorFP.Text = "Passwords do not match.";
                return;
            }

            try
            {
                UserRepository.UpdatePassword(txtUsername.Text.Trim(), newPassword);

                MessageBox.Show("Your password has been updated. Please log in with your new password.",
                    "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update password: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}