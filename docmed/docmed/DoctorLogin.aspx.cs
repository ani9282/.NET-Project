using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DoctorLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = txtUsername.Text;
        string pass = txtpassword.Text;
        string dName = null;
           
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from DoctorReg where Email='" + name + "' AND Passowrd='" + pass + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            dName = dt.Rows[0][1].ToString();
            Session["dName"] = dName;
            Response.Redirect("~/DoctorDashboard.aspx"); 
        }
        else
        {
            Label1.Visible = true;
            Label1.Font.Bold = true;
            Label1.Text = "Please Re-Enter Credential";
        }
    }
}