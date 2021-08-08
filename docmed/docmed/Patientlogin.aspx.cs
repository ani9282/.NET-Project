using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

public partial class Patientlogin : System.Web.UI.Page
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
        string pName = null;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from Petiant where email='" + name + "' AND password='" + pass + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            dName = dt.Rows[0][1].ToString();
            Session["dName"] = dName;
            Session["patientusername"] = name;
            Session["pName"] = pName;
            Response.Redirect("~/PatientDashboard.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Font.Bold = true;
            Label1.Text = "Please Re-Enter Credential";
        }
    }


}