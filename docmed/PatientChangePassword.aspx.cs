using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["patientusername"] == null)
        {
            Response.Redirect("~/index.html");
        }
        Label1.Visible = false;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from Petiant where email='" + Session["patientusername"] + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            TextBox1.Text = dt.Rows[0][1].ToString();
            TextBox2.Text = dt.Rows[0][2].ToString();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string pass = TextBox3.Text;
        string cpass = TextBox4.Text;
        if (pass!=cpass)
        {
            Label1.Visible = true;
            Label1.Font.Bold = true;
            Label1.Text = "Password And Confirm Password Not Match";
        }
        else
        {
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Update  Petiant set password='" + cpass + "' where email='" + Session["patientusername"] + "' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Change Password Successful')</script>");
        }
  

    }

}