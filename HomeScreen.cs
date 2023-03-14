using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class HomeScreen : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public HomeScreen()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id,name, email, location, title,experience FROM Employee_Data", connection);
                    fillTable(adapter);



                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HS_addButton_Click(object sender, EventArgs e)
        {
            employeeRegd employee = new employeeRegd();
            DialogResult result = employee.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
                HS_dataGridView.Refresh();
            }
        }

        private void HS_deleteButton_Click(object sender, EventArgs e)
        {
            if (HS_dataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = HS_dataGridView.SelectedRows[0].Index;
                    int id = (int)HS_dataGridView.Rows[rowIndex].Cells["id"].Value;
                    deleteSelectedRowById(rowIndex, id);
                }
            }
        }

        private void deleteSelectedRowById(int rowIndex, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Employee_Data WHERE id = @ID", connection);

                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        HS_dataGridView.Rows.RemoveAt(rowIndex);
                        MessageBox.Show("Row deleted successfully.", "Delete Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HS_updateButton_Click(object sender, EventArgs e)
        {
            int rowIndex = HS_dataGridView.SelectedRows[0].Index;
            int id = (int)HS_dataGridView.Rows[rowIndex].Cells["id"].Value;
            employeeRegd employee = new employeeRegd(id);
            DialogResult result = employee.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadData();
                HS_dataGridView.Refresh();
            }
        }

        private void HS_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            // Build the SQL query string based on the values of the text boxes
            string query = "SELECT id,name, email, location, title,experience FROM Employee_Data WHERE 1=1";
            if (!string.IsNullOrEmpty(search_nameTextBox.Text))
            {
                query += " AND Name LIKE '%" + search_nameTextBox.Text + "%'";
            }
            if (!string.IsNullOrEmpty(search_emailTextBox.Text))
            {
                query += " AND Email LIKE '%" + search_emailTextBox.Text + "%'";
            }
            if (!string.IsNullOrEmpty(search_JobTitle.Text))
            {
                query += " AND Title LIKE '%" + search_JobTitle.Text + "%'";
            }
            if (!string.IsNullOrEmpty(search_ExperienceTextBox.Text))
            {
                query += " AND Experience >= " + search_ExperienceTextBox.Text;
            }
            if (!string.IsNullOrEmpty(search_LocationTextBox.Text))
            {
                query += " AND Location LIKE '%" + search_LocationTextBox.Text + "%'";
            }

            // Execute the query against the SQL database
            SqlConnection conn = new SqlConnection(cs);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            fillTable(adapter);

        }

        private void fillTable(SqlDataAdapter adapter)
        {
            DataTable table = new DataTable();
            adapter.Fill(table);
            HS_dataGridView.Columns["mem_name"].DataPropertyName = "name";
            HS_dataGridView.Columns["DGV_email"].DataPropertyName = "email";
            HS_dataGridView.Columns["DGV_location"].DataPropertyName = "location";
            HS_dataGridView.Columns["DGV_title"].DataPropertyName = "title";
            HS_dataGridView.Columns["id"].DataPropertyName = "id";
            HS_dataGridView.Columns["DGV_experience"].DataPropertyName = "experience";
            HS_dataGridView.DataSource = table;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
