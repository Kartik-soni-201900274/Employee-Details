using Employee_Details.Properties;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;

using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Employee_Details
{

    public partial class employeeRegd : Form
    {
        public int userId;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        ConnectDatabase connectDatabase = new ConnectDatabase();
        string[] gender_list = { "Male", "Female", "Others" };
        public employeeRegd()
        {
            InitializeComponent();

            Initialize_genderDropdown();


        }
        public employeeRegd(int userId)
        {

            InitializeComponent();
            Initialize_genderDropdown();

            this.userId = userId;
            InitializeWithData();

        }

        private void InitializeWithData()
        {
            label8.Text = "Update Member";
            using (SqlConnection sqlConnection = new SqlConnection(cs))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Employee_Data WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // add a parameter for the ID value
                command.Parameters.AddWithValue("@Id", userId);

                // execute the command and retrieve the data
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    if (reader.GetString(1) == "Male")
                    {
                        Add_genderCombo.SelectedIndex = 0;
                    }
                    else
                    {
                        Add_genderCombo.SelectedIndex = 1;
                    }
                    //--------------------------------------------------------------------
                    //set ImageBox
                    byte[] imageData = (byte[])reader["userImage"];
                    MemoryStream memoryStream = new MemoryStream(imageData);
                    Add_PictureBox.Image = Image.FromStream(memoryStream);
                    //-----------------------------------------------------------------------
                    //set DatePicker
                    DateTime dateValue = reader.GetDateTime(4);
                    string dateString = dateValue.ToString("dd/MM/yyyy");
                    DateTime parsedDate;

                    if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                    {
                        Add_dateTimePickr.Value = parsedDate;
                    }
                    //------------------------------------------------------------------------
                    //set other textboxes
                    Add_nameTextBox.Text = reader.GetString(0);
                    Add_ExperienceTextBox.Text = reader.GetInt32(6).ToString();
                    Add_JobTitle.Text = reader.GetString(3);

                    Add_ageTextBox.Text = reader.GetInt32(5).ToString();
                    Add_emailTextBox.Text = reader.GetString(2);

                    Add_PhoneTextBox.Text = reader.GetString(9);
                    Add_LocationTextBox.Text = reader.GetString(10);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void employeeRegd_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void add_experiencetextbox_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }


        }

        private void add_agetextbox_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void Initialize_genderDropdown()
        {
            Add_genderCombo.Items.AddRange(gender_list);
            Add_genderCombo.SelectedIndex = 0;
            Add_genderCombo.BackColor = Color.White;
        }

        private void clearTextBox()
        {
            Add_nameTextBox.Clear();
            Add_ExperienceTextBox.Clear();
            Add_JobTitle.Clear();
            Add_dateTimePickr.ResetText();
            Add_ageTextBox.Clear();
            Add_emailTextBox.Clear();
            Add_genderCombo.SelectedIndex = 0;
            Add_PhoneTextBox.Clear();
            Add_LocationTextBox.Clear();

        }

        private void Add_ResetButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void Add_ClearButton_Click(object sender, EventArgs e)
        {
            Add_PictureBox.Image = Resources.userImg;
        }

        private void Add_BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp; *.jpg; *.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Add_PictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Add_SaveButton_Click(object sender, EventArgs e)
        {
            bool nullcheck = nullCheckTextBoxes(panel4);
            bool emailcheck = ValidateEmail(Add_emailTextBox.Text);
            if (nullcheck && emailcheck && userId==null)
            {
                int res = connectDatabase.insertDataIntoDatabase(getemployeeobject());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           else if (nullcheck && emailcheck && userId!=null)
            
            {
                int res = connectDatabase.updateDataIntoDatabase(getemployeeobject(),userId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else if (nullcheck == false)
            {
                MessageBox.Show("An error occurred: " + "Feilds Cannot Be Empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("An error occurred: " + "Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Add_CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }


        private void Add_Email_Validating(object sender, CancelEventArgs e)
        {

            if (ValidateEmail(Add_emailTextBox.Text) == false)
            {
                Email_errorProvider.SetError(Add_emailTextBox, "Incorrect Email");
                e.Cancel = false;

            }
            else
            {
                // Clear the ErrorProvider error message.
                Email_errorProvider.SetError(Add_emailTextBox, "");
                e.Cancel = false;
            }
        }

        private byte[] convertimagetobytes()
        {
            MemoryStream ms = new MemoryStream();
            Add_PictureBox.Image.Save(ms, Add_PictureBox.Image.RawFormat);
            return ms.GetBuffer(); //getbuffer converts mermory stream data to bytes
        }



        private EmployeeCardModel getemployeeobject()
        {
            int experienceint = int.Parse(Add_ExperienceTextBox.Text);
            int ageint = int.Parse(Add_ageTextBox.Text);
            EmployeeCardModel employee = new EmployeeCardModel(name: Add_nameTextBox.Text,
                gender: Add_genderCombo.Text,
            email: Add_emailTextBox.Text,
            title: Add_JobTitle.Text,
            joiningDate: Add_dateTimePickr.Text,
           age: ageint,
           experience: experienceint,
           location: Add_LocationTextBox.Text,
           image: convertimagetobytes(), phone: Add_PhoneTextBox.Text);
            return employee;
        }


        public bool nullCheckTextBoxes(Control container)
        {
            bool isValid = true;


            foreach (Control control in container.Controls)
            {

                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isValid = false;

                }
            }
            return isValid;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}


