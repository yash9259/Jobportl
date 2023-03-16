using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace jobportel1
{
    public partial class Register : System.Web.UI.Page

    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string firstName = firstname.Text;
            string lastName = lastname.Text;
            string email = mail.Text;
            string password = pass.Text;

            // Insert data into SQL Server table
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\OneDrive\\Documents\\onlinejob.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO register (firstName, lastName, email, password) VALUES (@firstName, @lastName, @email, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        // Data inserted successfully
                        Response.Redirect("home.aspx");
                    }
                    else
                    {
                        // Data insertion failed
                        Response.Write("Data insertion failed!");
                    }
                }
            }
        }
    }
}