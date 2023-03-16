using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using static jobportel1.home;

namespace jobportel1
{
    public partial class home : System.Web.UI.Page
    {
        public List<Job> Jobs { get; private set; }

        public class Job
        {
            public int JobId { get; set; }
            public string JobTitle { get; set; }
            public string JobDescription { get; set; }
            public string JobLocation { get; set; }
            public string JobType { get; set; }
            public decimal JobSalary { get; set; }
            public string email { get; set; }
            public string company_name { get; set; }
            public List<Job> Jobs { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        
        {
            List<Job> jobs = GetJobs();

            Jobs = GetJobs();
            if (!IsPostBack)
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\OneDrive\\Documents\\onlinejob.mdf;Integrated Security=True;Connect Timeout=30"; // replace with your actual connection string
                string email = Session["Email"].ToString(); // get the email address from the session variable
                string name = ""; // initialize a variable to store the name

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT firstName FROM register WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        name = reader.GetString(0);
                    }

                    reader.Close();
                    connection.Close();
                }

                Session["UserName"] = name; // store the name in a session variable
            }

        }
        
        public List<Job> GetJobs()
        {
            List<Job> jobs = new List<Job>();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\OneDrive\\Documents\\onlinejob.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM addjob";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Job job = new Job();

                    job.JobId = reader.GetInt32(0);
                    job.JobTitle = reader.GetString(1);
                    job.JobDescription = reader.GetString(2);
                    job.JobLocation = reader.GetString(3);
                    job.JobType = reader.GetString(4);
                    job.JobSalary = reader.GetDecimal(5);
                    job.email = reader.GetString(6);
                    job.company_name = reader.GetString(7);
                    
                    jobs.Add(job);
                }

                reader.Close();
                connection.Close();
            }

            return jobs;

        }
       }

}