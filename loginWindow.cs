using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class loginWindow : MaterialSkin.Controls.MaterialForm
    {
        string mask = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8, 20}$";

        public loginWindow()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400,
                                                              Primary.Blue500,
                                                              Primary.Blue500,
                                                              Accent.LightBlue200,
                                                              TextShade.WHITE);
            passwordTextBox.TrailingIconClick += new System.EventHandler(this.eyeIconClick);
        }

        private void eyeIconClick(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.PasswordChar = '●';
            }


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                errorUsername.SetError(usernameTextBox, "Feild can't be empty");

            }


        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            string toottipText = "It must contain/n at least 8 characters and at most 20 characters.\r\nIt must contain at least one digit.\r\nIt must contain at least one upper case alphabet.\r\nIt must contain at least one lower case alphabet.";
            passwordTooltip.SetToolTip(passwordTextBox, toottipText);

        }

        private void materialCard1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {

            if (Regex.IsMatch(passwordTextBox.Text, mask) != true)
            {
                errorPassword.SetError(passwordTextBox, "Invalid Passowrd");
                passwordTextBox.ResetText();
                passwordTextBox.Focus();

            }
            else
            {
                loginButton.Enabled = true;
            }

        }

        private void usernameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                passwordTextBox.Enabled = false;
                loginButton.Enabled = false;

            }
            else
            {
                passwordTextBox.Enabled = true;
                loginButton.Enabled = true;
            }
        }
    }
}
