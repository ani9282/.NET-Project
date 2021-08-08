using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Stafflogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
    private SqlCommand cmd;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();



        SqlDataAdapter da = new SqlDataAdapter("Select * from teachermaster where UserName='" + txtUsername.Text + "' AND Password='" + txtpassword.Text + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            string str = dt.Rows[0][1].ToString();
            Session["name"] = str;
            string st = dt.Rows[0][4].ToString();
            Session["Branch"] = st;

            Session["Username"] = txtUsername.Text;
            Session["Password"] = txtpassword.Text;

            //Response.Write("<script LANGUAGE='JavaScript' >alert('Login Successful')</script>");

            Response.Redirect("StaffDashboard.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Login Not successful')</script>");
             Response.Write("Not  Successful");
        }

        



    }
}
