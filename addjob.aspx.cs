using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace jobportel1
{
    public partial class addjob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addjobbtn_Click(object sender, EventArgs e)
        {
            
                    // Retrieve the values entered in the form
                    string jobTitle = title.Text;
                    string jobDescription = Description.Text;
                    string jobLocation = Location.Text;
                    string jobType = jtp.SelectedValue;
                    decimal jobSalary = decimal.Parse(Salary.Text);
                    string email = mail.Text;
                    string company_name = compnyname.Text;

                    // Insert the job details into the database
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\OneDrive\\Documents\\onlinejob.mdf;Integrated Security=True;Connect Timeout=30";
                    string query = "INSERT INTO addjob (title, description, location, job_type, salary,email,company_name) VALUES (@Title, @Description, @Location, @JobType, @Salary,@email,@company)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@Title", jobTitle);
                        command.Parameters.AddWithValue("@Description", jobDescription);
                        command.Parameters.AddWithValue("@Location", jobLocation);
                        command.Parameters.AddWithValue("@JobType", jobType);
                        command.Parameters.AddWithValue("@Salary", jobSalary);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@company", company_name);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Clear the form fields
                    title.Text = "";
                    Description.Text = "";
                    Location.Text = "";
                    jtp.SelectedIndex = 0;
                    Salary.Text = "";
                    mail.Text = "";
                    compnyname.Text = "";

                    // Redirect to the home page or display a success message
                    Response.Redirect("home.aspx");
                }

            }
        }
