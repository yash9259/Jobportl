using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace jobportel1
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\onlinejob.mdf;Integrated Security=True;Connect Timeout=30");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from register where email='" + email.Text + "' AND password='" + password.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Response.Write("<script>alert('" + dr.GetValue(0).ToString() + "');</script>");
                    Session["email"] = dr.GetValue(3).ToString();
                    Session["password"] = dr.GetValue(4).ToString();

                }

                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Credentials');</script>");
            }
        }
    }
}