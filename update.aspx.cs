using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace jobportel1
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            

            // Connection string for the SQL database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\OneDrive\\Documents\\onlinejob.mdf;Integrated Security=True;Connect Timeout=30";

            // SQL query for updating a row in the register table
            string sqlQuery = "UPDATE register SET firstName=@firstName, lastName=@lastName, password=@password WHERE email=@email";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlCommand using the SQL query and SqlConnection
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Set the parameter values for the SQL query
                    command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    

                    // Open the SqlConnection
                    connection.Open();

                    // Execute the SQL query and get the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // Close the SqlConnection
                    connection.Close();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        // Update was successful
                    }
                    else
                    {
                        // Update failed
                    }
                }
            }

        }
    }
}