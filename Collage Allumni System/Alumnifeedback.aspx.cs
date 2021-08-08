using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Alumnifeedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        // SqlCommand cmd = new SqlCommand();
      


        SqlCommand cmd = new SqlCommand("insert into Alumnifeedback (name,branch,feedback)values('" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "')", con);

        con.Open();
        cmd.Connection = con;
        cmd.ExecuteNonQuery(); 
        con.Close();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Feedback Submitted Successful Thank You')</script>");
    }

 
}