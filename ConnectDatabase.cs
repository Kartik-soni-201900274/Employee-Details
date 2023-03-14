using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public class ConnectDatabase
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SqlDataReader getDataUsingId(int userId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(cs))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Employee_Data WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // add a parameter for the ID value
                command.Parameters.AddWithValue("@Id", userId);

                // execute the command and retrieve the data
                SqlDataReader reader = command.ExecuteReader();
                return reader;

            }
        }
        public SqlDataReader getAllRecords()
        {


            SqlConnection sqlConnection = new SqlConnection(cs);
            string query = "select * from Employee_Data";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public int insertDataIntoDatabase(EmployeeCardModel employee)
        {

            string sql = "INSERT INTO Employee_Data (name, gender,email,title,joiningDate,age,experience,userImage,phone,location) VALUES (@name, @gender,@email,@title,@joiningDate,@age,@experience,@userImage,@phone,@location)";

            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", employee.Name.ToCamelCase());
            command.Parameters.AddWithValue("@gender", employee.Gender);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@title", employee.Title.ToCamelCase());
            command.Parameters.AddWithValue("@joiningDate", employee.JoiningDate);
            command.Parameters.AddWithValue("@age", employee.Age);
            command.Parameters.AddWithValue("@experience", employee.Experience);
            command.Parameters.AddWithValue("@userImage", employee.Image);
            command.Parameters.AddWithValue("@phone", employee.Phone);
            command.Parameters.AddWithValue("@location", employee.Location);



            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;


        }

        public int updateDataIntoDatabase(EmployeeCardModel employee,int userId)
        {

            string sql = "UPDATE Employee_Data SET name = @name, gender = @gender, email = @email, title = @title, joiningDate = @joiningDate, age = @age, experience = @experience, userImage = @userImage, phone = @phone, location = @location WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", employee.Name.ToCamelCase());
            command.Parameters.AddWithValue("@gender", employee.Gender);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@title", employee.Title.ToCamelCase());
            command.Parameters.AddWithValue("@joiningDate", employee.JoiningDate);
            command.Parameters.AddWithValue("@age", employee.Age);
            command.Parameters.AddWithValue("@experience", employee.Experience);
            command.Parameters.AddWithValue("@userImage", employee.Image);
            command.Parameters.AddWithValue("@phone", employee.Phone);
            command.Parameters.AddWithValue("@location", employee.Location);
            command.Parameters.AddWithValue("@ID",userId);



            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;


        }



    }
}
