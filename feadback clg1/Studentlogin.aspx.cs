using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Studentlogin : System.Web.UI.Page
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



        SqlDataAdapter da = new SqlDataAdapter("Select * from Studentmaster where UserName='" + txtUsername.Text + "' AND Password='" + txtpassword.Text + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            String name = dt.Rows[0][1].ToString();
            String Branch = dt.Rows[0][4].ToString();
            String cls = dt.Rows[0][7].ToString();
            Session["name"] = name;
            Session["branch"] = Branch;
            Session["class"] = cls;
            Session["Username"] = txtUsername.Text;
            Session["Password"] = txtpassword.Text;
            Response.Write("<script LANGUAGE='JavaScript' >alert('Login Successful')</script>");

            Response.Redirect("CurrentDash.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Login Not Successful')</script>");
            Response.Write("Not  Successful");
        }

       



    }
}
